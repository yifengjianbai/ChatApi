using System;
using System.Collections.Generic;

#nullable disable

namespace DbService.Models
{
    public partial class RpCommentLiked
    {
        public long LikeId { get; set; }
        public string LikedUserId { get; set; }
        public string CommentId { get; set; }
        public DateTime LikedTime { get; set; }

        public virtual RpMomentComment Comment { get; set; }
    }
}
