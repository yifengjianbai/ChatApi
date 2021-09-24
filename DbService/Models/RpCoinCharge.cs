using System;
using System.Collections.Generic;

#nullable disable

namespace DbService.Models
{
    public partial class RpCoinCharge
    {
        public long ChargeId { get; set; }
        public int CoinCount { get; set; }
        public decimal CostMoney { get; set; }
        public string UserId { get; set; }
        public DateTime CreateTime { get; set; }
        public string SellCode { get; set; }
        public string Memo { get; set; }

        public virtual RpUserInfo User { get; set; }
    }
}
