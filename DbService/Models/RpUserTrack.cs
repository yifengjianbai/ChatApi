using System;
using System.Collections.Generic;

#nullable disable

namespace DbService.Models
{
    public partial class RpUserTrack
    {
        public long TrackId { get; set; }
        public string UserId { get; set; }
        public string GpsLocation { get; set; }
        public string Country { get; set; }
        public string Province { get; set; }
        public string City { get; set; }
        public string District { get; set; }
        public string Street { get; set; }
        public string StreetNumber { get; set; }
        public string Address { get; set; }
        public DateTime CreatTime { get; set; }

        public virtual RpUserInfo User { get; set; }
    }
}
