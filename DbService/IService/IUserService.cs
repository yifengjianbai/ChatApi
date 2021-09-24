using DbService.Models;
using Infrastructure.Enums;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DbService.IService
{
    /// <summary>
    /// 用户服务接口
    /// </summary>
    public interface IUserService : IRpService
    {
  
        /// <summary>
        /// 根据用户Id获取用户信息
        /// </summary>
        /// <param name="userId"></param>
        /// <returns></returns>
        Task<RpUserInfo> GetUserByIdAsync(string userId);

        /// <summary>
        /// 根据用户Ids批量获取用户信息
        /// </summary>
        /// <param name="userIds"></param>
        /// <returns></returns>
        Task<List<RpUserInfo>> GetUserByIdsAsync(List<string> userIds);


        /// <summary>
        /// 根据微信openid获取用户信息
        /// </summary>
        /// <param name="openId"></param>
        /// <returns></returns>
        Task<RpUserInfo> GetUserByOpenIdAsync(string openId);

        /// <summary>
        /// 根据用户手机号获取用户信息
        /// </summary>
        /// <param name="phone"></param>
        /// <returns></returns>
        Task<RpUserInfo> GetUserByPhoneAsync(string phone);


        /// <summary>
        /// 获取素人的奖励
        /// </summary>
        /// <param name="userId"></param>
        /// <returns></returns>
        Task<RpOrdinaryUserAwardSetting> GetNormalUserAwards(string userId);


        /// <summary>
        /// 增长用户经验
        /// </summary>
        /// <param name="userId"></param>
        /// <param name="actionType"></param>
        /// <returns></returns>
        Task IncreaseUserExperience(string userId, ActionType actionType);
        


    }
}
