using System;
using System.Collections.Generic;

#nullable disable

namespace DbService.Models
{
    public partial class RpMomentInfo
    {
        public RpMomentInfo()
        {
            RpMomentComments = new HashSet<RpMomentComment>();
            RpMomentGifts = new HashSet<RpMomentGift>();
            RpMomentLikeds = new HashSet<RpMomentLiked>();
            RpMomentShares = new HashSet<RpMomentShare>();
        }

        public string MomentId { get; set; }
        public string UserId { get; set; }
        public string Content { get; set; }
        public bool OnTop { get; set; }
        public short Scope { get; set; }
        public bool IsAnonymous { get; set; }
        public int GiftCount { get; set; }
        public int LikeCount { get; set; }
        public int VisitCount { get; set; }
        public string AtUserIds { get; set; }
        public string AtWishId { get; set; }
        public string City { get; set; }
        public string UserLocation { get; set; }
        public string GpsInfo { get; set; }
        public short MomentType { get; set; }
        public DateTime CreateTime { get; set; }
        public bool HasAttath { get; set; }
        public bool IsFree { get; set; }
        public bool IsVipMoment { get; set; }

        public virtual RpUserInfo User { get; set; }
        public virtual ICollection<RpMomentComment> RpMomentComments { get; set; }
        public virtual ICollection<RpMomentGift> RpMomentGifts { get; set; }
        public virtual ICollection<RpMomentLiked> RpMomentLikeds { get; set; }
        public virtual ICollection<RpMomentShare> RpMomentShares { get; set; }
    }
}
