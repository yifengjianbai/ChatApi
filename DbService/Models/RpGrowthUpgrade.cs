using System;
using System.Collections.Generic;

#nullable disable

namespace DbService.Models
{
    public partial class RpGrowthUpgrade
    {
        public long UpgradeId { get; set; }
        public string UserId { get; set; }
        public string UserName { get; set; }
        public int FromLevel { get; set; }
        public int ToLevel { get; set; }
        public string Memo { get; set; }
        public DateTime CreateTime { get; set; }

        public virtual RpUserInfo User { get; set; }
    }
}
