using System;
using System.Collections.Generic;

#nullable disable

namespace DbService.Models
{
    public partial class RpUserBadge
    {
        public string UserBadgeId { get; set; }
        public string BadgeId { get; set; }
        public string BadgeName { get; set; }
        public string BadgeCode { get; set; }
        public string BadgePic { get; set; }
        public string UserId { get; set; }
        public DateTime CreateTime { get; set; }

        public virtual RpUserInfo User { get; set; }
    }
}
