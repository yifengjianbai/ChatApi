using Autofac;
using DbService.IService;
using DbService.Models;
using DbService.Repositories;
using DbService.Service.Experience;
using Infrastructure.Enums;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DbService.Service
{
    /// <summary>
    /// 用户服务
    /// </summary>
    public class UserService : IUserService
    {
        private readonly IRpRepository<RpUserInfo> _userRepo;
        private readonly IRpRepository<RpOrdinaryUserAwardSetting> _normalUserAwardRepo;
        private readonly IRpRepository<RpLevelExpSetting> _levelexpSettingRepo;
        private readonly IRpRepository<RpExpAcquireSetting> _expAcquireSettingRepo;

        private readonly IContainer _container;

        public UserService(IRpRepository<RpUserInfo> userRepo,
             IRpRepository<RpOrdinaryUserAwardSetting> normalUserAwardRepo,
             IRpRepository<RpLevelExpSetting> levelexpSettingRepo,
             IRpRepository<RpExpAcquireSetting> expAcquireSettingRepo)
        {
            _container = ResolverServices.GetContainer();
            _userRepo = userRepo;
            _normalUserAwardRepo = normalUserAwardRepo;
            _levelexpSettingRepo = levelexpSettingRepo;
            _expAcquireSettingRepo = expAcquireSettingRepo;
        }

        /// <summary>
        /// 获取用户的奖励
        /// </summary>
        /// <param name="userId"></param>
        /// <returns></returns>
        public async Task<RpOrdinaryUserAwardSetting> GetNormalUserAwards(string userId)
        {
            var userInfo = await _userRepo.FirstOrDefaultAsync(x => x.UserId.Equals(userId));
            var account = userInfo.RpUserAccounts.ToList().First();
            return await _normalUserAwardRepo.FirstOrDefaultAsync(x => x.Level == account.UserLevel);
        }

        /// <summary>
        /// 根据微信openid获取用户信息
        /// </summary>
        /// <param name="openId"></param>
        /// <returns></returns>
        public async Task<RpUserInfo> GetUserByOpenIdAsync(string openId)
        {
            return await _userRepo.FirstOrDefaultAsync(x => x.WeChatOpenId == openId);
        }

        /// <summary>
        /// 根据用户编号获取用户信息
        /// </summary>
        /// <param name="UserNum"></param>
        /// <returns></returns>

        public async Task<RpUserInfo> GetUserByPhoneAsync(string phone)
        {
            return await _userRepo.FirstOrDefaultAsync(x => x.Phone == phone);
        }

        /// <summary>
        /// 根据Id获取用户信息
        /// </summary>
        /// <param name="userId"></param>
        /// <returns></returns>
        public async Task<RpUserInfo> GetUserByIdAsync(string userId)
        {
            return await _userRepo.FirstOrDefaultAsync(x => x.UserId.Equals(userId));
        }

        /// <summary>
        /// 根据用户Ids批量获取用户信息
        /// </summary>
        /// <param name="userIds"></param>
        /// <returns></returns>
        public async Task<List<RpUserInfo>> GetUserByIdsAsync(List<string> userIds)
        {
            return await _userRepo.Where(x => userIds.Contains(x.UserId)).ToListAsync();
        }

        /// <summary>
        /// 增长用户经验
        /// </summary>
        /// <param name="userId"></param>
        /// <param name="actionType"></param>
        /// <returns></returns>
        public async Task IncreaseUserExperience(string userId, ActionType actionType)
        {
            var userInfo = await GetUserByIdAsync(userId);
            if (userInfo == null) throw new Exception($"用户：{userId} 不存在");

            IExperienceAction experienceAction = null;
            switch (actionType)
            {
                case ActionType.PubMement:
                    experienceAction = new PubMementAction(_container);
                    break;
                case ActionType.PubWish:
                    experienceAction = new PubWishAction(_container);
                    break;
                case ActionType.Login:
                    experienceAction = new LoginAction(_container);
                    break;
                case ActionType.Share:
                    experienceAction = new ShareAction(_container);
                    break;
                case ActionType.AwardGift:
                    experienceAction = new AwardGiftAction(_container);
                    break;
                case ActionType.Signin:
                    experienceAction = new SigninAction(_container);
                    break;
                case ActionType.Remark:
                    experienceAction = new RemarkAction(_container);
                    break;
                default:
                    break;
            }
            if (experienceAction != null)
                await experienceAction.IncreaseUserExpAsync(userInfo, actionType);
        }

       
    }

}
