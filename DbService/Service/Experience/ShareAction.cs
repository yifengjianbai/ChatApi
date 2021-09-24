using Autofac;
using DbService.Models;
using DbService.Repositories;
using System;
using System.Threading.Tasks;

namespace DbService.Service.Experience
{
    /// <summary>
    /// 分享
    /// </summary>
    public class ShareAction : BaseAction
    {
        private readonly IRpRepository<RpShareRecord> _shareRecordRepo;
        public ShareAction(IContainer container) : base(container)
        {
            _shareRecordRepo = container.Resolve<IRpRepository<RpShareRecord>>();
        }

        /// <summary>
        /// 是否允许分享获取经验
        /// </summary>
        /// <param name="userInfo"></param>
        /// <param name="expAcquire"></param>
        /// <returns></returns>
        protected override async Task<bool> AllowIncreaseUserExpAsync(RpUserInfo userInfo, RpExpAcquireSetting expAcquire)
        {
            var count = await _shareRecordRepo.CountAsync(x => x.UserId == userInfo.UserId && x.CreateTime.Date == DateTime.Now.Date)-1;
            var limitCount = userInfo.IsVip ? expAcquire.VipLimitNum : expAcquire.LimitNum;
            return limitCount > count;
        }
    }
}
