using DbService.IService;
using DbService.Models;
using Infrastructure;
using Infrastructure.CommonModels;
using Infrastructure.CommonModels.Wish;
using Infrastructure.Enums;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;
using WebApi.Models.Response;

namespace WebApi.Controllers
{
    /// <summary>
    /// 愿望
    /// </summary>
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class WishController : RedPaperController
    {
        private readonly IWishService _wishService;
        private readonly IUserService _userSerivce;

        public WishController(IWishService wishService, IUserService userService)
        {
            _wishService = wishService;
            _userSerivce = userService;
        }


        /// <summary>
        /// 愿望池分页列表
        /// </summary>
        /// <param name="pageIndex">页码</param>
        /// <param name="pageSize">页大小</param>
        /// <returns></returns>
        [HttpGet]
        public async Task<ResponseBase<PageResult<RpWishList>>> WishPageList(int pageIndex, int pageSize)
        {
            var pageQuery = new PageQuery<WishQuery>()
            {
                PageIndex = pageIndex,
                PageSize = pageSize,
                Where = new WishQuery(),
            };
            var data = await _wishService.PageListAsync(pageQuery);
            return Success(data);
        }


        /// <summary>
        /// 我的愿望分页列表
        /// </summary>
        /// <param name="userId">用户id</param>
        /// <param name="pageIndex">页码</param>
        /// <param name="pageSize">页大小</param>
        /// <returns></returns>
        [HttpPost]
        public async Task<ResponseBase<PageResult<RpWishList>>> MyWishPageList(string userId, int pageIndex, int pageSize)
        {
            var pageQuery = new PageQuery<WishQuery>()
            {
                PageIndex = pageIndex,
                PageSize = pageSize,
                Where = new WishQuery()
                {
                    CreateUserId = userId
                }
            };

            var data = await _wishService.PageListAsync(pageQuery);
            return Success(data);
        }


        /// <summary>
        /// 愿望详情
        /// </summary>
        /// <param name="wishId">愿望id</param>
        /// <returns></returns>
        [HttpGet]
        public async Task<ResponseBase<RpWishList>> Detail(string wishId)
        {
            return await Task.Run(() => { return Success(new RpWishList()); });
        }

        /// <summary>
        /// 发布愿望
        /// </summary>
        /// <param name="wish"></param>
        /// <returns></returns>
        [HttpPost]
        public async Task<ResponseBase<string>> Publish(WishAddModel wish)
        {
            try
            {
                //发布愿望
                var entity = await _wishService.PublishAsync(wish);
                //获取经验值
                await _userSerivce.IncreaseUserExperience(entity.UserId, ActionType.PubWish);
                //返回结果
                return Success(entity.WishId);
            }
            catch (Exception ex)
            {
                return Fail<string>(ex.Message, (int)RedPaperApiCode.Remote_Service_Error);
            }
        }


        /// <summary>
        /// 中止
        /// </summary>
        /// <param name="wishId">愿望id</param>
        /// <param name="userId">用户id</param>
        /// <returns></returns>
        [HttpGet]
        public async Task<ResponseBase<bool>> Suspend(string wishId, string userId)
        {
            var result = await _wishService.ChangeStatus(wishId, WishStatus.revocation);
            return Success(result);
        }



        /// <summary>
        /// 撤回
        /// </summary>
        /// <param name="wishId">愿望id</param>
        /// <param name="userId">用户id</param>
        /// <returns></returns>
        [HttpGet]
        public async Task<ResponseBase<bool>> Backout(string wishId, string userId)
        {
            return await Task.Run(() => { return Success(true); });
        }


        /// <summary>
        /// 分享
        /// </summary>
        /// <param name="wishId">愿望id</param>
        /// <param name="shareType">分享类型</param>
        /// <param name="userId">用户id</param>
        /// <returns></returns>
        [HttpGet]
        public async Task<ResponseBase<bool>> Share(string wishId, ShareType shareType, string userId)
        {
            return await Task.Run(() => { return Success(true); });
        }

        /// <summary>
        /// 打赏礼物
        /// </summary>
        /// <param name="wishId">愿望id</param>
        /// <param name="donorId">打赏的用户id</param>
        /// <param name="giftCode">礼物编号</param>
        /// <returns></returns>
        [HttpPost]
        public async Task<ResponseBase<bool>> AwardGift(string wishId, string donorId, string giftCode)
        {
            var result = await _wishService.AwardGiftAsync(wishId, donorId, giftCode);
            return Success(result);
        }

    }
}
