using DbService.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DbService.IService
{
    public interface ITagService: IRpService
    {
        /// <summary>
        /// 获取所有标签
        /// </summary>
        /// <returns></returns>
        Task<List<RpTag>> GetAllAsync();

        /// <summary>
        /// 获取标签分类
        /// </summary>
        /// <returns></returns>
        Task<List<string>> GetTagTypeAsync();

        /// <summary>
        /// 添加
        /// </summary>
        /// <param name="badge"></param>
        /// <returns></returns>
        Task<RpTag> AddAsync(string tagText, string tagType);

        /// <summary>
        /// 编辑
        /// </summary>
        /// <param name="badge"></param>
        /// <returns></returns>
        Task<bool> EditAsync(RpTag tag);

        /// <summary>
        /// 删除
        /// </summary>
        /// <param name="badge"></param>
        /// <returns></returns>
        Task<bool> DeleteAsync(int tagId);

        
    }


}
