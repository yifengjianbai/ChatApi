using System;
using System.Collections.Generic;

#nullable disable

namespace DbService.Models
{
    public partial class RpVipUserChargeSettting
    {
        public int SettingId { get; set; }
        public string ChargeName { get; set; }
        public int VipDuration { get; set; }
        public decimal CostMoney { get; set; }
        public DateTime LastUpdate { get; set; }
    }
}
