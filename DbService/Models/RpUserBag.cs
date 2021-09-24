using System;
using System.Collections.Generic;

#nullable disable

namespace DbService.Models
{
    public partial class RpUserBag
    {
        public RpUserBag()
        {
            RpStuffsInBags = new HashSet<RpStuffsInBag>();
            RpUserBagInOuts = new HashSet<RpUserBagInOut>();
        }

        public string BagId { get; set; }
        public int GiftCount { get; set; }
        public int PropCount { get; set; }
        public string UserId { get; set; }
        public DateTime CreateTime { get; set; }
        public DateTime LastUpdate { get; set; }

        public virtual RpUserInfo User { get; set; }
        public virtual ICollection<RpStuffsInBag> RpStuffsInBags { get; set; }
        public virtual ICollection<RpUserBagInOut> RpUserBagInOuts { get; set; }
    }
}
