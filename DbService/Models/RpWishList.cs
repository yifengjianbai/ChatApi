using System;
using System.Collections.Generic;

#nullable disable

namespace DbService.Models
{
    public partial class RpWishList
    {
        public RpWishList()
        {
            RpWishProcesses = new HashSet<RpWishProcess>();
        }

        public string WishId { get; set; }
        public string WishName { get; set; }
        public string WishDesc { get; set; }
        public short RealizeType { get; set; }
        public string RealizeUser { get; set; }
        public string GiftCode { get; set; }
        public string GiftName { get; set; }
        public string GiftPicUrl { get; set; }
        public int GiftValue { get; set; }
        public short WishStatus { get; set; }
        public DateTime CreateTime { get; set; }
        public DateTime PubTime { get; set; }
        public string UserId { get; set; }
        public string WishCatalog { get; set; }
        public DateTime FinishTime { get; set; }
        public decimal WishProgress { get; set; }
        public bool IsFree { get; set; }
        public short WishDescType { get; set; }

        public virtual RpUserInfo User { get; set; }
        public virtual ICollection<RpWishProcess> RpWishProcesses { get; set; }
    }
}
