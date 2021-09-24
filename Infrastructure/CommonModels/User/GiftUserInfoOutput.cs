namespace Infrastructure.CommonModels.User
{
    /// <summary>
    /// 打赏礼物用户
    /// </summary>
    public class GiftUserInfoOutput : UserInfoOutput
    { 
        /// <summary>
        /// 打赏的礼物个数
        /// </summary>
        public int GiftCount { get; set; }

        /// <summary>
        /// 打赏总金额
        /// </summary>
        public decimal TotalMoney { get; set; }

        /// <summary>
        /// 排位
        /// </summary>
        public int RankNum { get; set; }
    }


}
