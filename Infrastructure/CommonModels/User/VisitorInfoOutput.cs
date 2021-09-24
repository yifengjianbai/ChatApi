using System;

namespace Infrastructure.CommonModels.User
{

    /// <summary>
    /// 访问者信息
    /// </summary>
    public class VisitorInfoOutput : UserInfoOutput
    {
        /// <summary>
        /// 是否达人
        /// </summary>
        public bool IsVip { get; set; }

        /// <summary>
        /// 是否在线
        /// </summary>
        public bool IsOnline { get; set; }

        /// <summary>
        /// 是否匿名
        /// </summary>
        public bool IsAnonymous { get; set; }

        /// <summary>
        /// 访问次数
        /// </summary>
        public int VisitCount { get; set; }


        /// <summary>
        /// 最近的访问时间
        /// </summary>
        public DateTime LastVistTime { get; set; }
             

        /// <summary>
        /// 文本
        /// </summary>
        public string DisplayText { get; set; }
    }



}
