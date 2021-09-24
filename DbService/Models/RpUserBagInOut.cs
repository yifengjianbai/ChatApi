using System;
using System.Collections.Generic;

#nullable disable

namespace DbService.Models
{
    public partial class RpUserBagInOut
    {
        public int AcctionId { get; set; }
        public string UserId { get; set; }
        public string StuffName { get; set; }
        public short StuffType { get; set; }
        public string AboutUserId { get; set; }
        public string Memo { get; set; }
        public short ActionType { get; set; }
        public short BehaviorType { get; set; }
        public int StuffValue { get; set; }
        public DateTime CreateTime { get; set; }
        public string BagId { get; set; }
        public string StuffCode { get; set; }

        public virtual RpUserBag Bag { get; set; }
    }
}
