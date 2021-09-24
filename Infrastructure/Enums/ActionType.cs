using System.ComponentModel;

namespace Infrastructure.Enums
{
    /// <summary>
    /// 行为类别
    /// </summary>
    public enum ActionType
    {
        /// <summary>
        /// 发布动态
        /// </summary>
        [Description("发布动态")]
        PubMement = 1,

        /// <summary>
        /// 发布愿望
        /// </summary>
        [Description("发布愿望")]
        PubWish = 2,

        /// <summary>
        /// 每日登录
        /// </summary>
        [Description("每日登录")]
        Login = 3,

        /// <summary>
        /// 邀请注册
        /// </summary>
        [Description("邀请注册")]
        InviteRegist = 4,

        /// <summary>
        /// 每日分享
        /// </summary>
        [Description("每日分享")]
        Share = 5,

        /// <summary>
        /// 礼物打赏
        /// </summary>
        [Description("礼物打赏")]
        AwardGift = 6,

        /// <summary>
        /// 每日签到
        /// </summary>
        [Description("每日签到")]
        Signin = 7,

        /// <summary>
        /// 每日评论
        /// </summary>
        [Description("每日评论")]
        Remark = 8

    }

    /// <summary>
    /// 背包行为
    /// </summary>
    public enum BagActionType
    {
        /// <summary>
        /// 存入
        /// </summary>
        [Description("存入")]
        PutIn = 0,

        /// <summary>
        /// 取出
        /// </summary>
        [Description("取出")]
        TakeOut = 1
    }

    /// <summary>
    /// 商品使用行为
    /// </summary>
    public enum BehaviorType
    {
        /// <summary>
        /// 打赏
        /// </summary>
        [Description("打赏")]
        Award = 0,

        /// <summary>
        /// 赠送
        /// </summary>
        [Description("赠送")]
        Give = 1,

        /// <summary>
        /// 提现
        /// </summary>
        [Description("提现")]
        Withdraw = 2,

        /// <summary>
        /// 使用
        /// </summary>
        [Description("使用")]
        Used = 3,

    }

}
