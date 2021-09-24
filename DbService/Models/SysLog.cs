using System;
using System.Collections.Generic;

#nullable disable

namespace DbService.Models
{
    public partial class SysLog
    {
        public string Id { get; set; }
        public string Content { get; set; }
        public string TypeName { get; set; }
        public string TypeId { get; set; }
        public string Href { get; set; }
        public DateTime CreateTime { get; set; }
        public string CreateId { get; set; }
        public string CreateName { get; set; }
        public string Ip { get; set; }
        public int Result { get; set; }
        public string Application { get; set; }
    }
}
