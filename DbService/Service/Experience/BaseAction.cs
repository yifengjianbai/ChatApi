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
    public abstract class BaseAction : IExperienceAction
    {
        private readonly IRpRepository<RpUserAccount> _userAccount;
        private readonly IRpRepository<RpGrowthExperience> _userGrowth;
        private readonly IRpRepository<RpGrowthUpgrade> _userGrowthUpgradel;
        private readonly IRpRepository<RpLevelExpSetting> _LevelExpSetting;
        private readonly IRpRepository<RpExpAcquireSetting> _expAcquireSettingRepo;
        public BaseAction(IContainer container)
        {
            _userAccount = container.Resolve<IRpRepository<RpUserAccount>>();
            _userGrowth = container.Resolve<IRpRepository<RpGrowthExperience>>();
            _userGrowthUpgradel = container.Resolve<IRpRepository<RpGrowthUpgrade>>();
            _LevelExpSetting = container.Resolve<IRpRepository<RpLevelExpSetting>>();
            _expAcquireSettingRepo = container.Resolve<IRpRepository<RpExpAcquireSetting>>();
        }

        //添加经验值操作
        public async Task IncreaseUserExpAsync(RpUserInfo userInfo, ActionType expActionType)
        {
            var expAcquire = await _expAcquireSettingRepo.FirstOrDefaultAsync(x => x.ActionType == (short)expActionType);
            if (expAcquire == null) throw new Exception($"{expActionType.GetDescription()}行为经验配置项不存在");

            //判断是否增加经验值
            var isAllowed = await AllowIncreaseUserExpAsync(userInfo, expAcquire);
            if (!isAllowed) return;

            //获取增加经验值
            var expValue = GetExpValue(userInfo, expAcquire);
            if (expValue == 0) return;

            //添加经验值
            await IncreaseExpAsync(userInfo, expValue, expActionType);
        }

        /// <summary>
        /// 获取经验值
        /// </summary>
        /// <param name="userInfo"></param>
        /// <param name="expAcquire"></param>
        /// <returns></returns>
        protected virtual int GetExpValue(RpUserInfo userInfo, RpExpAcquireSetting expAcquire)
        {
            return userInfo.IsVip ? expAcquire.VipExpValue : expAcquire.ExpValue;
        }


        /// <summary>
        /// 添加经验值
        /// </summary>
        /// <param name="userInfo"></param>
        /// <param name="expValue"></param>
        /// <returns></returns>
        protected virtual async Task IncreaseExpAsync(RpUserInfo userInfo, int expValue, ActionType actionType)
        {
            _userAccount.BeginTransaction();
            var nowTime = DateTime.Now;
            var identity = userInfo.IsVip ? IdentityType.Vip : IdentityType.Normal;
            var userAccount = userInfo.RpUserAccounts.ToArray()[0];
            var nextLevelExp = await _LevelExpSetting.FirstOrDefaultAsync(x => x.Level == (userAccount.UserLevel + 1));

            //增加经验值
            userAccount.NewExperience += expValue;
            userAccount.AmountExperience += expValue;
            userAccount.ConvertExperience += expValue;
            userAccount.LastUpdate = nowTime;

            if (nextLevelExp != null)
            {
                //判断用户升级
                if (userAccount.AmountExperience > nextLevelExp.ThreadholdExp)
                {
                    var currentLevel = userAccount.UserLevel;
                    userAccount.UserLevel = currentLevel + 1;

                    //用户升级记录
                    var GrowthUpgradel = new RpGrowthUpgrade
                    {
                        UserId = userInfo.UserId,
                        UserName = userInfo.NickName,
                        FromLevel = currentLevel,
                        ToLevel = userAccount.UserLevel,
                        Memo = "用户升级",
                        CreateTime = nowTime
                    };
                    await _userGrowthUpgradel.AddAsync(GrowthUpgradel);
                }
            }

            await _userAccount.UpdateAsync(userAccount, false);

            //经验成长记录
            var growth = new RpGrowthExperience
            {
                ExpGrowth = expValue,
                GrowthAction = actionType.GetDescription(),
                GrowthType = (short)actionType,
                CreateTime = nowTime,
                UserId = userInfo.UserId,
                UserName = userInfo.NickName
            };
            await _userGrowth.AddAsync(growth, false);
            _userAccount.Commit();
        }


        /// <summary>
        /// 判断是否获取经验值
        /// </summary>
        /// <param name="userInfo"></param>
        /// <param name="expAcquire"></param>
        /// <returns></returns>
        protected abstract Task<bool> AllowIncreaseUserExpAsync(RpUserInfo userInfo, RpExpAcquireSetting expAcquire);


    }

}
