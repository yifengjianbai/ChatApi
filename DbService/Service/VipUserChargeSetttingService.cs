using DbService.IService;
using DbService.Models;
using DbService.Repositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DbService.Service
{
    public class VipUserChargeSetttingService : IVipUserChargeSetttingService
    {
        private readonly IRpRepository<RpVipUserChargeSettting> _vipUserChargeSetttingRepo;
        public VipUserChargeSetttingService(IRpRepository<RpVipUserChargeSettting> vipUserChargeSetttingRepo)
        {
            _vipUserChargeSetttingRepo = vipUserChargeSetttingRepo;
        }

        /// <summary>
        /// 添加
        /// </summary>
        /// <param name="setting"></param>
        /// <returns></returns>
        public async Task<RpVipUserChargeSettting> AddAsync(RpVipUserChargeSettting setting)
        {
            var entity = await _vipUserChargeSetttingRepo.FirstOrDefaultAsync(x => x.ChargeName == setting.ChargeName);
            if (entity != null) throw new Exception($"达人充值配置{setting.ChargeName}已存在");

            return await _vipUserChargeSetttingRepo.AddAsync(setting);
        }

        /// <summary>
        /// 删除
        /// </summary>
        /// <param name="settingId"></param>
        /// <returns></returns>
        public async Task<bool> DeleteAsync(long settingId)
        {
            var entity = await _vipUserChargeSetttingRepo.FirstOrDefaultAsync(x => x.SettingId == settingId);
            if (entity == null) throw new Exception($"达人充值配置{settingId}不存在");
            await _vipUserChargeSetttingRepo.DeleteAsync(entity);
            return true;
        }

        /// <summary>
        /// 获取所有
        /// </summary>
        /// <returns></returns>
        public async Task<List<RpVipUserChargeSettting>> GetAllAsync()
        {
            return await _vipUserChargeSetttingRepo.GetAll().ToListAsync();
        }
    }
}
