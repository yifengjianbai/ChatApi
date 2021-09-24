using System;
using System.Collections.Generic;

#nullable disable

namespace DbService.Models
{
    public partial class RpWishProcess
    {
        public int ProcessId { get; set; }
        public string ProcessUser { get; set; }
        public DateTime CreateTime { get; set; }
        public string WishId { get; set; }
        public string GiftCode { get; set; }
        public string GiftName { get; set; }
        public int GiftValue { get; set; }
        public string UserId { get; set; }

        public virtual RpWishList Wish { get; set; }
    }
}
