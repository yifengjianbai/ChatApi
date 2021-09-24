using System.ComponentModel;

namespace Infrastructure.Enums
{
    /// <summary>
    /// 分享类型
    /// </summary>
    public enum ShareType
    {
        /// <summary>
        /// 微信好友
        /// </summary>
        [Description("微信好友")]
        WeChatFriend = 1,

        /// <summary>
        /// 微信朋友圈
        /// </summary>
        [Description("微信朋友圈")]
        WeChatMoment = 2,

        /// <summary>
        /// 红笺App
        /// </summary>
        [Description("红笺App")]
        RedPaperApp = 3,


    }

    /// <summary>
    /// 分享主题类型
    /// </summary>
    public enum ShareTopicType
    {
        /// <summary>
        /// 动态
        /// </summary>
        [Description("动态")]
        Mement = 0,

        /// <summary>
        /// 愿望
        /// </summary>
        [Description("愿望")]
        Wish = 1,

        /// <summary>
        /// 周报
        /// </summary>
        [Description("周报")]
        Report = 2,

        /// <summary>
        /// 邀请好友
        /// </summary>
        [Description("邀请好友")]
        Invite = 3
    }
}
