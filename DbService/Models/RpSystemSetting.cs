using System;
using System.Collections.Generic;

#nullable disable

namespace DbService.Models
{
    public partial class RpSystemSetting
    {
        public long SettingId { get; set; }
        public string Key { get; set; }
        public string Value { get; set; }
        public DateTime LastUpdate { get; set; }
    }
}
