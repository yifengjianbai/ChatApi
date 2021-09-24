using DbService.Models;
using Infrastructure.Enums;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DbService.IService
{
    /// <summary>
    /// 提现设置
    /// </summary>
    public interface IWithdrawSettingService : IRpService
    {
        /// <summary>
        /// 根据身份和等级获取提现设置
        /// </summary>
        /// <param name="identity"></param>
        /// <param name="level"></param>
        /// <returns></returns>
        Task<RpWithdrawSetting> GetWithdrawSettingAsync(IdentityType identity, int level);

        /// <summary>
        /// 获取所有设置
        /// </summary>
        /// <returns></returns>
        Task<List<RpWithdrawSetting>> GetAll();

        /// <summary>
        /// 添加
        /// </summary>
        /// <param name="setting"></param>
        /// <returns></returns>
        Task<RpWithdrawSetting> AddAsync(RpWithdrawSetting setting);

        /// <summary>
        /// 删除
        /// </summary>
        /// <param name="settingId"></param>
        /// <returns></returns>
        Task<bool> DeleteAsync(long settingId);

    }

}
