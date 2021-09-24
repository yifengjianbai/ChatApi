using Autofac;
using DbService.Models;
using DbService.Repositories;
using Infrastructure.Enums;
using System;
using System.Threading.Tasks;

namespace DbService.Service.Experience
{
    /// <summary>
    /// 打赏礼物
    /// </summary>
    public class AwardGiftAction : BaseAction
    {
        private readonly IRpRepository<RpUserBagInOut> _bagInOutRepo;
        public AwardGiftAction(IContainer container) : base(container)
        {
            _bagInOutRepo = container.Resolve<IRpRepository<RpUserBagInOut>>(); ;
        }

        /// <summary>
        /// 可否允许获取经验
        /// </summary>
        /// <param name="userInfo"></param>
        /// <param name="expAcquire"></param>
        /// <returns></returns>
        protected override async Task<bool> AllowIncreaseUserExpAsync(RpUserInfo userInfo, RpExpAcquireSetting expAcquire)
        {
            //当天去除本次的打赏
            var count = await _bagInOutRepo.CountAsync(x => x.UserId == userInfo.UserId && x.CreateTime.Date == DateTime.Now.Date && x.ActionType == (short)BagActionType.TakeOut && x.BehaviorType == (short)BehaviorType.Award) - 1;
            if (userInfo.IsVip)
                return (expAcquire.VipLimitNum > count);
            else
                return (expAcquire.LimitNum > count);
        }
    }
}
