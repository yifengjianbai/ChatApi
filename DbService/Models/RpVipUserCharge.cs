using System;
using System.Collections.Generic;

#nullable disable

namespace DbService.Models
{
    public partial class RpVipUserCharge
    {
        public int ChargeId { get; set; }
        public string VipUserId { get; set; }
        public DateTime ChargeTime { get; set; }
        public decimal ChargeFee { get; set; }
        public int VipDuration { get; set; }
        public DateTime BeginDate { get; set; }
        public DateTime EndDate { get; set; }
        public string Memo { get; set; }
        public string UserId { get; set; }

        public virtual RpUserInfo User { get; set; }
    }
}
