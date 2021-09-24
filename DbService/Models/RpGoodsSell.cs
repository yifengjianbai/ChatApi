using System;
using System.Collections.Generic;

#nullable disable

namespace DbService.Models
{
    public partial class RpGoodsSell
    {
        public string GoodsCode { get; set; }
        public int ListOrder { get; set; }
        public string GoodsName { get; set; }
        public short GoodsType { get; set; }
        public int CoinCount { get; set; }
        public string GoodsPic { get; set; }
        public bool OnSale { get; set; }
        public string Memo { get; set; }
        public DateTime CreateTime { get; set; }
    }
}
