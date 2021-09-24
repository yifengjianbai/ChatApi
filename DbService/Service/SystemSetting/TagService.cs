using DbService.IService;
using DbService.Models;
using DbService.Repositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DbService.Service
{
    public class TagService : ITagService
    {
        private readonly IRpRepository<RpTag> _tagRepo;

        public TagService(IRpRepository<RpTag> tagRepo)
        {
            _tagRepo = tagRepo;
        }

        /// <summary>
        /// 添加标签
        /// </summary>
        /// <param name="badge"></param>
        /// <returns></returns>
        public async Task<RpTag> AddAsync(string tagText,string tagType)
        {
            var entity = await _tagRepo.FirstOrDefaultAsync(x => x.TagText == tagText);
            if (entity != null)
            {
                throw new Exception($"标签:{tagText} 已经存在");
            }
            var rpTag = new RpTag
            {
                TagText = tagText,
                TagType = tagType,
                LastUpdate = DateTime.Now
            };
            return await _tagRepo.AddAsync(rpTag);
        }

        /// <summary>
        /// 删除标签
        /// </summary>
        /// <param name="tagId"></param>
        /// <returns></returns>
        public async Task<bool> DeleteAsync(int tagId)
        {
            var entity = await _tagRepo.FirstOrDefaultAsync(x => x.TagId == tagId);
            if (entity == null)
            {
                throw new Exception($"tagId:{tagId} 不存在");
            }
            await _tagRepo.DeleteAsync(entity);
            return true;
        }

        /// <summary>
        /// 编辑标签
        /// </summary>
        /// <param name="badge"></param>
        /// <returns></returns>
        public async Task<bool> EditAsync(RpTag tag)
        {
            var entity = await _tagRepo.FirstOrDefaultAsync(x => x.TagId == tag.TagId);
            if (entity == null)
            {
                throw new Exception($"tagId:{tag.TagId} 不存在");
            }
            entity.TagText = tag.TagText;
            entity.TagType = tag.TagType;
            entity.LastUpdate = DateTime.Now;
            await _tagRepo.UpdateAsync(entity);

            return true;
        }

        /// <summary>
        /// 获取所有标签
        /// </summary>
        /// <returns></returns>
        public async Task<List<RpTag>> GetAllAsync()
        {
            return await _tagRepo.GetAll().ToListAsync();
        }


        /// <summary>
        /// 获取标签分类
        /// </summary>
        /// <returns></returns>
        public async Task<List<string>> GetTagTypeAsync()
        {
            return await _tagRepo.GetAll().Select(x => x.TagType).Distinct().ToListAsync();
        }
    }
}
