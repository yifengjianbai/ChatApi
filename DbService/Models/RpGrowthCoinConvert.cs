using System;
using System.Collections.Generic;

#nullable disable

namespace DbService.Models
{
    public partial class RpGrowthCoinConvert
    {
        public long ConvertId { get; set; }
        public int ConvertExperience { get; set; }
        public int CreatedCoins { get; set; }
        public int LeftExperience { get; set; }
        public string UserId { get; set; }
        public DateTime? Memo { get; set; }
        public DateTime CreateTime { get; set; }
        public string UserName { get; set; }

        public virtual RpUserInfo User { get; set; }
    }
}
