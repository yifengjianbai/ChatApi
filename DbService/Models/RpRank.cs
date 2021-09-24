using System;
using System.Collections.Generic;

#nullable disable

namespace DbService.Models
{
    public partial class RpRank
    {
        public long RankId { get; set; }
        public short RankType { get; set; }
        public int RankNum { get; set; }
        public string UserId { get; set; }
        public string NickName { get; set; }
        public string AvatarUrl { get; set; }
        public DateTime BeginTime { get; set; }
        public DateTime EndTime { get; set; }
        public DateTime CreateTime { get; set; }
    }
}
