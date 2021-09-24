using DbService.IService;
using DbService.Models;
using DbService.Repositories;
using System;
using System.Threading.Tasks;

namespace DbService.Service
{
    public class ExpAcquireSettingService : IExpAcquireSettingService
    {
        private readonly IRpRepository<RpExpAcquireSetting> _expAcquireSettingRepo;
        public ExpAcquireSettingService(IRpRepository<RpExpAcquireSetting> expAcquireSettingRepo)
        {
            _expAcquireSettingRepo = expAcquireSettingRepo;
        }

        /// <summary>
        /// 添加
        /// </summary>
        /// <param name="setting"></param>
        /// <returns></returns>
        public async Task<RpExpAcquireSetting> Add(RpExpAcquireSetting setting)
        {
            var entity = await _expAcquireSettingRepo.FirstOrDefaultAsync(x =>x.ActionType == setting.ActionType);
            if (entity != null)
            {
                throw new Exception($"行为：{setting.ActionType }经验获取配置已经存在");
            }
            return await _expAcquireSettingRepo.AddAsync(setting);
        }


        /// <summary>
        /// 删除
        /// </summary>
        /// <param name="settingId"></param>
        /// <returns></returns>
        public async Task<bool> Delete(long settingId)
        {
            var entity = await _expAcquireSettingRepo.FirstOrDefaultAsync(x => x.SettingId == settingId);
            if (entity == null)
            {
                throw new Exception($"等级经验获取配置settingId:{settingId}不存在");
            }
            await _expAcquireSettingRepo.DeleteAsync(entity);
            return true;
        }
    }
}
