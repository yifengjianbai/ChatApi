using DbService.IService;
using DbService.Models;
using Infrastructure.CommonModels;
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
    /// 评论
    /// </summary>
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class CommentController : RedPaperController
    {
        private readonly ICommentService _commentService;

        public CommentController(ICommentService commentService)
        {
            _commentService = commentService;
        }


        /// <summary>
        /// 评论分页列表
        /// </summary>
        /// <param name="momentId"></param>
        /// <returns></returns>
        [HttpPost]
        public async Task PageList(string momentId)
        {
            await Task.Run(() => { });
        }

        /// <summary>
        /// 评论添加
        /// </summary>
        /// <param name="content">内容</param>
        /// <param name="momentId">动态Id</param>
        /// <param name="commentId">评论Id</param>
        /// <param name="userId">用户Id</param>
        /// <returns></returns>
        [HttpPost]
        public async Task<ResponseBase<bool>> Add(string content, string momentId,  string userId, string commentId = "" )
        {
            return await Task.Run(() => { return Success(true); });
        }


        /// <summary>
        /// 评论点赞
        /// </summary>
        /// <param name="commentId">评论Id</param>
        /// <param name="isAdd">是否添加：true-添加赞 false-取消赞</param>
        /// <param name="userId">用户Id</param>
        /// <returns></returns>
        [HttpPost]
        public async Task Like(string commentId, bool isAdd, string userId)
        {
            await Task.Run(() => { });
        }

    }
}
