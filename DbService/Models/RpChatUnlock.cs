using System;
using System.Collections.Generic;

#nullable disable

namespace DbService.Models
{
    public partial class RpChatUnlock
    {
        public long LockId { get; set; }
        public string UserId { get; set; }
        public string FriendId { get; set; }
        public DateTime CreateTime { get; set; }
        public string Memo { get; set; }

        public virtual RpUserInfo User { get; set; }
    }
}
