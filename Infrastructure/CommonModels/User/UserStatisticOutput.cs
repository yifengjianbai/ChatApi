namespace Infrastructure.CommonModels.User
{
    /// <summary>
    /// 用户统计
    /// </summary>
    public class UserStatisticOutput
    { 
        /// <summary>
        /// 被关注数量
        /// </summary>
        public string FollowCount { get; set; }

        /// <summary>
        /// 关注数量
        /// </summary>
        public string FollowedCount { get; set; }

        /// <summary>
        /// 打赏数量
        /// </summary>
        public  string RewardCount { get; set; }


        /// <summary>
        /// 访问数量
        /// </summary>
        public string VisitCount { get; set; }
    }

}
