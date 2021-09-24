using System;
using System.Collections.Generic;
using System.Text;

namespace Infrastructure.CommonModels
{
    /// <summary>
    /// 素人奖励模型
    /// </summary>
    public class NormalUserAward
    {
        /// <summary>
        /// 素人等级
        /// </summary>
        public int Level { get; set; }

        /// <summary>
        /// 每周免费发布动态的次数
        /// </summary>
        public int MomentFreeCountPerWeek { get; set; }

        /// <summary>
        /// 每周免费私聊的次数
        /// </summary>
        public int ChatFreeCountPerWeek { get; set; }

        /// <summary>
        /// 赠送商品
        /// </summary>
        public List<NormalUserAwardGoods> AwardGoods { get; set; }
    }

    /// <summary>
    /// 素人奖励商品模型
    /// </summary>
    public class NormalUserAwardGoods
    {
        /// <summary>
        /// 商品编码
        /// </summary>
        public string GoodsCode { get; set; }

        /// <summary>
        /// 商品个数
        /// </summary>
        public int Count { get; set; }
    }
}
