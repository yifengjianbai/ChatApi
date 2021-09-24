using DbService.IService;
using DbService.Models;
using DbService.Repositories;
using Infrastructure.Enums;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DbService.Service
{
    public class WithdrawSettingService : IWithdrawSettingService
    {
        private readonly IRpRepository<RpWithdrawSetting> _withdrawSettingRepo;
        public WithdrawSettingService(IRpRepository<RpWithdrawSetting> withdrawSettingRepo)
        {
            _withdrawSettingRepo = withdrawSettingRepo;
        }

        public async Task<RpWithdrawSetting> AddAsync(RpWithdrawSetting setting)
        {
            var entity = await _withdrawSettingRepo.FirstOrDefaultAsync(x => x.Identity == setting.Identity && x.Level == setting.Level);
            if (entity != null) throw new Exception($"Identity:{setting.Identity }-levle：{setting.Level} 提现配置已存在");
            return await _withdrawSettingRepo.AddAsync(setting);
        }

        public async Task<bool> DeleteAsync(long settingId)
        {
            var entity = await _withdrawSettingRepo.FirstOrDefaultAsync(x => x.SettingId == settingId);
            if (entity == null) throw new Exception($" 提现配置settingId:{settingId}已存在");
            await _withdrawSettingRepo.DeleteAsync(entity);
            return true;

        }

        public async Task<List<RpWithdrawSetting>> GetAll()
        {
            return await _withdrawSettingRepo.GetAll().ToListAsync();
        }

        
        public async Task<RpWithdrawSetting> GetWithdrawSettingAsync(IdentityType identity, int level)
        {
            return await _withdrawSettingRepo.FirstOrDefaultAsync(x => x.Identity == (short)identity && x.Level == level);

        }
    }
}
