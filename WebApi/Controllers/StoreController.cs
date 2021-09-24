using DbService.IService;
using DbService.Models;
using Infrastructure.CommonModels;
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
    /// 商店
    /// </summary>
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class StoreController : RedPaperController
    {
        private readonly IStoreService _storeService;
        public StoreController(IStoreService storeService)
        {
            _storeService = storeService;
        }
        /// <summary>
        /// 商品分页列表
        /// </summary>
        /// <param name="goodsType">商品类型</param>
        /// <param name="pageIndex">页码</param>
        /// <param name="pageSize">页大小</param>
        /// <returns></returns>
        [HttpGet]
        public async Task<ResponseBase<PageResult<RpGoodsSell>>> GoodsSellPageList(GoodsType goodsType, int pageIndex = 1, int pageSize = 8)
        {
            var result = await _storeService.GoodsSellPageListAsync(goodsType, pageIndex, pageSize);
            return Success(result);

        }


        /// <summary>
        /// 金币售卖分页列表
        /// </summary>
        /// <param name="pageIndex">页码</param>
        /// <param name="pageSize">页大小</param>
        /// <returns></returns>
        [HttpGet]
        public async Task<ResponseBase<PageResult<RpCoinsSell>>> CoinsSellPageList(int pageIndex = 1, int pageSize = 8)
        {
            var result = await _storeService.CoinsSellPageListAsync(pageIndex, pageSize);
            return Success(result);
        }


    }
}
