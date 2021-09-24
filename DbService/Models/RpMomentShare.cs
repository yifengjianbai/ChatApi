using System;
using System.Collections.Generic;

#nullable disable

namespace DbService.Models
{
    public partial class RpMomentShare
    {
        public long ShareId { get; set; }
        public string MomentId { get; set; }
        public short ShareType { get; set; }
        public string UserId { get; set; }
        public DateTime CreateTime { get; set; }

        public virtual RpMomentInfo Moment { get; set; }
    }
}
