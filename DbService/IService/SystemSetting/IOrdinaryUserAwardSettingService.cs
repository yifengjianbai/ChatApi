using DbService.Models;
using Infrastructure.CommonModels;
using System.Threading.Tasks;

namespace DbService.IService
{
    /// <summary>
    /// 素人等级奖励配置服务接口
    /// </summary>
    public interface IOrdinaryUserAwardSettingService : IRpService
    {
        /// <summary>
        /// 添加
        /// </summary>
        /// <param name="setting"></param>
        /// <returns></returns>
        Task<RpOrdinaryUserAwardSetting> AddAsync(NormalUserAward setting);

        /// <summary>
        /// 删除
        /// </summary>
        /// <param name="settingId"></param>
        /// <returns></returns>
        Task<bool> DeleteAsync(long settingId);

    }
}
