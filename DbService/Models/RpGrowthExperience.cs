using System;
using System.Collections.Generic;

#nullable disable

namespace DbService.Models
{
    public partial class RpGrowthExperience
    {
        public long ExpId { get; set; }
        public int ExpGrowth { get; set; }
        public string GrowthAction { get; set; }
        public short GrowthType { get; set; }
        public DateTime CreateTime { get; set; }
        public string Memo { get; set; }
        public string UserId { get; set; }
        public string UserName { get; set; }

        public virtual RpUserInfo User { get; set; }
    }
}
