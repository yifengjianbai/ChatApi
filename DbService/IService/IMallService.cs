using DbService.Models;
using Infrastructure.CommonModels;
using Infrastructure.Enums;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DbService.IService
{
    /// <summary>
    /// 商城服务接口
    /// </summary>
    public interface IMallService: IRpService
    {
        #region 金币

        /// <summary>
        /// 获取售卖金币
        /// </summary>
        /// <returns></returns>
        Task<List<RpCoinsSell>> GetAllCoinsSell();

        /// <summary>
        /// 售卖金币分页
        /// </summary>
        /// <param name="keyword">名称关键字</param>
        /// <param name="pageIndex">页码</param>
        /// <param name="pageSize">页大小</param>
        /// <returns></returns>
        PageResult<RpGoodsSell> PageCoinsSell(string keyword, int pageIndex, int pageSize);

        /// <summary>
        /// 添加售卖金币
        /// </summary>
        /// <param name="rpCoinsSell"></param>
        /// <returns></returns>
        Task AddCoinsSellAsync(RpCoinsSell rpCoinsSell);

        /// <summary>
        /// 更新售卖金币
        /// </summary>
        /// <param name="rpCoinsSell"></param>
        /// <returns></returns>
        Task EditCoinsSellAsync(RpCoinsSell rpCoinsSell);


        /// <summary>
        /// 删除售卖金币
        /// </summary>
        /// <param name="sellCode"></param>
        /// <returns></returns>
        Task DeleteCoinsSellAsync(string sellCode);

        #endregion


        #region 商品(礼物与道具)
        /// <summary>
        /// 售卖商品分页
        /// </summary>
        /// <param name="keyword">名称关键字</param>
        /// <param name="goodsType">商品分类</param>
        /// <param name="pageIndex">页码</param>
        /// <param name="pageSize">页大小</param>
        /// <returns></returns>
        PageResult<RpGoodsSell> PageGoodsSell(string keyword, GoodsType goodsType, int pageIndex, int pageSize);

        /// <summary>
        /// 添加售卖商品
        /// </summary>
        /// <param name="rpGoodsSell"></param>
        /// <returns></returns>
        Task AddGoodsSellAsync(RpGoodsSell rpGoodsSell);


        /// <summary>
        /// 更新售卖商品
        /// </summary>
        /// <param name="rpGoodsSell"></param>
        /// <returns></returns>
        Task EditGoodsSellAsync(RpGoodsSell rpGoodsSell);


        /// <summary>
        /// 删除售卖商品
        /// </summary>
        /// <param name="goodsCode"></param>
        /// <returns></returns>
        Task DeleteGoodsSellAsync(string goodsCode);

        #endregion
    }

}
