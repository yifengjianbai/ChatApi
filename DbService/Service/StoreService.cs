using DbService.IService;
using DbService.Models;
using DbService.Repositories;
using Infrastructure.CommonModels;
using Infrastructure.Enums;
using Infrastructure.Extensions;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DbService.Service
{
    /// <summary>
    /// 商店服务
    /// </summary>
    public class StoreService : IStoreService
    {
        private readonly IRpRepository<RpGoodsSell> _goodsSellRepo;
        private readonly IRpRepository<RpCoinsSell> _coinsSellRepo;
        public StoreService(IRpRepository<RpGoodsSell> goodsSellRepo, IRpRepository<RpCoinsSell> coinsSellRepo)
        {
            _goodsSellRepo = goodsSellRepo;
            _coinsSellRepo = coinsSellRepo;
        }

        /// <summary>
        /// 金币售卖分页
        /// </summary>
        /// <param name="pageIndex">页码</param>
        /// <param name="pageSize">页大小</param>
        /// <returns></returns>
        public async Task<PageResult<RpCoinsSell>> CoinsSellPageListAsync(int pageIndex, int pageSize = 8)
        {
            var where = PredicateBuilder.True<RpCoinsSell>();
            where = where.And(x => x.OnSale == true);
            var models = await _coinsSellRepo.Where(where, x => x.ListOrder, pageIndex, pageSize, out int count, false).ToListAsync();
            var result = new PageResult<RpCoinsSell>()
            {
                PageIndex = pageIndex,
                PageSize = pageSize,
                Total = count,
                Data = models
            };
            return result;
        }

        /// <summary>
        /// 商品售卖分页
        /// </summary>
        /// <param name="goodsType">商品分类</param>
        /// <param name="pageIndex">页码</param>
        /// <param name="pageSize">页大小</param>
        /// <returns></returns>
        public async Task<PageResult<RpGoodsSell>> GoodsSellPageListAsync(GoodsType goodsType, int pageIndex, int pageSize = 8)
        {
            var where = PredicateBuilder.True<RpGoodsSell>();
            where = where.And(x => x.OnSale == true);
            where = where.And(x => x.GoodsType == (short)goodsType);
            var models = await _goodsSellRepo.Where(where, x => x.ListOrder, pageIndex, pageSize, out int count, false).ToListAsync();
            var result = new PageResult<RpGoodsSell>()
            {
                PageIndex = pageIndex,
                PageSize = pageSize,
                Total = count,
                Data = models
            };
            return result;
        }
    }
}
