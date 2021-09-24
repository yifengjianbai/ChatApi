using DbService.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DbService.IService
{
    public interface IBadgeService: IRpService
    {
        /// <summary>
        /// 获取所有勋章
        /// </summary>
        /// <returns></returns>
        Task<List<RpBadge>> GetAllAsync();

        /// <summary>
        /// 添加
        /// </summary>
        /// <param name="badge"></param>
        /// <returns></returns>
        Task<RpBadge> AddAsync(RpBadge badge);


        /// <summary>
        /// 编辑
        /// </summary>
        /// <param name="badge"></param>
        /// <returns></returns>
        Task<bool> EditAsync(RpBadge badge);


        /// <summary>
        /// 删除
        /// </summary>
        /// <param name="badge"></param>
        /// <returns></returns>
        Task<bool> DeleteAsync(string badgeId);
    }
         

}
