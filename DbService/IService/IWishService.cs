using DbService.Models;
using Infrastructure.CommonModels;
using Infrastructure.CommonModels.Wish;
using Infrastructure.Enums;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DbService.IService
{
    /// <summary>
    /// 愿望服务接口
    /// </summary>
    public interface IWishService : IRpService
    {

        /// <summary>
        /// 打赏礼物
        /// </summary>
        /// <param name="wishId">愿望id</param>
        /// <param name="donorId">打赏用户id</param>
        /// <param name="giftCode">礼物编码</param>
        /// <returns></returns>
        Task<bool> AwardGiftAsync(string wishId, string donorId, string giftCode);

        /// <summary>
        /// 发布愿望
        /// </summary>
        /// <param name="wish"></param>
        /// <returns></returns>
        Task<RpWishList> PublishAsync(WishAddModel wish);


        /// <summary>
        /// 更新状态
        /// </summary>
        /// <param name="wishId"></param>
        /// <param name="status"></param>
        /// <returns></returns>
        Task<bool> ChangeStatus(string wishId, WishStatus status);


        /// <summary>
        /// 根据愿望ids 获取愿望信息
        /// </summary>
        /// <param name="ids"></param>
        /// <returns></returns>
        Task<List<RpWishList>> GetWishByIdsAsync(List<string> ids);


        /// <summary>
        /// 愿望分页
        /// </summary>
        Task<PageResult<RpWishList>> PageListAsync(PageQuery<WishQuery> pageQuery);

    }
}
