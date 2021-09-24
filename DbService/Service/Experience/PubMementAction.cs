using Autofac;
using DbService.Models;
using DbService.Repositories;
using System;
using System.Threading.Tasks;

namespace DbService.Service.Experience
{
    /// <summary>
    /// 发布动态
    /// </summary>
    public class PubMementAction : BaseAction
    {
        private readonly IRpRepository<RpMomentInfo> _momentRepo;

        public PubMementAction(IContainer container) : base(container)
        {
            _momentRepo = container.Resolve<IRpRepository<RpMomentInfo>>();

        }

        protected override async Task<bool> AllowIncreaseUserExpAsync(RpUserInfo userInfo, RpExpAcquireSetting expAcquire)
        {
            //去除本次动态发布
            var count = await _momentRepo.CountAsync(x => x.UserId.Equals(userInfo.UserId) && x.CreateTime.Date == DateTime.Now.Date) - 1;
            if (userInfo.IsVip)
                return (expAcquire.VipLimitNum > count);
            else
                return (expAcquire.LimitNum > count);
        }
    }

}
