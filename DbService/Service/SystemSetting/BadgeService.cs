using DbService.IService;
using DbService.Models;
using DbService.Repositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DbService.Service
{
    public class BadgeService : IBadgeService
    {
        private readonly IRpRepository<RpBadge> _badgeRepo;
        public BadgeService(IRpRepository<RpBadge> badgeRepo)
        {
            _badgeRepo = badgeRepo;
        }



        /// <summary>
        /// 获取所有勋章
        /// </summary>
        /// <returns></returns>
        public async Task<List<RpBadge>> GetAllAsync()
        {
            return await _badgeRepo.GetAll().ToListAsync();
        }


        /// <summary>
        /// 添加勋章
        /// </summary>
        /// <param name="badge"></param>
        /// <returns></returns>
        public async Task<RpBadge> AddAsync(RpBadge badge)
        {
            var entity = await _badgeRepo.FirstOrDefaultAsync(x => x.BadgeCode == badge.BadgeCode);
            if (entity != null) throw new Exception($"勋章code：{badge.BadgeCode} 已经存在");
            return await _badgeRepo.AddAsync(badge);
        }

        /// <summary>
        /// 编辑
        /// </summary>
        /// <param name="badge"></param>
        /// <returns></returns>
        public async Task<bool> EditAsync(RpBadge badge)
        {
            var entity = await _badgeRepo.FirstOrDefaultAsync(x => x.BadgeId == badge.BadgeId);
            if (entity == null) throw new Exception($"勋章BadgeId:{badge.BadgeId} 不存在");
            entity.BadgeCode = badge.BadgeCode;
            entity.BadgeName = badge.BadgeName;
            entity.BadgePic = badge.BadgePic;
            entity.LastUpdate = DateTime.Now;
            await _badgeRepo.UpdateAsync(entity);
            return true;
        }

        /// <summary>
        /// 删除勋章
        /// </summary>
        /// <param name="badgeId"></param>
        /// <returns></returns>
        public async Task<bool> DeleteAsync(string badgeId)
        {
            var entity = _badgeRepo.FirstOrDefault(x => x.BadgeId == badgeId);
            if (entity != null)
            {
                await _badgeRepo.DeleteAsync();
            }
            else
            {
                throw new Exception($"勋章BadgeId:{badgeId} 不存在");
            }
            return true;
        }
    }

}
