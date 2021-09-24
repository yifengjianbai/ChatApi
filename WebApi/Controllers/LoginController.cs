using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using System.Net.Http;
using IdentityModel.Client;
using Microsoft.Extensions.Configuration;
using WebApi.Models.Response;
using Consul;
using System.Threading;
using System.Text;
using WebApi.MiddleWare;
using DbService.IService;
using Infrastructure.CommonModels.User;
using Infrastructure.CommonModels;
using Infrastructure.Enums;
using Infrastructure;
using Infrastructure.Helpers;
using DbService.Models;

namespace WebApi.Controllers
{
    /// <summary>
    /// 登录相关
    /// </summary>
    [ApiController]
    [Route("api/[controller]/[action]")]
    public class LoginController : RedPaperController
    {
        public IConfiguration _Configuration;
        private readonly ILoginService _loginSerivce;
        private readonly IUserService _userService;

        public LoginController(IConfiguration configuration,
            ILoginService loginSerivce,
            IUserService userService)
        {
            _Configuration = configuration;
            _loginSerivce = loginSerivce;
            _userService = userService;


        }

        /// <summary>
        /// Cousul健康检查
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [AllowAnonymous]
        public IActionResult Check()
        {
            return Ok();
        }

        [AllowAnonymous]
        [HttpPost]
        [ServiceFilter(typeof(DistributeLockFilter))]
        public IActionResult TestLock()
        {
            Console.WriteLine("begin lock");
            Thread.Sleep(5000);
            Console.WriteLine("end lock");
            return Ok();
        }

        /// <summary>
        /// 登录-演示授权，非实际接口
        /// </summary>
        /// <returns>登录成功，返回token</returns>
        [AllowAnonymous]
        [HttpPost]
        public async Task<ResponseBase<string>> Login()
        {
            var response = new ResponseBase<string>();
            try
            {
                //验证用户密码
                bool res = true;
                if (res)
                {
                    var client = new HttpClient();
                    string OAuthAddress = ((ConfigurationSection)_Configuration.GetSection("AppSetting:IdentityServerUrl")).Value;
                    string ClientId = ((ConfigurationSection)_Configuration.GetSection("AppSetting:OAuthClientId")).Value;
                    string Scope = ((ConfigurationSection)_Configuration.GetSection("AppSetting:Scope")).Value;
                    string ClientSecret = ((ConfigurationSection)_Configuration.GetSection("AppSetting:ClientSecret")).Value;

                    //鉴权、授权中心
                    var discovery = await client.GetDiscoveryDocumentAsync(
                                            new DiscoveryDocumentRequest
                                            {
                                                Address = OAuthAddress,
                                                Policy = new DiscoveryPolicy { RequireHttps = false }
                                            });

                    if (discovery.IsError)
                    {
                        response.Code = 401;
                        response.Message = "授权验证失败";
                        response.Result = OAuthAddress;
                        return response;
                    }

                    // request token
                    var tokenResponse = await client.RequestClientCredentialsTokenAsync(new ClientCredentialsTokenRequest
                    {
                        Address = discovery.TokenEndpoint,
                        ClientId = ClientId,
                        ClientSecret = ClientSecret,
                        Scope = Scope
                    });

                    if (tokenResponse.IsError)
                    {
                        response.Code = 402;
                        response.Message = "授权验证失败";
                        return response;
                    }
                    response.Result = tokenResponse.AccessToken;
                }
                else
                {
                    response.Code = 402;
                    response.Message = "用户名或密码错误";
                }
            }
            catch (Exception ex)
            {
                response.Code = 500;
                response.Message = ex.ToString();
            }
            return response;
        }




        /// <summary>
        /// 注册用户
        /// </summary>
        /// <param name="registUserInfo">注册用户信息</param>
        /// <returns></returns>
       
        [HttpPost]
        public async Task<ResponseBase<UserInfoOutput>> Regist(RegistUserInfo registUserInfo)
        {
            var entity = await _loginSerivce.RegistAsync(registUserInfo);
            var data = new UserInfoOutput();
            data.UserId = entity.UserId;
            data.Nickname = entity.NickName;
            data.AvatarUrl = entity.AvatarUrl;
            data.Genders = (GenderType)entity.Genders;
            return Success(data);

        }

        /// <summary>
        /// 短信发送验证码
        /// </summary>
        /// <param name="phone">手机号</param>
        /// <returns></returns>
        [HttpGet]
        public ResponseBase<string> SendVerifyCode(string phone)
        {
            //验证手机号
            if (phone.IsNullOrWhitespace())
            {
                return Fail<string>("手机号不能为空", (int)RedPaperApiCode.Error_Param);
            }
            if (!phone.IsTelephone())
            {
                return Fail<string>("手机号格式错误", (int)RedPaperApiCode.Error_Param);
            }

            //验证码生成
            var key = $"phone:{phone}:VerifyCode";
            if (RedisHelper.Instance.IsSet(key))
            {
                RedisHelper.Instance.Remove(key);
            }

            var rd = new Random();
            var code = rd.Next(100000, 1000000).ToString();
            var cacheTime = Convert.ToInt32(_Configuration["VerfiyCodeTimeOutPeriod"]);
            RedisHelper.Instance.Set(key, code, cacheTime);

            var curId = DateTime.Now.Ticks.ToString();

            //短信发送
            var result = MessageHelper.SendCode(phone, code, curId, cacheTime.ToString());
            return Success(result);

        }

        /// <summary>
        /// 验证手机是否有效
        /// </summary>
        /// <param name="phone">手机号</param>
        /// <param name="code">验证码</param>
        /// <returns></returns>
        [HttpGet]
        public ResponseBase<bool> VerifyPhone(string phone, string code)
        {
            var key = $"phone:{phone}:VerifyCode";
            var verifyCode = RedisHelper.Instance.Get<String>(key);

            if (verifyCode.IsNullOrWhitespace())
            {
                return Fail("验证码已过期，请重新验证", 0, false);
            }

            if (!verifyCode.Equals(code))
            {
                return Fail("验证码不一致", 0, false);
            }

            return Success(true);
        }

        /// <summary>
        /// 微信openid查询用户
        /// </summary>
        /// <param name="openId"></param>
        /// <returns></returns>
        [HttpGet]
        public async Task<ResponseBase<UserInfoOutput>> GetUserByOpenId(string openId)
        {
            if (openId.IsNullOrWhitespace())
            {
                return Fail<UserInfoOutput>("微信openId不能为空", (int)RedPaperApiCode.Error_Param);
            }

            var entity = await _userService.GetUserByOpenIdAsync(openId);
            if (entity == null)
            {
                return Fail<UserInfoOutput>("微信openId用户未注册", (int)RedPaperApiCode.Success);
            }

            var user = new UserInfoOutput
            {
                AvatarUrl = entity.AvatarUrl,
                UserId = entity.UserId,
                Nickname = entity.NickName,
                IsVip = entity.IsVip,
                Genders = (GenderType)entity.Genders
            };
            return Success(user);

        }


        /// <summary>
        /// 手机密码登录
        /// </summary>
        /// <param name="phone">手机号</param>
        /// <param name="password">密码</param>
        /// <returns></returns>
        [HttpGet]
        [AllowAnonymous]
        public async Task<ResponseBase<UserInfoOutput>> LoginByPassword(string phone, string password)
        {
            if (phone.IsNullOrWhitespace())
            {
                return Fail<UserInfoOutput>("手机号不能为空", (int)RedPaperApiCode.Error_Param);
            }
            if (password.IsNullOrWhitespace())
            {
                return Fail<UserInfoOutput>("密码不能为空", (int)RedPaperApiCode.Error_Param);
            }
            if (!phone.IsTelephone())
            {
                return Fail<UserInfoOutput>("手机号格式错误", (int)RedPaperApiCode.Invalid_Format);
            }
            var entity = await _userService.GetUserByPhoneAsync(phone);
            if (entity == null)
            {
                return Fail<UserInfoOutput>("该手机号未注册", (int)RedPaperApiCode.Error_Param);
            }
            if (entity.Password != password)
            {
                return Fail<UserInfoOutput>("密码错误", (int)RedPaperApiCode.Error_Param);
            }

            var user = new UserInfoOutput
            {
                AvatarUrl = entity.AvatarUrl,
                UserId = entity.UserId,
                Nickname = entity.NickName,
                IsVip = entity.IsVip,
                Genders = (GenderType)entity.Genders
            };

            return Success(user);
        }

        /// <summary>
        /// 手机验证码登录
        /// </summary>
        /// <param name="phone">手机号</param>
        /// <param name="verificationCode">验证码</param>
        /// <returns></returns>
        [HttpGet]
        public async Task<ResponseBase<UserInfoOutput>> LoginByVerificationCode(string phone, string verificationCode)
        {
            if (phone.IsNullOrWhitespace())
            {
                return Fail<UserInfoOutput>("手机号不能为空", (int)RedPaperApiCode.Error_Param);
            }
            if (verificationCode.IsNullOrWhitespace())
            {
                return Fail<UserInfoOutput>("验证码不能为空", (int)RedPaperApiCode.Error_Param);
            }
            if (!phone.IsTelephone())
            {
                return Fail<UserInfoOutput>("手机号格式错误", (int)RedPaperApiCode.Error_Param);
            }
            var entity = await _userService.GetUserByPhoneAsync(phone);
            if (entity == null)
            {
                return Fail<UserInfoOutput>("该手机号未注册", (int)RedPaperApiCode.Error_Param);
            }
            var key = $"phone:{phone}:VerifyCode";
            var code = RedisHelper.Instance.Get<string>(key);
            if (code.IsNullOrWhitespace())
            {
                return Fail<UserInfoOutput>("验证码已过期", (int)RedPaperApiCode.Error_Param);
            }
            if (verificationCode != code)
            {
                return Fail<UserInfoOutput>("验证码错误", (int)RedPaperApiCode.Error_Param);
            }

            var user = new UserInfoOutput
            {
                AvatarUrl = entity.AvatarUrl,
                UserId = entity.UserId,
                Nickname = entity.NickName,
                IsVip = entity.IsVip,
                Genders = (GenderType)entity.Genders
            };

            return Success(user);
        }

        /// <summary>
        /// 修改密码
        /// </summary>
        /// <param name="userId">用户Id</param>
        /// <param name="oldPassword">旧密码</param>
        /// <param name="newPassword">新密码</param>
        /// <returns></returns>
        [HttpGet]
        public async Task<ResponseBase<bool>> UpdatePassword(string userId, string oldPassword, string newPassword)
        {
            if (userId.IsNullOrWhitespace())
            {
                return Fail<bool>("用户id不能为空", (int)RedPaperApiCode.Error_Param);
            }
            if (oldPassword.IsNullOrWhitespace())
            {
                return Fail<bool>("旧密码不能为空", (int)RedPaperApiCode.Error_Param);
            }
            if (newPassword.IsNullOrWhitespace())
            {
                return Fail<bool>("新密码不能为空", (int)RedPaperApiCode.Error_Param);
            }

            try
            {
                var result = await _loginSerivce.UpdatePasswordAsync(userId, oldPassword, newPassword);
                return Success(result);
            }
            catch (Exception ex)
            {
                return Fail(ex.Message, (int)RedPaperApiCode.Server_Error, false);
            }
        }


        /// <summary>
        /// 更换手机号
        /// </summary>
        /// <param name="userId">用户id</param>
        /// <param name="phone">手机号</param>
        /// <returns></returns>
        [HttpGet]
        public async Task<ResponseBase<bool>> UpdatePhone(string userId, string phone)
        {
            if (userId.IsNullOrWhitespace())
            {
                return Fail<bool>("用户id不能为空", (int)RedPaperApiCode.Error_Param);
            }

            if (phone.IsNullOrWhitespace())
            {
                return Fail<bool>("新手机号不能为空", (int)RedPaperApiCode.Error_Param);
            }

            if (!phone.IsTelephone())
            {
                return Fail<bool>("手机号格式错误", (int)RedPaperApiCode.Invalid_Format);
            }

            try
            {
                var result = await _loginSerivce.UpdatePhoneAsync(userId, phone);
                return Success(result);
            }
            catch (Exception ex)
            {
                return Fail(ex.Message, (int)RedPaperApiCode.Server_Error, false);
            }

        }
    }
}