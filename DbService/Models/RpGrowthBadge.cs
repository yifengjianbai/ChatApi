using System;
using System.Collections.Generic;

#nullable disable

namespace DbService.Models
{
    public partial class RpGrowthBadge
    {
        public long BadgeId { get; set; }
        public string UserId { get; set; }
        public string BadgeName { get; set; }
        public string BadegCode { get; set; }
        public string Memo { get; set; }
        public string UserName { get; set; }
        public DateTime CreateTime { get; set; }

        public virtual RpUserInfo User { get; set; }
    }
}
