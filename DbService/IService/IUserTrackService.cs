using DbService.Models;
using System.Threading.Tasks;

namespace DbService.IService
{
    /// <summary>
    /// 用户追踪服务
    /// </summary>
    public interface IUserTrackService: IRpService
    {
        /// <summary>
        /// 保存用户定位
        /// </summary>
        /// <returns></returns>
        Task SaveUserTrackAsync(string userId, double longitude, double latitude);

    }

}
