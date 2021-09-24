using DbService.IService;
using DbService.Models;
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
    /// 聊天
    /// </summary>
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class ChatController : RedPaperController
    {
        private readonly IChatService _chatService;

        public ChatController(IChatService chatService)
        {
            _chatService = chatService;
        }


        /// <summary>
        /// 发送已读信息记录
        /// </summary>
        /// <param name="senderId">发送者用户id</param>
        /// <returns></returns>
        [HttpGet]
        public async Task<ResponseBase<List<RpChatReadFlag>>> GetReadFlag(string senderId)
        {
            return await Task.Run(() => { return Success(new List<RpChatReadFlag>()); });
        }

        /// <summary>
        /// 离线信息记录
        /// </summary>
        /// <param name="userId"></param>
        /// <returns></returns>
        [HttpGet]
        public async Task<ResponseBase<List<RpChatOfflineMsg>>> GetOfflineMsg(string userId)
        {
            return await Task.Run(() => { return Success(new List<RpChatOfflineMsg>()); });
        }

        /// <summary>
        /// 保存发送已读信息
        /// </summary>
        /// <param name="readFlag"></param>
        /// <returns></returns>
        [HttpPost]
        public async Task<ResponseBase<bool>> AddReadFlag(RpChatReadFlag readFlag)
        {
            return await Task.Run(() => { return Success(true); });
        }


        /// <summary>
        /// 保存离线信息
        /// </summary>
        /// <param name="offlineMsg"></param>
        /// <returns></returns>
        [HttpPost]
        public async Task<ResponseBase<bool>> AddOfflineMsg(RpChatOfflineMsg offlineMsg)
        {
            return await Task.Run(() => { return Success(true); });
        }

        /// <summary>
        /// 批量删除发送已读信息
        /// </summary>
        /// <param name="flagIds">已读信息id</param>
        /// <returns></returns>
        [HttpDelete]
        public async Task<ResponseBase<bool>> DeleteReadFlag(List<long> flagIds)
        {
            return await Task.Run(() => { return Success(true); });
        }


        /// <summary>
        /// 批量删除离线信息
        /// </summary>
        /// <param name="msgIds">离线消息id</param>
        /// <returns></returns>
        [HttpDelete]
        public async Task<ResponseBase<bool>> DeleteOfflineMsg(List<long> msgIds)
        {
            return await Task.Run(() => { return Success(true); });
        }

        /// <summary>
        /// 解锁聊天用户
        /// </summary>
        /// <param name="sourceUserId">来源用户id</param>
        /// <param name="targetUserId">解锁目标用户</param>
        /// <returns></returns>
        [HttpGet]
        public async Task<ResponseBase<bool>> UnlockCharUser(string sourceUserId, string targetUserId)
        {
            return await Task.Run(() => { return Success(true); });
        }

        /// <summary>
        /// 赠送商品（道具或礼物）
        /// </summary>
        /// <param name="targetUserId"></param>
        /// <param name="productCode"></param>
        /// <param name="userId"></param>
        /// <returns></returns>
        [HttpGet]
        public async Task<ResponseBase<bool>> GiveGift(string targetUserId, string productCode, string userId)
        {
            return await Task.Run(() => { return Success(true); });
        }



    }
}
