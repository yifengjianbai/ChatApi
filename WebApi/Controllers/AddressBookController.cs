using Infrastructure.CommonModels.User;
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
    /// 通讯录
    /// </summary>
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class AddressBookController : RedPaperController
    {


        /// <summary>
        /// 我的关注用户列表
        /// </summary>
        /// <param name="userId">用户id</param>
        /// <param name="keyword">用户名称关键字</param>
        /// <returns></returns>
        [HttpGet]
        public async Task<ResponseBase<List<AddressBookUserInfoOutput>>> FollowedUserList(string userId, string keyword)
        {
            return await Task.Run(() => { return Success(new List<AddressBookUserInfoOutput>()); });
        }

        /// <summary>
        /// 我的密友用户列表
        /// </summary>
        /// <param name="userId">用户id</param>
        /// <param name="keyword">用户名称关键字</param>
        /// <returns></returns>
        [HttpGet]
        public async Task<ResponseBase<List<AddressBookUserInfoOutput>>> CloseFriendList(string userId, string keyword)
        {
            return await Task.Run(() => { return Success(new List<AddressBookUserInfoOutput>()); });
        }


        /// <summary>
        /// 我的备注用户列表
        /// </summary>
        /// <param name="userId">用户id</param>
        /// <param name="keyword">用户名称关键字</param>
        /// <returns></returns>
        [HttpGet]
        public async Task<ResponseBase<List<AddressBookUserInfoOutput>>> NoteUserList(string userId, string keyword)
        {
            return await Task.Run(() => { return Success(new List<AddressBookUserInfoOutput>()); });
        }


        /// <summary>
        /// 添加关注用户
        /// </summary>
        /// <param name="followedUserId">关注的用户id</param>
        /// <param name="userId">用户id</param>
        /// <returns></returns>
        [HttpPost]
        public async Task<ResponseBase<bool>> AddFollowedUser(string followedUserId, string userId)
        {
            return await Task.Run(() => { return Success(true); });
        }

        /// <summary>
        /// 取消关注用户
        /// </summary>
        /// <param name="followedUserId">关注的用户id</param>
        /// <param name="userId">用户id</param>
        /// <returns></returns>
        [HttpPost]
        public async Task<ResponseBase<bool>> CancelFollowedUser(string followedUserId, string userId)
        {
            return await Task.Run(() => { return Success(true); });
        }


        /// <summary>
        /// 备注用户
        /// </summary>
        /// <param name="followedId">关注的用户id</param>
        /// <param name="remarkNickName">备注昵称</param>
        /// <param name="remark">备注内容</param>
        /// <param name="userId">用户id</param>
        /// <returns></returns>
        [HttpPost]
        public async Task<ResponseBase<bool>> RemarkUser(string followedId, string remarkNickName, string remark, string userId)
        {
            return await Task.Run(() => { return Success(true); });
        }


        /// <summary>
        /// 黑名单列表
        /// </summary>
        /// <param name="userId"></param>
        /// <returns></returns>
        [HttpGet]
        public async Task<ResponseBase<bool>> BlackList(string userId)
        {
            return await Task.Run(() => { return Success(true); });
        }

        /// <summary>
        /// 加入黑名单
        /// </summary>
        /// <param name="blackUserId">拉黑的用户id</param>
        /// <param name="userId">用户id</param>
        /// <returns></returns>
        [HttpGet]
        public async Task<ResponseBase<bool>> AddBlackList(string blackUserId, string userId)
        {
            return await Task.Run(() => { return Success(true); });
        }

        /// <summary>
        /// 移除黑名单
        /// </summary>
        /// <param name="blackUserId">拉黑的用户id</param>
        /// <param name="userId">用户id</param>
        /// <returns></returns>
        [HttpGet]
        public async Task<ResponseBase<bool>> DeleteBlackList(string blackUserId, string userId)
        {
            return await Task.Run(() => { return Success(true); });
        }

    }
}
