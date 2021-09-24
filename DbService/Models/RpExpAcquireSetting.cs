using System;
using System.Collections.Generic;

#nullable disable

namespace DbService.Models
{
    public partial class RpExpAcquireSetting
    {
        public long SettingId { get; set; }
        public short ActionType { get; set; }
        public int VipExpValue { get; set; }
        public int VipLimitNum { get; set; }
        public int ExpValue { get; set; }
        public int LimitNum { get; set; }
        public DateTime LastUpdate { get; set; }
    }
}
