using System;
using System.Collections.Generic;

#nullable disable

namespace DbService.Models
{
    public partial class RpWithdrawApply
    {
        public string ApplyId { get; set; }
        public string UserId { get; set; }
        public int CoinCount { get; set; }
        public decimal TotalMoney { get; set; }
        public decimal HandleFeePer { get; set; }
        public decimal HandleFee { get; set; }
        public decimal ActualMoney { get; set; }
        public short ApplyStatus { get; set; }
        public DateTime FinishTime { get; set; }
        public DateTime CreateTime { get; set; }
        public string OrderCode { get; set; }
        public int? VipId { get; set; }

        public virtual RpVipUserInfo Vip { get; set; }
    }
}
