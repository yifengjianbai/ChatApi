using AutoMapper;
using DbService.IService;
using DbService.IService.SystemSetting;
using DbService.Models;
using DbService.Repositories;
using Infrastructure;
using Infrastructure.CommonModels;
using Infrastructure.CommonModels.Moment;
using Infrastructure.Enums;
using Infrastructure.Extensions;
using Infrastructure.Helpers;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DbService.Service
{
    public class MomentService : IMomentService
    {
        private readonly IRpRepository<RpMomentInfo> _momentRepo;
        private readonly IRpRepository<RpMomentLiked> _momentLikedRepo;
        private readonly IRpRepository<RpMomentGift> _momentGiftRepo;
        private readonly IRpRepository<RpPubMedium> _pubMediumRepo;
        private readonly IRpRepository<RpUserInfo> _userRepo;
        private readonly IRpRepository<RpUserFollowed> _userFollowdRepo;
        private readonly IRpRepository<RpGoodsSell> _goodsSellRepo;
        private readonly IRpRepository<RpUserBag> _userBagRepo;
        private readonly IBagService _bagService;
        private readonly IMapper _mapper;
        public MomentService(IRpRepository<RpMomentInfo> momentRepo,
            IRpRepository<RpMomentLiked> momentLikedRepo,
            IRpRepository<RpMomentGift> momentGiftRepo,
            IRpRepository<RpPubMedium> pubMediumRepo,
            IRpRepository<RpUserInfo> userRepo,
            IRpRepository<RpUserFollowed> userFollowdRepo,
            IRpRepository<RpGoodsSell> goodsSellRepo,
            IRpRepository<RpUserBag> userBagRepo,
            IRpRepository<RpUserBagInOut> userBagInoutRepo,
            IBagService bagService,
            IMapper mapper)
        {
            _momentRepo = momentRepo;
            _momentLikedRepo = momentLikedRepo;
            _momentGiftRepo = momentGiftRepo;
            _pubMediumRepo = pubMediumRepo;
            _mapper = mapper;
            _userRepo = userRepo;
            _userFollowdRepo = userFollowdRepo;
            _goodsSellRepo = goodsSellRepo;
            _userBagRepo = userBagRepo;
            _bagService = bagService;


        }

        /// <summary>
        /// 根据动态id获取动态信息
        /// </summary>
        /// <param name="momentId"></param>
        /// <returns></returns>
        public async Task<RpMomentInfo> GetMomentByIdAsync(string momentId)
        {
            return await _momentRepo.FirstOrDefaultAsync(x => x.MomentId == momentId);
        }

        /// <summary>
        /// 获取本周发布条数
        /// </summary>
        /// <param name="userId"></param>
        /// <returns></returns>
        public async Task<int> GetWeekMomentCountAsync(string userId)
        {
            var startTime = UtilHelper.WeekStartTime;
            return await _momentRepo.CountAsync(x => x.UserId.Equals(userId) && x.CreateTime >= startTime);
        }

        /// <summary>
        /// 打赏礼物
        /// </summary>
        /// <param name="momentId">动态id</param>
        /// <param name="giftCode">礼物编号</param>
        /// <param name="donorId">赠送者</param>
        /// <returns></returns>
        public async Task<bool> GiveGiftAsync(string momentId, string giftCode, string donorId)
        {
            var moment = await GetMomentByIdAsync(momentId);
            if (moment == null) throw new Exception($"动态id：{momentId} 不存在");

            var donor = await _userRepo.FirstOrDefaultAsync(x => x.UserId == donorId);
            if (donor == null) throw new Exception($"打赏者：{donorId} 不存在");

            var gift = await _goodsSellRepo.FirstOrDefaultAsync(x => x.GoodsCode == giftCode);
            if (gift == null) throw new Exception($"礼物：{giftCode} 不存在");

            var time = DateTime.Now;
            _momentRepo.BeginTransaction();
            //1.加入动态礼物记录
            var momentGiftEntity = new RpMomentGift()
            {
                GiftCode = gift.GoodsCode,
                GiftName = gift.GoodsName,
                GiftPic = gift.GoodsPic,
                GiftPrice = gift.CoinCount,
                DonorId = donor.UserId,
                DonorAvatar = donor.AvatarUrl,
                DonorName = donor.NickName,
                UserId = moment.UserId,
                MomentId = moment.MomentId,
                CreateTime = time
            };
            await _momentGiftRepo.AddAsync(momentGiftEntity, false);

            // 受赠者背包变更
            await _bagService.PutInUnCommitAsync(gift, moment.UserId, donorId, momentId, TopicType.Wish, time);

            //打赏者背包变更
            await _bagService.TakeOutUnCommitAsync(gift, moment.UserId, donorId, momentId, TopicType.Wish, time);

            _momentRepo.Commit();

            return true;
        }

        /// <summary>
        /// 动态点赞
        /// </summary>
        /// <param name="momentId"></param>
        /// <param name="userId"></param>
        /// <returns></returns>
        public async Task<bool> LikeAsync(string momentId, string userId, bool isLike)
        {

            var userInfo = await _userRepo.FirstOrDefaultAsync(x => x.UserId.Equals(userId));
            var entity = await _momentRepo.FirstOrDefaultAsync(x => x.MomentId.Equals(momentId));
            if (entity == null)
            {
                throw new Exception($"动态：{momentId}不存在");
            }

            if (isLike)
            {
                entity.LikeCount++;
                var like = new RpMomentLiked();
                like.LikedUserId = userId;
                like.LikeUserName = userInfo.NickName;
                like.LikedAvatar = userInfo.AvatarUrl;
                like.CreateTime = DateTime.Now;
                like.MomentId = entity.MomentId;
                entity.RpMomentLikeds.Add(like);
                await _momentRepo.UpdateAsync(entity);
            }
            else
            {
                entity.LikeCount--;
                var likeLog = entity.RpMomentLikeds.ToList().FirstOrDefault(x => x.LikedUserId == userId);
                entity.RpMomentLikeds.Remove(likeLog);
                await _momentRepo.UpdateAsync(entity);
            }

            return true;
        }


        /// <summary>
        /// 动态分页
        /// </summary>
        /// <param name="query"></param>
        /// <returns></returns>
        public async Task<PageResult<RpMomentInfo>> PageMomentAsync(PageQuery<MomentQuery> query)
        {
            var where = PredicateBuilder.True<RpMomentInfo>();
            var userEntity = await _userRepo.FirstOrDefaultAsync(x => x.UserId.Equals(query.Where.CurrentUserId));
            if (userEntity == null) throw new Exception($"用户:{query.Where.CurrentUserId} 不存在");
            var tags = userEntity.UserTags;
            switch (query.Where.ListType)
            {
                case MomentListType.Followed:
                    var followedUsers = _userFollowdRepo.Where(x => x.UserId == query.Where.CurrentUserId).Select(x => x.FollowedId);
                    where = where.And(x => x.Scope < (short)MomentScope.Self);
                    where = where.And(x => followedUsers.Contains(x.UserId));
                    break;

                case MomentListType.Recommend:
                    //todo:推荐算法 需要优化
                    where = where.And(x => x.Scope < (short)MomentScope.Self);
                    break;
            }

            var models = await _momentRepo.Where(where, x => x.CreateTime, query.PageIndex, query.PageSize, out int count, true).ToListAsync();
            var result = new PageResult<RpMomentInfo>()
            {
                PageIndex = query.PageIndex,
                PageSize = query.PageSize,
                Total = count,
                Data = models
            };

            return result;

        }

        /// <summary>
        /// 发布动态
        /// </summary>
        /// <param name="moment"></param>
        /// <returns></returns>
        public async Task<RpMomentInfo> PublishAsync(MomentAddModel moment)
        {
            var momentEntity = _mapper.Map<RpMomentInfo>(moment);
            momentEntity.MomentId = Guid.NewGuid().ToString();
            if (momentEntity.HasAttath)
            {
                var pubMediaEntities = _mapper.Map<List<RpPubMedium>>(moment.Attachments);
                pubMediaEntities.ForEach(x => { x.TopicId = momentEntity.MomentId; });

                _momentRepo.BeginTransaction();
                momentEntity = await _momentRepo.AddAsync(momentEntity, false);
                await _pubMediumRepo.AddRangeAsync(pubMediaEntities, false);
                _momentRepo.Commit();
            }
            else
            {
                momentEntity = await _momentRepo.AddAsync(momentEntity);
            }

            return momentEntity;
        }

        /// <summary>
        /// 置顶
        /// </summary>
        /// <param name="momentId"></param>
        /// <param name="userId"></param>
        /// <returns></returns>
        public async Task<bool> TopAsync(string momentId, string userId)
        {
            var entity = await _momentRepo.FirstOrDefaultAsync(x => x.MomentId == momentId);
            if (entity == null) throw new Exception($"动态id：{momentId}不存在");
            entity.OnTop = true;
            await _momentRepo.UpdateAsync(entity);
            return true;
        }
    }
}
