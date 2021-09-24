using DbService.Models;
using System.Threading.Tasks;

namespace DbService.IService
{
    /// <summary>
    /// 经验获取设置服务接口
    /// </summary>
    public interface IExpAcquireSettingService : IRpService
    {
        /// <summary>
        /// 添加
        /// </summary>
        /// <param name="setting"></param>
        /// <returns></returns>
        Task<RpExpAcquireSetting> Add(RpExpAcquireSetting setting);

        /// <summary>
        /// 删除
        /// </summary>
        /// <param name="settingId"></param>
        /// <returns></returns>
        Task<bool> Delete(long settingId);
    }
}
