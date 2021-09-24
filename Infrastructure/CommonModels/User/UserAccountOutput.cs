using System;
using System.Collections.Generic;
using System.Text;

namespace Infrastructure.CommonModels.User
{
    /// <summary>
    /// 用户账户经验与金币
    /// </summary>
    public class UserAccountOutput
    {
        /// <summary>
        /// 金币数量
        /// </summary>
        public int CoinsCount { get; set; }

        /// <summary>
        /// 本周新增经验值
        /// </summary>
        public int NewExperience { get; set; }

        /// <summary>
        /// 可转换为金币的经验值
        /// </summary>
        public int ConvertExperience { get; set; }

        /// <summary>
        /// 可提取的金币数量
        /// </summary>
        public int AvaiableCoinsCount { get; set; }
    }
}
