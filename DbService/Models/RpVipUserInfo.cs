using System;
using System.Collections.Generic;

#nullable disable

namespace DbService.Models
{
    public partial class RpVipUserInfo
    {
        public RpVipUserInfo()
        {
            RpWithdrawApplies = new HashSet<RpWithdrawApply>();
        }

        public int VipId { get; set; }
        public string UserId { get; set; }
        public DateTime VipDateBegin { get; set; }
        public DateTime VipExpired { get; set; }
        public DateTime CreateTime { get; set; }
        public DateTime LastUpdate { get; set; }

        public virtual RpUserInfo User { get; set; }
        public virtual ICollection<RpWithdrawApply> RpWithdrawApplies { get; set; }
    }
}
