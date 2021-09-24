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
    /// <summary>
    /// 等级经验设置服务
    /// </summary>
    public class LevelExpSettingService : ILevelExpSettingService
    {
        private readonly IRpRepository<RpLevelExpSetting> _levelExpSettingRepo;
        public LevelExpSettingService(IRpRepository<RpLevelExpSetting> levelExpSettingRepo)
        {
            _levelExpSettingRepo = levelExpSettingRepo;
        }

        /// <summary>
        /// 添加
        /// </summary>
        /// <param name="setting"></param>
        /// <returns></returns>
        public async Task<RpLevelExpSetting> Add(RpLevelExpSetting setting)
        {
            var entity = await _levelExpSettingRepo.FirstOrDefaultAsync(x =>  x.Level == setting.Level);
            if (entity != null) throw new Exception($"等级经验设置Level：{setting.Level} 已经存在");
            return await _levelExpSettingRepo.AddAsync(setting);
        }

        /// <summary>
        /// 删除
        /// </summary>
        /// <param name="settingId"></param>
        /// <returns></returns>
        public async Task<bool> Delete(long settingId)
        {
            var entity = await _levelExpSettingRepo.FirstOrDefaultAsync(x => x.SettingId == settingId);
            if (entity == null)
            {
                throw new Exception($"等级经验设置settingId:{settingId} 不存在");
            }
            await _levelExpSettingRepo.DeleteAsync(entity);
            return true;
        }

        /// <summary>
        /// 获取所有
        /// </summary>
        /// <returns></returns>
        public async Task<List<RpLevelExpSetting>> GetAll()
        {
            return await _levelExpSettingRepo.GetAll().ToListAsync();
        }
    }
}
