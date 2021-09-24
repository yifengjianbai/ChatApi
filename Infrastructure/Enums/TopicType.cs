using System.ComponentModel;

namespace Infrastructure.Enums
{
    /// <summary>
    /// 公共媒体主题类型
    /// </summary>
    public enum TopicType
    {
        [Description("动态")]
        Mement = 0,

        [Description("愿望")]
        Wish = 1,

        [Description("聊天信息")]
        ChatMsg = 2,

        [Description("个人主页")]
        Homepage = 3,
    }


}
