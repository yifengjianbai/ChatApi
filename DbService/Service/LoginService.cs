using AutoMapper;
using DbService.IService;
using DbService.Models;
using DbService.Repositories;
using Infrastructure;
using Infrastructure.CommonModels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DbService.Service
{
    public class LoginService : ILoginService
    {
        private readonly IRpRepository<RpUserInfo> _userRepo;

        private readonly IMapper _mapper;
        public LoginService(IRpRepository<RpUserInfo> userRepo, IMapper mapper)
        {
            _userRepo = userRepo;
            _mapper = mapper;
        }

      

        /// <summary>
        /// 退出登录
        /// </summary>
        /// <param name="userId"></param>
        /// <returns></returns>
        public async Task<bool> LogoutAsync(string userId)
        {
            var entity = await _userRepo.FirstOrDefaultAsync(x => x.UserId.Equals(userId));
            if (entity == null) throw new Exception($" 用户userId:{userId}不存在 ");
            entity.IsOnline = false;
            return true;
        }

        /// <summary>
        /// 用户注册
        /// </summary>
        /// <param name="registUserInfo"></param>
        /// <returns></returns>
        public async Task<RpUserInfo> RegistAsync(RegistUserInfo registUserInfo)
        {
            //1.验证手机号是否注册过
            var entity = await _userRepo.FirstOrDefaultAsync(x => x.Phone == registUserInfo.Phone);
            if (entity != null) throw new Exception($"手机号：{registUserInfo.Phone} 已被注册");
            var now = DateTime.Now;

            entity = _mapper.Map<RegistUserInfo, RpUserInfo>(registUserInfo);
            entity.UserId = Guid.NewGuid().ToString();
            entity.LastUpdate = now;
            entity.RegistTime = now;
            entity.IsOnline = false;

            //生成用户账户
            var userAccountEntity = new RpUserAccount();
            userAccountEntity.AccountId = Guid.NewGuid().ToString();
            userAccountEntity.UserId = entity.UserId;
            userAccountEntity.AmountExperience = 0;
            userAccountEntity.CurrCoins = 0;
            userAccountEntity.AmountCoins = 0;
            userAccountEntity.AmountExperience = 0;
            userAccountEntity.UserLevel = 1;
            userAccountEntity.NewExperience = 0;
            userAccountEntity.LastUpdate = now;
            userAccountEntity.CreateTime = now;
            entity.RpUserAccounts.Add(userAccountEntity);

            //送经验，送金币 todo


            //处理注册为VIP用户的
            if (entity.IsVip)
            {
                //达人信息表
                var rpVipUserEntity = new RpVipUserInfo
                {
                    UserId = entity.UserId,
                    VipDateBegin = now,
                    VipExpired = now.AddDays(registUserInfo.VipDuration),
                    CreateTime = now,
                    LastUpdate = now
                };
                entity.RpVipUserInfos.Add(rpVipUserEntity);

                //达人充值记录表
                var charge = new RpVipUserCharge
                {
                    VipUserId = entity.UserId,
                    ChargeFee = registUserInfo.Fee,
                    ChargeTime = now,
                    BeginDate = now,
                    EndDate = now.AddDays(registUserInfo.VipDuration),
                    UserId = entity.UserId
                };
                entity.RpVipUserCharges.Add(charge);
            }

            return await _userRepo.AddAsync(entity);
        }

        /// <summary>
        /// 账号密码登录
        /// </summary>
        /// <param name="phone"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        public async Task<RpUserInfo> LoginByPasswordAsync(string phone, string password)
        {
            return await _userRepo.FirstOrDefaultAsync(x => x.Phone.Equals(phone) && x.Password.Equals(password));
        }


        /// <summary>
        /// 设置密码
        /// </summary>
        /// <param name="userId"></param>
        /// <param name="oldPassword"></param>
        /// <param name="newPassword"></param>
        /// <returns></returns>
        public async Task<bool> SetPasswordAsync(string userId, string password)
        {
            var entity = await _userRepo.FirstOrDefaultAsync(x => x.UserId.Equals(userId));
            if (entity == null) throw new Exception($"用户id：{userId}不存在");

            entity.Password = password;
            entity.LastUpdate = DateTime.Now;

            await _userRepo.UpdateAsync(entity);
            return true;
        }


        /// <summary>
        /// 修改密码
        /// </summary>
        /// <param name="userId"></param>
        /// <param name="oldPassword"></param>
        /// <param name="newPassword"></param>
        /// <returns></returns>
        public async Task<bool> UpdatePasswordAsync(string userId, string oldPassword, string newPassword)
        {
            var entity = await _userRepo.FirstOrDefaultAsync(x => x.UserId.Equals(userId));
            if (entity == null) throw new Exception($"用户id：{userId}不存在");

            if (!oldPassword.Equals(entity.Password)) throw new Exception($"用户id：{userId}的旧密码不正确");
            entity.Password = newPassword;
            entity.LastUpdate = DateTime.Now;

            await _userRepo.UpdateAsync(entity);
            return true;
        }


        /// <summary>
        /// 更新手机号
        /// </summary>
        /// <param name="userId">用户id</param>
        /// <param name="phone">手机号</param>
        /// <returns></returns>
        public async Task<bool> UpdatePhoneAsync(string userId, string phone)
        {
            var entity = await _userRepo.FirstOrDefaultAsync(x => x.UserId.Equals(userId));
            if (entity == null)
                throw new Exception($"用户id：{userId}不存在");

            if(entity.Phone== phone)
                throw new Exception($"用户id：{phone}与原手机号一样");

            entity.Phone = phone;
            entity.LastUpdate = DateTime.Now;
            await _userRepo.UpdateAsync(entity);

            return true;
        }
    }

}
