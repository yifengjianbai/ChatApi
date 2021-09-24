using System;
using System.Collections.Generic;

#nullable disable

namespace DbService.Models
{
    public partial class RpTag
    {
        public long TagId { get; set; }
        public string TagText { get; set; }
        public string TagType { get; set; }
        public DateTime LastUpdate { get; set; }
    }
}
