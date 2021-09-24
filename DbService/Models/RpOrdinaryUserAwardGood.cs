using System;
using System.Collections.Generic;

#nullable disable

namespace DbService.Models
{
    public partial class RpOrdinaryUserAwardGood
    {
        public long Id { get; set; }
        public string GoodsCode { get; set; }
        public int Count { get; set; }
        public DateTime CreateTime { get; set; }
        public long OrdinaryUserAwardSettingId { get; set; }

        public virtual RpOrdinaryUserAwardSetting OrdinaryUserAwardSetting { get; set; }
    }
}
