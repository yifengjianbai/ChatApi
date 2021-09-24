using Autofac;
using DbService.Models;
using DbService.Repositories;
using Infrastructure;
using Infrastructure.Enums;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace DbService.Service.Experience
{
    /// <summary>
    /// 登录经验操作
    /// </summary>
    public class LoginAction : BaseAction
    {
        private readonly IRpRepository<RpUserInfo> _userRepo;
        public LoginAction(IContainer container) : base(container)
        {
            _userRepo = container.Resolve<IRpRepository<RpUserInfo>>();

        }

        protected override async Task<bool> AllowIncreaseUserExpAsync(RpUserInfo userInfo, RpExpAcquireSetting expAcquire)
        {
            //去除本次登录
            var count = await _userRepo.CountAsync(x => x.UserId.Equals(userInfo.UserId) && x.LastUpdate.Date == DateTime.Now.Date)-1;
            if(userInfo.IsVip)
                return (expAcquire.VipLimitNum > count);
            else
                return (expAcquire.LimitNum > count);

        }
    }


}
