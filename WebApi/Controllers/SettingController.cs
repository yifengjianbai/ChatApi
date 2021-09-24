using DbService.IService;
using DbService.Models;
using Infrastructure.Enums;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApi.Models.Response;

namespace WebApi.Controllers
{
    /// <summary>
    /// 系统设置
    /// </summary>
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class SettingController : RedPaperController
    {

        public ITagService _tagService;
        public SettingController(ITagService tagService)
        {
            _tagService = tagService;
        }


        /// <summary>
        /// 获取标签
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public async Task<ResponseBase<List<RpTag>>> GetAllTag()
        {
            var tags = await _tagService.GetAllAsync();
            return Success(tags);
        }

        /// <summary>
        /// 添加标签
        /// </summary>
        /// <param name="tagText">标签本文</param>
        /// <param name="tagType">标签类型</param>
        /// <returns></returns>
        [HttpPost]
        public async Task<ResponseBase<long>> AddTag(string tagText, string tagType)
        {
          
            try
            {
                var entity = await _tagService.AddAsync(tagText, tagType);
                return Success(entity.TagId);
            }
            catch (Exception ex)
            {
                return Fail<long>(ex.Message, (int)RedPaperApiCode.Server_Error, -1);
            }
        }



    }
}
