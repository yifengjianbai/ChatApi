using System;
using System.Collections.Generic;

#nullable disable

namespace DbService.Models
{
    public partial class RpOrdinaryUserAwardSetting
    {
        public RpOrdinaryUserAwardSetting()
        {
            RpOrdinaryUserAwardGoods = new HashSet<RpOrdinaryUserAwardGood>();
        }

        public long SettingId { get; set; }
        public int Level { get; set; }
        public int MomentFreeCountPerWeek { get; set; }
        public int ChatFreeCountPerWeek { get; set; }
        public DateTime? LastUpdate { get; set; }

        public virtual ICollection<RpOrdinaryUserAwardGood> RpOrdinaryUserAwardGoods { get; set; }
    }
}
