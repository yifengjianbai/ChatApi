using DbService.Models;
using Infrastructure.CommonModels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DbService.IService
{
    /// <summary>
    /// 用户登录相关服务接口
    /// </summary>
    public interface ILoginService : IRpService
    {
        /// <summary>
        /// 账号密码登录
        /// </summary>
        /// <param name="phone">手机号码</param>
        /// <param name="password">密码</param>
        /// <returns></returns>
        Task<RpUserInfo> LoginByPasswordAsync(string phone, string password);

        /// <summary>
        /// 退出登录
        /// </summary>
        /// <param name="userId"></param>
        /// <returns></returns>
        Task<bool> LogoutAsync(string userId);

        /// <summary>
        /// 注册用户
        /// </summary>
        /// <param name="userInfo"></param>
        /// <returns></returns>
        Task<RpUserInfo> RegistAsync(RegistUserInfo registUserInfo);


        /// <summary>
        /// 设置密码
        /// </summary>
        /// <param name="userId"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        Task<bool> SetPasswordAsync(string userId, string password);

        /// <summary>
        /// 修改用户密码
        /// </summary>
        /// <param name="userId"></param>
        /// <param name="oldPassword"></param>
        /// <param name="newPassword"></param>
        /// <returns></returns>
        Task<bool> UpdatePasswordAsync(string userId, string oldPassword, string newPassword);

        /// <summary>
        /// 更改手机号
        /// </summary>
        /// <param name="userId"></param>
        /// <param name="phone"></param>
        /// <returns></returns>
        Task<bool> UpdatePhoneAsync(string userId, string phone);

    }
}
