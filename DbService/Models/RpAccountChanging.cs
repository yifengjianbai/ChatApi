using System;
using System.Collections.Generic;

#nullable disable

namespace DbService.Models
{
    public partial class RpAccountChanging
    {
        public long ChangingId { get; set; }
        public int CoinsBefore { get; set; }
        public int CoinsChanged { get; set; }
        public int CoinsAfter { get; set; }
        public short ChangeType { get; set; }
        public string UserId { get; set; }
        public string UserName { get; set; }

        public virtual RpUserInfo User { get; set; }
    }
}
