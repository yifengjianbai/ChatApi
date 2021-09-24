using Autofac;
using DbService.Models;
using DbService.Repositories;
using Infrastructure;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace DbService.Service.Experience
{
    /// <summary>
    /// 发布愿望
    /// </summary>
    public class PubWishAction : BaseAction
    {
        private readonly IRpRepository<RpWishList> _wishRepo;

        public PubWishAction(IContainer container) : base(container)
        {
            _wishRepo = container.Resolve<IRpRepository<RpWishList>>(); ;

        }

        protected override async Task<bool> AllowIncreaseUserExpAsync(RpUserInfo userInfo, RpExpAcquireSetting expAcquire)
        {
            //去除本次发布
            var count = await _wishRepo.CountAsync(x => x.UserId.Equals(userInfo.UserId) && x.CreateTime.Date == DateTime.Now.Date) - 1;
            if (userInfo.IsVip)
                return (expAcquire.VipLimitNum > count);
            else
                return (expAcquire.LimitNum > count);
        }
    }
}
