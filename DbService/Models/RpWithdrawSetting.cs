using System;
using System.Collections.Generic;

#nullable disable

namespace DbService.Models
{
    public partial class RpWithdrawSetting
    {
        public long SettingId { get; set; }
        public short Identity { get; set; }
        public int Level { get; set; }
        public long CoinMin { get; set; }
        public long CoinMax { get; set; }
        public DateTime LastUpdate { get; set; }
    }
}
