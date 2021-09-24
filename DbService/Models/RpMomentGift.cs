using System;
using System.Collections.Generic;

#nullable disable

namespace DbService.Models
{
    public partial class RpMomentGift
    {
        public long GiftId { get; set; }
        public string GiftCode { get; set; }
        public string GiftPic { get; set; }
        public string GiftName { get; set; }
        public int GiftPrice { get; set; }
        public string DonorId { get; set; }
        public string DonorName { get; set; }
        public string DonorAvatar { get; set; }
        public string UserId { get; set; }
        public DateTime CreateTime { get; set; }
        public string MomentId { get; set; }

        public virtual RpMomentInfo Moment { get; set; }
    }
}
