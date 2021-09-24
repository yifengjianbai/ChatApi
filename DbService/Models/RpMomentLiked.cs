using System;
using System.Collections.Generic;

#nullable disable

namespace DbService.Models
{
    public partial class RpMomentLiked
    {
        public long LikeId { get; set; }
        public string LikedUserId { get; set; }
        public string LikeUserName { get; set; }
        public string LikedAvatar { get; set; }
        public DateTime CreateTime { get; set; }
        public string MomentId { get; set; }

        public virtual RpMomentInfo Moment { get; set; }
    }
}
