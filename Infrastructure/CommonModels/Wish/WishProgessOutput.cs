using System;
using System.Collections.Generic;
using System.Text;

namespace Infrastructure.CommonModels.Wish
{
    public class WishProgessOutput
    {
        /// <summary>
        /// 进度百分比
        /// </summary>
        public int ProgessPercent { get; set; }

        /// <summary>
        /// 差额
        /// </summary>
        public long Balance { get; set; }
    }



}
