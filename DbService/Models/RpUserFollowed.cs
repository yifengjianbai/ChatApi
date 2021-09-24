using System;
using System.Collections.Generic;

#nullable disable

namespace DbService.Models
{
    public partial class RpUserFollowed
    {
        public long FollowId { get; set; }
        public string UserId { get; set; }
        public string FollowedId { get; set; }
        public string FollowedName { get; set; }
        public string Remark { get; set; }
        public DateTime CreateTime { get; set; }

        public virtual RpUserInfo User { get; set; }
    }
}
