using DbService.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DbService.IService
{
    public interface IVipUserChargeSetttingService : IRpService
    {
        /// <summary>
        /// 获取所有达人充值项
        /// </summary>
        /// <returns></returns>
        Task<List<RpVipUserChargeSettting>> GetAllAsync();


        /// <summary>
        /// 添加
        /// </summary>
        /// <param name="setting"></param>
        /// <returns></returns>
        Task<RpVipUserChargeSettting> AddAsync(RpVipUserChargeSettting setting);

        /// <summary>
        /// 删除
        /// </summary>
        /// <param name="settingId"></param>
        /// <returns></returns>
        Task<bool> DeleteAsync(long settingId);
    }
}
