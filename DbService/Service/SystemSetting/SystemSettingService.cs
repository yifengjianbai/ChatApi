using DbService.IService;
using DbService.Models;
using DbService.Repositories;
using Infrastructure.CommonModels;
using Infrastructure.Enums;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DbService.Service
{
    public class OrdinaryUserAwardSettingService : IOrdinaryUserAwardSettingService
    {

        private readonly IRpRepository<RpOrdinaryUserAwardSetting> _ordinaryUserAwardSettingRepo;
        private readonly IRpRepository<RpOrdinaryUserAwardGood> _ordinaryUserAwardGoodRepo;
        public OrdinaryUserAwardSettingService(
            IRpRepository<RpOrdinaryUserAwardSetting> ordinaryUserAwardSettingRepo,
            IRpRepository<RpOrdinaryUserAwardGood> ordinaryUserAwardGoodRepo)
        {

            _ordinaryUserAwardSettingRepo = ordinaryUserAwardSettingRepo;
            _ordinaryUserAwardGoodRepo = ordinaryUserAwardGoodRepo;
        }

        /// <summary>
        /// 添加
        /// </summary>
        /// <param name="setting"></param>
        /// <returns></returns>
        public async Task<RpOrdinaryUserAwardSetting> AddAsync(NormalUserAward setting)
        {
            var entity = await _ordinaryUserAwardSettingRepo.FirstOrDefaultAsync(x => x.Level == setting.Level);
            if (entity != null) throw new Exception($"素人等级奖励：level：{ setting.Level} 已经存在");

            entity = new RpOrdinaryUserAwardSetting();
            entity.Level = setting.Level;
            entity.MomentFreeCountPerWeek = setting.MomentFreeCountPerWeek;
            entity.ChatFreeCountPerWeek = setting.ChatFreeCountPerWeek;
            entity.LastUpdate = DateTime.Now;
            setting.AwardGoods.ForEach(a =>
            {
                var awardGood = new RpOrdinaryUserAwardGood
                {
                    GoodsCode = a.GoodsCode,
                    Count = a.Count
                };
                entity.RpOrdinaryUserAwardGoods.Add(awardGood);

            });

            return await _ordinaryUserAwardSettingRepo.AddAsync(entity);

        }

        /// <summary>
        /// 删除
        /// </summary>
        /// <param name="settingId"></param>
        /// <returns></returns>
        public async Task<bool> DeleteAsync(long settingId)
        {
            var entity = await _ordinaryUserAwardSettingRepo.FirstOrDefaultAsync(x => x.SettingId == settingId);
            if (entity == null) throw new Exception($"素人等级奖励：SettingId：{settingId} 不存在");
            await _ordinaryUserAwardSettingRepo.DeleteAsync(entity);
            return true;
        }
    }
}
