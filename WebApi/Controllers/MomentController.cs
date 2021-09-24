using AutoMapper;
using DbService.IService;
using DbService.Models;
using Infrastructure;
using Infrastructure.CommonModels;
using Infrastructure.CommonModels.Moment;
using Infrastructure.CommonModels.User;
using Infrastructure.Enums;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApi.Models.Response;

namespace WebApi.Controllers
{
    /// <summary>
    /// 动态
    /// </summary>
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class MomentController : RedPaperController
    {
        private readonly IUserService _userSerivce;
        private readonly IMomentService _momentService;
        private readonly IWishService _wishService;
        private readonly IMapper _mapper;
        public MomentController(IMomentService momentService, IUserService userSerivce, IWishService wishService, IMapper mapper)
        {
            _wishService = wishService;
            _momentService = momentService;
            _userSerivce = userSerivce;
            _mapper = mapper;
        }
        /// <summary>
        /// 动态分页列表
        /// </summary>
        /// <param name="query"></param>
        /// <returns></returns>
        [HttpPost]
        public async Task<ResponseBase<PageResult<MomentOutput>>> PageList(PageQuery<MomentQuery> query)
        {
            var data = await _momentService.PageMomentAsync(query);
            List<RpWishList> wishList = new List<RpWishList>();
            List<RpUserInfo> atUserInfo = new List<RpUserInfo>();
            if (data.Total > 0)
            {
                var wishIds = data.Data.Where(x => !x.AtWishId.IsNullOrWhitespace()).Select(x => x.AtWishId).Distinct().ToList();
                if (wishIds.Count > 0)
                {
                    wishList = await _wishService.GetWishByIdsAsync(wishIds);
                }

                var atUserIds = data.Data.Where(x => !x.AtUserIds.IsNullOrWhitespace()).Select(x => x.AtUserIds).Distinct().ToList();
                var atUserIdList = new List<string>();

                atUserIds.ForEach(userId =>
                {
                    var list = userId.SplitCsv().ToList();
                    atUserIdList.AddRange(list);
                });

                atUserInfo = await _userSerivce.GetUserByIdsAsync(atUserIdList.Distinct().ToList());
            }

            var result = new PageResult<MomentOutput>();
            result.PageIndex = data.PageIndex;
            result.PageSize = data.PageSize;
            result.Total = data.Total;
            result.Data = data.Data.Select(x => new MomentOutput
            {
                MomentId = x.MomentId,
                UserId = x.UserId,
                Nickname = x.User.NickName,
                AvatarUrl = x.User.AvatarUrl,
                Genders = (GenderType)x.User.Genders,
                Content = x.Content,
                MomentType = (MomentType)x.MomentType,
                GiftCount = x.GiftCount,
                LikeCount = x.LikeCount,
                VisitCount = x.VisitCount,
                IsAnonymous = x.IsAnonymous,
                IsVipMoment = x.IsVipMoment,
                City = x.City,
                HasAttath = x.HasAttath,
                CreateTime = x.CreateTime,
                AtWishId = x.AtWishId,
                AtWishName = x.AtWishId.IsNullOrWhitespace() ? "" : wishList.First(w => w.WishId.Equals(x.AtWishId)).WishName,
                AtUserInfos = atUserInfo.Where(a => x.AtUserIds.Contains(a.UserId)).Select(a =>
                new UserInfoOutput() { UserId = a.UserId, Nickname = a.NickName, AvatarUrl = a.AvatarUrl, Genders = (GenderType)a.Genders }).ToList()
            }).ToList();
            return Success(result);
        }

        /// <summary>
        /// 动态详情
        /// </summary>
        /// <param name="momentId">动态id</param>
        /// <returns></returns>
        [HttpGet]
        public async Task<ResponseBase<MomentOutput>> Detail(string momentId)
        {
            var entity = await _momentService.GetMomentByIdAsync(momentId);
            var data = new MomentOutput();
            data.MomentId = momentId;
            data.MomentType = (MomentType)entity.MomentType;
            data.Content = entity.Content;
            data.IsAnonymous = entity.IsAnonymous;
            data.IsVipMoment = entity.IsVipMoment;
            data.LikeCount = entity.LikeCount;
            data.VisitCount = entity.VisitCount;
            data.GiftCount = entity.GiftCount;
            data.HasAttath = entity.HasAttath;
            data.City = entity.City;
            data.CreateTime = entity.CreateTime;
            //@愿望
            if (!entity.AtWishId.IsNullOrWhitespace())
            {
                var wishs = await _wishService.GetWishByIdsAsync(new List<string> { data.AtWishId });
                data.AtWishName = wishs.First().WishName;
                data.AtWishId = entity.AtWishId;
            }

            //@用户
            if (!entity.AtUserIds.IsNullOrWhitespace())
            {
                var userIdList = entity.AtUserIds.SplitCsv();
                var atUsers = await _userSerivce.GetUserByIdsAsync(userIdList);

                data.AtUserInfos = atUsers.Select(x => new UserInfoOutput
                {
                    UserId = x.UserId,
                    Nickname = x.NickName,
                    AvatarUrl = x.AvatarUrl,
                    Genders = (GenderType)x.Genders,
                    IsVip = x.IsVip
                }).ToList();
            }

            return Success(data);

        }

        /// <summary>
        /// 动态发布
        /// </summary>
        /// <param name="moment"></param>
        /// <returns></returns>
        [HttpPost]
        public async Task<ResponseBase<string>> Publish(MomentAddModel moment)
        {
            try
            {
                //发布
                var entity = await _momentService.PublishAsync(moment);

                //获取经验值
                await _userSerivce.IncreaseUserExperience(moment.UserId, ActionType.PubMement);

                return Success(entity.MomentId);
            }
            catch (Exception ex)
            {
                return Fail<string>(ex.Message, (int)RedPaperApiCode.Remote_Service_Error);
            }

        }


        /// <summary>
        /// 点赞
        /// </summary>
        /// <param name="momentId">动态id</param>
        /// <param name="userId">点赞用户</param>
        /// <param name="isLike">赞或取消赞</param>
        /// <returns></returns>
        [HttpPost]
        public async Task Like(string momentId, string userId, bool isLike)
        {
            await _momentService.LikeAsync(momentId, userId, isLike);
        }


        /// <summary>
        /// 打赏礼物
        /// </summary>
        /// <param name="momentId">动态id</param>
        /// <param name="donorId">打赏用户id</param>
        /// <param name="giftCode">礼物编码</param>
        /// <returns></returns>
        [HttpGet]
        public async Task<ResponseBase<bool>> Award(string momentId, string donorId, string giftCode)
        {
            var result= await _momentService.GiveGiftAsync(momentId, giftCode, donorId);
            return Success(result);
        }


        /// <summary>
        /// 分享动态
        /// </summary>
        /// <param name="momentId">动态id</param>
        /// <param name="userId">分享的用户id</param>
        /// <param name="shareType">分享类型</param>
        /// <returns></returns>
        [HttpGet]
        public async Task<ResponseBase<string>> Share(string momentId, string userId, ShareType shareType)
        {
            //todo:生成分享链接
            return await Task.Run(() => { return Success("www.baidu.com"); });
        }

    }
}
