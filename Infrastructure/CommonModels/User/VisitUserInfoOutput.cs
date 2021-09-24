using System;

namespace Infrastructure.CommonModels.User
{
    /// <summary>
    /// 访客
    /// </summary>
    public class VisitUserInfoOutput : UserInfoOutput
    {

        /// <summary>
        /// 是否关注
        /// </summary>
        public bool IsFollowed { get; set; }


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
        /// 最近访问时间
        /// </summary>
        public DateTime NearVisitTime { get; set; }


        /// <summary>
        /// 最近访问展示时间
        /// </summary>
        public string DisplayNearVisitTime { get; set; }
    }



}
