using System;
using System.Collections.Generic;

#nullable disable

namespace DbService.Models
{
    public partial class RpExpSignAcquireSetting
    {
        public int SettingId { get; set; }
        public int DayNum { get; set; }
        public int ExpValue { get; set; }
        public int VipMultipe { get; set; }
        public DateTime LastUpdate { get; set; }
    }
}
