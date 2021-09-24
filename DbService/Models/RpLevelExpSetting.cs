using System;
using System.Collections.Generic;

#nullable disable

namespace DbService.Models
{
    public partial class RpLevelExpSetting
    {
        public long SettingId { get; set; }
        public int Level { get; set; }
        public long ThreadholdExp { get; set; }
        public DateTime LastUpdate { get; set; }
    }
}
