using DbService.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DbService.IService
{
    public interface ILevelExpSettingService : IRpService
    {
        /// <summary>
        /// 获取所有等级经验门槛值
        /// </summary>
        /// <returns></returns>
        Task<List<RpLevelExpSetting>> GetAll();

        /// <summary>
        /// 添加
        /// </summary>
        /// <param name="setting"></param>
        /// <returns></returns>
        Task<RpLevelExpSetting> Add(RpLevelExpSetting setting);

        /// <summary>
        /// 删除
        /// </summary>
        /// <param name="settingId"></param>
        /// <returns></returns>
        Task<bool> Delete(long settingId);
    }
}
