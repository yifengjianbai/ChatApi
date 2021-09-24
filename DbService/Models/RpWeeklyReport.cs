using System;
using System.Collections.Generic;

#nullable disable

namespace DbService.Models
{
    public partial class RpWeeklyReport
    {
        public long ReportId { get; set; }
        public DateTime BeginTime { get; set; }
        public DateTime EndTime { get; set; }
        public int MomentCount { get; set; }
        public int MomentLikeCount { get; set; }
        public int CommentCount { get; set; }
        public int GetAwardCount { get; set; }
        public int GiveAwardCount { get; set; }
        public string UserId { get; set; }
        public DateTime CreateTime { get; set; }
    }
}
