namespace Infrastructure.CommonModels.User
{
    /// <summary>
    /// 用户足迹
    /// </summary>
    public class UserTrackOutput
    { 
        /// <summary>
        /// 城市
        /// </summary>
        public string City { get; set; }

        /// <summary>
        /// 街道
        /// </summary>
        public string Address { get; set; }


        /// <summary>
        /// 平常
        /// </summary>
        public bool IsOften { get; set; }

        /// <summary>
        /// 到访次数
        /// </summary>
        public string Count { get; set; }


        /// <summary>
        /// 交互人数
        /// </summary>
        public int InteractCount { get; set; } 

    }
}
