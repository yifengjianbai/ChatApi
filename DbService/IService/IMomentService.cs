using DbService.Models;
using Infrastructure.CommonModels;
using Infrastructure.CommonModels.Moment;
using System.Threading.Tasks;

namespace DbService.IService
{
    /// <summary>
    /// 动态服务接口
    /// </summary>
    public interface IMomentService : IRpService
    {
        /// <summary>
        /// 分页
        /// </summary>
        /// <returns></returns>
        Task<PageResult<RpMomentInfo>> PageMomentAsync(PageQuery<MomentQuery> query);

        /// <summary>
        /// 发布
        /// </summary>
        /// <param name="moment"></param>
        /// <returns></returns>
        Task<RpMomentInfo> PublishAsync(MomentAddModel moment);

        /// <summary>
        /// 点赞
        /// </summary>
        /// <param name="MomentId"></param>
        /// <returns></returns>
        Task<bool> LikeAsync(string momentId, string userId,bool isLike);

        /// <summary>
        /// 置顶
        /// </summary>
        /// <param name="momentId"></param>
        /// <param name="userId"></param>
        /// <returns></returns>
        Task<bool> TopAsync(string momentId, string userId);

        /// <summary>
        /// 打赏礼物
        /// </summary>
        /// <param name="momentId"></param>
        /// <param name="giftCode"></param>
        /// <param name="donorId"></param>
        /// <returns></returns>
        Task<bool> GiveGiftAsync(string momentId, string giftCode, string donorId);

        /// <summary>
        /// 根据id获取动态信息
        /// </summary>
        /// <param name="momentId"></param>
        /// <returns></returns>
        Task<RpMomentInfo> GetMomentByIdAsync(string momentId);


        /// <summary>
        /// 获取本周已发布的动态条数
        /// </summary>
        /// <param name="userId"></param>
        /// <returns></returns>
        Task<int> GetWeekMomentCountAsync(string userId);

    }

}
