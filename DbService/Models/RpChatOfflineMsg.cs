using System;
using System.Collections.Generic;

#nullable disable

namespace DbService.Models
{
    public partial class RpChatOfflineMsg
    {
        public string MsgId { get; set; }
        public string MsgContent { get; set; }
        public string FriendId { get; set; }
        public string UserId { get; set; }
        public DateTime ExpireTime { get; set; }
        public string SessionId { get; set; }
        public DateTime CreateTime { get; set; }
        public short MsgContentType { get; set; }
        public short MsgType { get; set; }

        public virtual RpUserInfo User { get; set; }
    }
}
