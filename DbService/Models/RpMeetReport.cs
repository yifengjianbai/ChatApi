using System;
using System.Collections.Generic;

#nullable disable

namespace DbService.Models
{
    public partial class RpMeetReport
    {
        public long ReportId { get; set; }
        public DateTime BeginTime { get; set; }
        public DateTime EndTime { get; set; }
        public string UserId { get; set; }
        public string Counry { get; set; }
        public string Province { get; set; }
        public string City { get; set; }
        public string District { get; set; }
        public string Street { get; set; }
        public int ArriveCount { get; set; }
        public int MetPersonCount { get; set; }
        public DateTime CreateTime { get; set; }
    }
}
