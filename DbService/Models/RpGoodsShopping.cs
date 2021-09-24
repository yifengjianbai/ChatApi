using System;
using System.Collections.Generic;

#nullable disable

namespace DbService.Models
{
    public partial class RpGoodsShopping
    {
        public long ShoppingId { get; set; }
        public string GoodsName { get; set; }
        public int GoodsCount { get; set; }
        public string GoodsCode { get; set; }
        public int GoodsPrice { get; set; }
        public int OrderCoins { get; set; }
        public short GoodsType { get; set; }
        public DateTime CreateTime { get; set; }
        public string UserId { get; set; }

        public virtual RpUserInfo User { get; set; }
    }
}
