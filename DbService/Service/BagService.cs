using DbService.IService.SystemSetting;
using DbService.Models;
using DbService.Repositories;
using Infrastructure;
using Infrastructure.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DbService.Service
{
    public class BagService : IBagService
    {
        private readonly IRpRepository<RpUserBag> _userBagRepo;
        public BagService(IRpRepository<RpUserBag> userBagRepo)
        {
            _userBagRepo = userBagRepo;
        }

        public async Task PutInUnCommitAsync(RpGoodsSell goods, string userId, string donorId, string topicId, TopicType topicType, DateTime time)
        {
            var userbag = await _userBagRepo.FirstOrDefaultAsync(x => x.UserId == userId);
            userbag.GiftCount += 1;
            //受赠者背包物品添加
            var stuff = new RpStuffsInBag()
            {
                StuffId = Guid.NewGuid().ToString(),
                BagId = userbag.BagId,
                UserId = userbag.UserId,
                StuffCode = goods.GoodsCode,
                StuffName = goods.GoodsName,
                StuffType = goods.GoodsType,
                CreateTime = time,
                FromUserId = donorId,
                FromType = (short)GoodsFromType.Give,
                Memo = $"用户:{donorId}打赏我的{topicType.GetDescription()}:{topicId}"
            };
            userbag.RpStuffsInBags.Add(stuff);


            //受赠者背包进出记录
            var bagInout = new RpUserBagInOut()
            {
                UserId = userbag.UserId,
                StuffCode = goods.GoodsCode,
                StuffName = goods.GoodsName,
                StuffType = goods.GoodsType,
                AboutUserId = donorId,
                Memo = $"存入{((GoodsType)goods.GoodsType).GetDescription()}-用户:{donorId}打赏我的{topicType.GetDescription()}:{topicId} ",
                ActionType = (short)BagActionType.PutIn,
                BehaviorType = (short)BehaviorType.Award,
                StuffValue = goods.CoinCount,
                CreateTime = time,
                BagId = userbag.BagId
            };
            userbag.RpUserBagInOuts.Add(bagInout);

            //受赠者更新背包
            await _userBagRepo.UpdateAsync(userbag, false);
        }

        public async Task TakeOutUnCommitAsync(RpGoodsSell goods, string userId, string donorId, string topicId, TopicType topicType, DateTime time)
        {
            var donorbag = await _userBagRepo.FirstOrDefaultAsync(x => x.UserId == donorId);
            donorbag.GiftCount -= 1;

            //打赏者背包物品减少
            var donorStuff = donorbag.RpStuffsInBags.ToList().First(x => x.StuffCode == goods.GoodsCode);
            donorbag.RpStuffsInBags.Remove(donorStuff);

            //打赏者背包进出记录
            var donorbagInout = new RpUserBagInOut()
            {
                UserId = donorbag.UserId,
                StuffName = goods.GoodsName,
                StuffType = goods.GoodsType,
                AboutUserId = userId,
                Memo = $"取出{((GoodsType)goods.GoodsType).GetDescription()}-打赏用户：{userId}的{topicType.GetDescription()}:{topicId}",
                ActionType = (short)BagActionType.PutIn,
                BehaviorType = (short)BehaviorType.Award,
                StuffValue = goods.CoinCount,
                CreateTime = time,
                BagId = donorbag.BagId
            };
            donorbag.RpUserBagInOuts.Add(donorbagInout);

            //打赏者背包更新
            await _userBagRepo.UpdateAsync(donorbag, false);

        }
      
    }
}

