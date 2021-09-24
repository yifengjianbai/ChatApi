using System;
using System.Collections.Generic;

#nullable disable

namespace DbService.Models
{
    public partial class RpVipUserRequire
    {
        public int RequireId { get; set; }
        public string UserId { get; set; }
        public byte? ReqUserGender { get; set; }
        public short ReqAgeMin { get; set; }
        public short ReqAgeMax { get; set; }
        public string ReqUserTags { get; set; }
        public DateTime LastUpdate { get; set; }

        public virtual RpUserInfo User { get; set; }
    }
}
