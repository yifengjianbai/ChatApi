using DbService.IService;
using DbService.Models;
using Infrastructure;
using Infrastructure.CommonModels;
using Infrastructure.CommonModels.User;
using Infrastructure.Enums;
using Infrastructure.Helpers;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using WebApi.Models.Response;

namespace WebApi.Controllers
{
    /// <summary>
    /// 用户
    /// </summary>
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class UserController : RedPaperController
    {

        private readonly ILoginService _userSerivce;
        private readonly IConfiguration _configuration;
        public UserController(ILoginService userSerivce, IConfiguration configuration)
        {
            _userSerivce = userSerivce;
            _configuration = configuration;
        }

        /// <summary>
        /// 用户标签
        /// </summary>
        /// <param name="userId">用户id</param>
        /// <returns></returns>
        [HttpGet]
        public async Task<ResponseBase<List<RpTag>>> GetTags(string userId)
        {
            return await Task.Run(() => { return Success(new List<RpTag>()); });
        }

        /// <summary>
        /// 用户徽章
        /// </summary>
        /// <param name="userId"></param>
        /// <returns></returns>
        [HttpGet]
        public async Task<ResponseBase<List<RpBadge>>> GetBadgs(string userId)
        {
            return await Task.Run(() => { return Success(new List<RpBadge>()); });
        }


        /// <summary>
        /// 添加用户定位
        /// </summary>
        /// <param name="userId">用户id</param>
        /// <param name="longitude">经度</param>
        /// <param name="latitude">纬度</param>
        /// <returns></returns>
        [HttpGet]
        public async Task<ResponseBase<bool>> AddLocation(string userId, double longitude, double latitude)
        {
            return await Task.Run(() => { return Success(true); });
        }

        /// <summary>
        /// 用户背包
        /// </summary>
        /// <param name="userId"></param>
        /// <returns></returns>
        [HttpGet]
        public async Task<ResponseBase<RpUserBag>> GetBag(string userId)
        {
            return await Task.Run(() => { return Success(new RpUserBag()); });
        }

        /// <summary>
        /// 背包商品
        /// </summary>
        /// <param name="userId">用户id</param>
        /// <param name="goodsType">商品类型</param>
        /// <returns></returns>
        [HttpGet]
        public async Task<ResponseBase<List<RpGoodsSell>>> GetGoods(string userId, GoodsType goodsType)
        {
            return await Task.Run(() => { return Success(new List<RpGoodsSell>()); });
        }

        /// <summary>
        /// 统计
        /// </summary>
        /// <param name="userId">用户id</param>
        /// <returns></returns>
        [HttpGet]
        public async Task<ResponseBase<UserStatisticOutput>> Statistics(string userId)
        {
            return await Task.Run(() => { return Success(new UserStatisticOutput()); });
        }


        /// <summary>
        /// 用户被访问记录
        /// </summary>
        /// <param name="userId">用户id</param>
        /// <param name="pageIndex">页码</param>
        /// <param name="pageSize">页大小</param>
        /// <returns></returns>
        [HttpGet]
        public async Task<ResponseBase<PageResult<VisitorInfoOutput>>> GetVisitorRecord(string userId, int pageIndex, int pageSize)
        {
            return await Task.Run(() => { return Success(new PageResult<VisitorInfoOutput>()); });
        }


        /// <summary>
        /// 用户访问记录
        /// </summary>
        /// <param name="userId"></param>
        /// <returns></returns>
        [HttpGet]
        public async Task<ResponseBase<List<VisitUserInfoOutput>>> GetVisitRecord(string userId)
        {
            return await Task.Run(() => { return Success(new List<VisitUserInfoOutput>()); });
        }

        /// <summary>
        /// 签到
        /// </summary>
        /// <param name="userId"></param>
        /// <returns></returns>
        [HttpGet]
        public async Task<ResponseBase> SignIn(string userId)
        {
            return await Task.Run(() => { return new ResponseBase(); });
        }

        /// <summary>
        /// 用户签到记录
        /// </summary>
        /// <param name="userId"></param>
        /// <returns></returns>
        [HttpGet]
        public async Task<ResponseBase<List<RpSigninRecord>>> GetSignRecord(string userId)
        {
            return await Task.Run(() => { return Success(new List<RpSigninRecord>()); });
        }




        /// <summary>
        /// 领取金币
        /// </summary>
        /// <param name="userId"></param>
        /// <param name="count"></param>
        /// <returns></returns>
        [HttpGet]
        public async Task<ResponseBase<bool>> ReceiveCoins(string userId, int count)
        {
            return await Task.Run(() => { return Success(true); });
        }

        /// <summary>
        /// 获取用户账户
        /// 金币与经验值
        /// </summary>
        /// <param name="userId"></param>
        /// <returns></returns>
        [HttpGet]
        public async Task<ResponseBase<UserAccountOutput>> GetAccount(string userId)
        {
            return await Task.Run(() => { return Success(new UserAccountOutput()); });
        }

        /// <summary>
        /// 打赏礼物
        /// </summary>
        /// <param name="userId"></param>
        /// <returns></returns>
        [HttpGet]
        public async Task<ResponseBase<List<UserGiftOutput>>> GetAwardGifts(string userId)
        {
            return await Task.Run(() => { return Success(new List<UserGiftOutput>()); });
        }

        /// <summary>
        /// 打赏排行
        /// </summary>
        /// <param name="userId"></param>
        /// <returns></returns>
        [HttpGet]
        public async Task<ResponseBase<List<GiftUserInfoOutput>>> GetAwardUserRank(string userId)
        {
            return await Task.Run(() => { return Success(new List<GiftUserInfoOutput>()); });
        }


        /// <summary>
        /// 获取指定的用户的打赏的礼物
        /// </summary>
        /// <param name="userId">接受礼物的用户id</param>
        /// <param name="awardUserId">打赏礼物的用户id</param>
        /// <returns></returns>
        [HttpGet]
        public async Task<ResponseBase<List<RpGoodsSell>>> GetAwardGiftFromUser(string userId, string awardUserId)
        {
            return await Task.Run(() => { return Success(new List<RpGoodsSell>()); });

        }

        /// <summary>
        /// 本周足迹
        /// </summary>
        /// <param name="userId"></param>
        /// <returns></returns>
        [HttpGet]
            public async Task<ResponseBase<List<UserTrackOutput>>> GetWeekTrack(string userId)
            {
                return await Task.Run(() => { return Success(new List<UserTrackOutput>()); });
            }
       

    }
}
