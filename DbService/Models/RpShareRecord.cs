using System;
using System.Collections.Generic;

#nullable disable

namespace DbService.Models
{
    public partial class RpShareRecord
    {
        public long RecordId { get; set; }
        public short? ShareType { get; set; }
        public string TopicId { get; set; }
        public short TopicType { get; set; }
        public string UserId { get; set; }
        public DateTime CreateTime { get; set; }

        public virtual RpUserInfo User { get; set; }
    }
}
