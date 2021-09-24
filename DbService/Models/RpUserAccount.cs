using System;
using System.Collections.Generic;

#nullable disable

namespace DbService.Models
{
    public partial class RpUserAccount
    {
        public string AccountId { get; set; }
        public string UserId { get; set; }
        public int AmountExperience { get; set; }
        public int CurrCoins { get; set; }
        public long AmountCoins { get; set; }
        public DateTime LastUpdate { get; set; }
        public int UserLevel { get; set; }
        public int NewExperience { get; set; }
        public DateTime CreateTime { get; set; }
        public int ConvertExperience { get; set; }

        public virtual RpUserInfo User { get; set; }
    }
}
