using System;
using System.Collections.Generic;
using System.Text;

namespace Infrastructure.CommonModels.User
{
    /// <summary>
    /// 打赏礼物
    /// </summary>
    public class UserGiftOutput
    {
        /// <summary>
        /// 礼品code
        /// </summary>
        public string GiftCode { get; set; }
        
        /// <summary>
        /// 名称
        /// </summary>
        public string GiftName { get; set; }

        /// <summary>
        /// 数量
        /// </summary>
        public int Count { get; set; }
    }
}
