using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace Infrastructure.Enums
{
    /// <summary>
    /// 商品类型
    /// </summary>
    public enum GoodsType
    {
        /// <summary>
        /// 道具
        /// </summary>
        [Description("道具")]
        Prop = 0,

        /// <summary>
        /// 礼物
        /// </summary>
        [Description("礼物")]
        Gift = 1
    }

    /// <summary>
    /// 商品来源方式
    /// </summary>
    public enum GoodsFromType
    {

        /// <summary>
        /// 购买
        /// </summary>
        [Description("购买")]
        Buy =0,

        /// <summary>
        /// 赠送或打赏
        /// </summary>
        [Description("赠送")]
        Give =1,
    }
}
