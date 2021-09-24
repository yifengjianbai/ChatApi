using System;
using System.Collections.Generic;

#nullable disable

namespace DbService.Models
{
    public partial class RpUserNotify
    {
        public int NotifyId { get; set; }
        public string UserId { get; set; }
        public string NotifyText { get; set; }
        public short NotifyType { get; set; }
        public string OtherUsers { get; set; }
        public string CreateTime { get; set; }
        public bool HasRead { get; set; }

        public virtual RpUserInfo User { get; set; }
    }
}
