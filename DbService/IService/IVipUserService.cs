using DbService.Models;
using Infrastructure.CommonModels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DbService.IService
{
    /// <summary>
    /// 达人服务接口
    /// </summary>
    public interface IVipUserService: IRpService
    {
        /// <summary>
        /// 充值
        /// </summary>
        /// <param name="userId"></param>
        /// <param name="chargeSettingId"></param>
        /// <returns></returns>
        Task<bool> Charge(string userId, long chargeSettingId);

        /// <summary>
        /// 设置匹配条件
        /// </summary>
        /// <param name="matchCondition">匹配条件</param>
        /// <returns></returns>
        Task<bool> SetMatchCondition(MatchCondition matchCondition);

    }

}
