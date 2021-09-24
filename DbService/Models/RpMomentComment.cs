using System;
using System.Collections.Generic;

#nullable disable

namespace DbService.Models
{
    public partial class RpMomentComment
    {
        public RpMomentComment()
        {
            RpCommentLikeds = new HashSet<RpCommentLiked>();
        }

        public string CommentId { get; set; }
        public string CommentText { get; set; }
        public string UserId { get; set; }
        public string UserName { get; set; }
        public string UserAvatar { get; set; }
        public DateTime CreateTime { get; set; }
        public int LikedCount { get; set; }
        public string MomentId { get; set; }

        public virtual RpMomentInfo Moment { get; set; }
        public virtual ICollection<RpCommentLiked> RpCommentLikeds { get; set; }
    }
}
