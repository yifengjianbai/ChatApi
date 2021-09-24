using System;
using System.Collections.Generic;

#nullable disable

namespace DbService.Models
{
    public partial class RpBadge
    {
        public string BadgeId { get; set; }
        public string BadgeName { get; set; }
        public string BadgeCode { get; set; }
        public string BadgePic { get; set; }
        public DateTime LastUpdate { get; set; }
    }
}
