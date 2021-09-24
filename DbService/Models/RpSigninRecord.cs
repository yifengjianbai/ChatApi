using System;
using System.Collections.Generic;

#nullable disable

namespace DbService.Models
{
    public partial class RpSigninRecord
    {
        public long RecordId { get; set; }
        public int SignNum { get; set; }
        public DateTime SignTime { get; set; }
        public string UserId { get; set; }

        public virtual RpUserInfo User { get; set; }
    }
}
