using System;
using System.Collections.Generic;

#nullable disable

namespace DbService.Models
{
    public partial class RpStuffsInBag
    {
        public string StuffId { get; set; }
        public string BagId { get; set; }
        public string UserId { get; set; }
        public string StuffName { get; set; }
        public short StuffType { get; set; }
        public DateTime CreateTime { get; set; }
        public string FromUserId { get; set; }
        public short FromType { get; set; }
        public string Memo { get; set; }
        public string StuffCode { get; set; }

        public virtual RpUserBag Bag { get; set; }
    }
}
