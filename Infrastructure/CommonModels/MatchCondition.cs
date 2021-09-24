using System;
using System.Collections.Generic;
using System.Text;

namespace Infrastructure.CommonModels
{
    /// <summary>
    /// 匹配条件
    /// </summary>
    public class MatchCondition
    {
        /// <summary>
        /// 性别
        /// </summary>
        public int Sex { get; set; }

        /// <summary>
        /// 最小年龄
        /// </summary>
        public short AgeMin { get; set; }

        /// <summary>
        /// 最大年龄
        /// </summary>
        public short AgeMax { get; set; }

        /// <summary>
        /// 个性标签
        /// </summary>
        public string Tag { get; set; }
    }
}
