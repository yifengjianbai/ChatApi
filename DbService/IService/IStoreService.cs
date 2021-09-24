using DbService.Models;
using Infrastructure.CommonModels;
using Infrastructure.Enums;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DbService.IService
{
    /// <summary>
    /// 商店服务接口
    /// </summary>
    public interface IStoreService:IRpService
    {
        /// <summary>
        /// 商品售卖分页
        /// </summary>
        /// <param name="goodsType"></param>
        /// <param name="pageIndex"></param>
        /// <param name="pageSize"></param>
        /// <returns></returns>
        Task<PageResult<RpGoodsSell>> GoodsSellPageListAsync(GoodsType goodsType, int pageIndex, int pageSize = 8);

        /// <summary>
        /// 金币售卖分页
        /// </summary>
        /// <param name="pageIndex"></param>
        /// <param name="pageSize"></param>
        /// <returns></returns>
        Task<PageResult<RpCoinsSell>> CoinsSellPageListAsync(int pageIndex, int pageSize = 8);

    }
}
