using DbService.IService;
using Infrastructure;
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
    /// 用户权限
    /// </summary>
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class PermissionController : RedPaperController
    {
        private readonly IUserService _userSerivce;
        public readonly IMomentService _momentService;
        public readonly IChatService _chatService;
        public PermissionController(IMomentService momentService,
            IChatService chatService,
            IUserService userSerivce)
        {
            _momentService = momentService;
            _userSerivce = userSerivce;
            _chatService = chatService;
        }

        /// <summary>
        /// 是否可免费发布动态
        /// </summary>
        /// <param name="userId"></param>
        /// <returns></returns>
        [HttpGet]
        public async Task<ResponseBase<bool>> AllowFreePublishMoment(string userId)
        {
            if (userId.IsNullOrWhitespace())
            {
                return Fail<bool>("用户id不能为空", (int)RedPaperApiCode.Error_Param);
            }
            var userInfo = await _userSerivce.GetUserByIdAsync(userId);

            if (userInfo == null)
            {
                return Fail<bool>("用户不存在", (int)RedPaperApiCode.Error_Param);
            }

            bool result;
            if (userInfo.IsVip)
            {
                result = true;
            }
            else
            {
                var weekCount = await _momentService.GetWeekMomentCountAsync(userId);
                var awards = await _userSerivce.GetNormalUserAwards(userId);
                result = weekCount < awards.MomentFreeCountPerWeek;
            }

            return Success(result);
        }

        /// <summary>
        /// 可否免费私聊
        /// </summary>
        /// <param name="userId"></param>
        /// <returns></returns>
        [HttpGet]
        public async Task<ResponseBase<bool>> AllowFreeChat(string userId)
        {
            if (userId.IsNullOrWhitespace())
            {
                return Fail<bool>("用户id不能为空", (int)RedPaperApiCode.Error_Param);
            }
            var userInfo = await _userSerivce.GetUserByIdAsync(userId);

            if (userInfo == null)
            {
                return Fail<bool>("用户不存在", (int)RedPaperApiCode.Error_Param);
            }
       
            bool result;
            if (userInfo.IsVip)
            {
                result = true;
            }
            else
            {
                var weekCount = await _chatService.GetWeekChatCount(userId);
                var awards = await _userSerivce.GetNormalUserAwards(userId);
                result = weekCount < awards.ChatFreeCountPerWeek;
            }

            return Success(true);
        }
    }
}
