using System;
using System.Collections.Generic;

#nullable disable

namespace DbService.Models
{
    public partial class RpPubMedium
    {
        public long MediaId { get; set; }
        public short MediaType { get; set; }
        public string MediaUrl { get; set; }
        public string TopicId { get; set; }
        public string UserId { get; set; }
        public short TopicType { get; set; }
        public DateTime CreateTime { get; set; }
    }
}
