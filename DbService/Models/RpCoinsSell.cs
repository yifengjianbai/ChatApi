using System;
using System.Collections.Generic;

#nullable disable

namespace DbService.Models
{
    public partial class RpCoinsSell
    {
        public string SellCode { get; set; }
        public int ListOrder { get; set; }
        public int CoinCount { get; set; }
        public decimal Price { get; set; }
        public bool OnSale { get; set; }
        public string Memo { get; set; }
        public DateTime LastUpdate { get; set; }
    }
}
