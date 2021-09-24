using System;
using System.Collections.Generic;

#nullable disable

namespace DbService.Models
{
    public partial class RpChatReadFlag
    {
        public long FlagId { get; set; }
        public string MsgId { get; set; }
        public string SenderId { get; set; }
        public DateTime CreateTime { get; set; }
        public string SessionId { get; set; }
        public string UserId { get; set; }

        public virtual RpUserInfo User { get; set; }
    }
}
