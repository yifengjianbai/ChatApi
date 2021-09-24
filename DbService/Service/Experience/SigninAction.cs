using Autofac;
using DbService.Models;
using DbService.Repositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DbService.Service.Experience
{
    public class SigninAction : BaseAction
    {
        private readonly IRpRepository<RpExpSignAcquireSetting> _expSignAcquireRepo;
        private readonly IRpRepository<RpSigninRecord> _signinRecordRepo;
        public SigninAction(IContainer container) : base(container)
        {
            _expSignAcquireRepo = container.Resolve<IRpRepository<RpExpSignAcquireSetting>>();
            _signinRecordRepo = container.Resolve<IRpRepository<RpSigninRecord>>();
        }
        /// <summary>
        /// 权限判断
        /// </summary>
        /// <param name="userInfo"></param>
        /// <param name="expAcquire"></param>
        /// <returns></returns>
        protected override async Task<bool> AllowIncreaseUserExpAsync(RpUserInfo userInfo, RpExpAcquireSetting expAcquire)
        {
            //当天首次签到才添加经验值
            var count = await _signinRecordRepo.CountAsync(x => x.UserId.Equals(userInfo.UserId) && x.SignTime.Date == DateTime.Now.Date) - 1;
            return count==0;
        }

        /// <summary>
        /// 获取增加的经验值
        /// </summary>
        /// <param name="userInfo"></param>
        /// <param name="expAcquire"></param>
        /// <returns></returns>
        protected override int GetExpValue(RpUserInfo userInfo, RpExpAcquireSetting expAcquire)
        {
            var record = _signinRecordRepo.Where(x => x.UserId == userInfo.UserId && x.SignTime.Date == DateTime.Now.Date).OrderByDescending(x => x.SignTime).FirstOrDefault();
            if (record == null) return 0;

            var SignAcquire = _expSignAcquireRepo.FirstOrDefault(x => x.DayNum == record.SignNum);
            if (SignAcquire == null) return 0;

            //达人经验翻倍
            if (userInfo.IsVip)
                return SignAcquire.ExpValue * SignAcquire.VipMultipe;
            else
                return SignAcquire.ExpValue;
        }

    }
}
