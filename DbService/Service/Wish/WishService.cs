using AutoMapper;
using DbService.IService;
using DbService.IService.SystemSetting;
using DbService.Models;
using DbService.Repositories;
using Infrastructure.CommonModels;
using Infrastructure.CommonModels.Wish;
using Infrastructure.Enums;
using Infrastructure.Extensions;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DbService.Service.Wish
{
    public class WishService : IWishService
    {
        private readonly IMapper _mapper;
        private readonly IRpRepository<RpWishList> _wishRepo;
        private readonly IRpRepository<RpWishProcess> _wishProcessRepo;
        private readonly IRpRepository<RpUserInfo> _userRepo;
        private readonly IRpRepository<RpGoodsSell> _goodsSellRepo;
        private readonly IBagService _bagService;
        public WishService(IMapper mapper,
            IBagService bagService,
            IRpRepository<RpGoodsSell> goodsSellRepo,
            IRpRepository<RpWishList> wishRepo,
             IRpRepository<RpWishProcess> wishProcessRepo,
            IRpRepository<RpUserInfo> userRepo)
        {
            _wishRepo = wishRepo;
            _wishProcessRepo = wishProcessRepo;
            _userRepo = userRepo;
            _mapper = mapper;
            _bagService = bagService;
            _goodsSellRepo = goodsSellRepo;

        }

        /// <summary>
        /// 打赏礼物
        /// </summary>
        /// <param name="wishId"></param>
        /// <param name="donorId"></param>
        /// <param name="giftCode"></param>
        /// <returns></returns>
        public async Task<bool> AwardGiftAsync(string wishId, string donorId, string giftCode)
        {
            var wishList = await _wishRepo.FirstOrDefaultAsync(x => x.WishId == wishId);
            if (wishList == null) throw new Exception($"动态id：{wishId} 不存在");

            var donor = await _userRepo.FirstOrDefaultAsync(x => x.UserId == donorId);
            if (donor == null) throw new Exception($"打赏者：{donorId} 不存在");

            var gift = await _goodsSellRepo.FirstOrDefaultAsync(x => x.GoodsCode == giftCode);
            if (gift == null) throw new Exception($"礼物：{giftCode} 不存在");

            var time = DateTime.Now;

            _wishRepo.BeginTransaction();

            //添加进度
            var process = new RpWishProcess()
            {
                WishId = wishId,
                ProcessUser = donorId,
                GiftCode = giftCode,
                GiftName = gift.GoodsName,
                GiftValue = gift.CoinCount,
                UserId = wishList.UserId,
                CreateTime = time
            };
            await _wishProcessRepo.AddAsync(process, false);

            //礼物取出
            await _bagService.TakeOutUnCommitAsync(gift, wishList.UserId, donorId, wishId, TopicType.Wish, time);

            _wishRepo.Commit();

            //判断愿望实现进度
            var totalValue = await _wishProcessRepo.Where(x => x.WishId == wishId).SumAsync(x => x.GiftValue);
            if (totalValue >= wishList.GiftValue)
            {
                _wishRepo.BeginTransaction();

                //状态更改
                wishList.WishStatus = (short)WishStatus.Accomplish;
                await _wishRepo.UpdateAsync(wishList, false);

                //礼物进入愿望用户的背包
                var wishProcess = wishList.RpWishProcesses.ToList();
                var giftCodes = wishProcess.Select(x => x.GiftCode).ToList();
                var gifts = await _goodsSellRepo.Where(x => x.GoodsType == (short)GoodsType.Gift && giftCodes.Contains(x.GoodsCode)).ToListAsync();

                wishProcess.ForEach(async x =>
                {
                    var gift = gifts.First(g => g.GoodsCode.Equals(x.GiftCode));
                    await _bagService.PutInUnCommitAsync(gift, wishList.UserId, x.ProcessUser, wishId, TopicType.Wish, time);
                });

                _wishRepo.Commit();
            }

            return true;
        }

        public async Task<bool> ChangeStatus(string wishId, WishStatus status)
        {
            var wishList = await _wishRepo.FirstOrDefaultAsync(x => x.WishId == wishId);
            if (wishList == null) throw new Exception($"动态id：{wishId} 不存在");

            wishList.WishStatus = (short)status;
            await _wishRepo.UpdateAsync(wishList);

            return true;


        }

        /// <summary>
        /// 根据愿望id批量获取愿望
        /// </summary>
        /// <param name="ids"></param>
        /// <returns></returns>
        public async Task<List<RpWishList>> GetWishByIdsAsync(List<string> ids)
        {
            return await _wishRepo.Where(x => ids.Contains(x.WishId)).ToListAsync();
        }


        /// <summary>
        /// 愿望分页
        /// </summary>
        /// <param name="pageQuery"></param>
        /// <returns></returns>
        public async Task<PageResult<RpWishList>> PageListAsync(PageQuery<WishQuery> pageQuery)
        {
            var where = PredicateBuilder.True<RpWishList>();
            if (!string.IsNullOrEmpty(pageQuery.Where.CreateUserId))
            {
                where = where.And(x => x.UserId == pageQuery.Where.CreateUserId);
                where= where.And(x => x.WishStatus == (short)WishStatus.Going|| x.WishStatus == (short)WishStatus.Published);
            }

            var data = await _wishRepo.Where(where, x => x.CreateTime, pageQuery.PageIndex, pageQuery.PageSize, out int count, true).ToListAsync();

            return new PageResult<RpWishList>
            {
                Total = count,
                PageIndex = pageQuery.PageIndex,
                PageSize = pageQuery.PageSize,
                Data = data,
            };
        }

        /// <summary>
        /// 发布愿望
        /// </summary>
        /// <param name="wish"></param>
        /// <returns></returns>
        public async Task<RpWishList> PublishAsync(WishAddModel wish)
        {
            var now = DateTime.Now;
            var entity = _mapper.Map<RpWishList>(wish);
            entity.WishStatus = (short)WishStatus.Published;
            entity.WishId = Guid.NewGuid().ToString();
            entity.CreateTime = now;
            entity.PubTime = now;
            return await _wishRepo.AddAsync(entity);
        }
    }
}
