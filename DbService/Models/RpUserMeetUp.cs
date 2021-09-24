using System;
using System.Collections.Generic;

#nullable disable

namespace DbService.Models
{
    public partial class RpUserMeetUp
    {
        public long MetId { get; set; }
        public string UserId { get; set; }
        public string MetUserId { get; set; }
        public int MetDistance { get; set; }
        public string MetGps { get; set; }
        public string MetSpot { get; set; }
        public DateTime CreatTime { get; set; }

        public virtual RpUserInfo User { get; set; }
    }
}
