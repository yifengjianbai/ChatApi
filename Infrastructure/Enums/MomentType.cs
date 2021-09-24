using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace Infrastructure.Enums
{
    /// <summary>
    /// 动态类型
    /// </summary>
    public enum MomentType
    {
        [Description("图文")]
        ImageText = 0,

        [Description("音频")]
        Audio = 1,

        [Description("视频")]
        Video = 2
    }

    /// <summary>
    /// 动态范围
    /// </summary>
    public enum MomentScope
    {
        [Description("所有人可见")]
        All = 0,

        [Description("仅好友可见")]
        Follower = 1,

        [Description("仅自己可见")]
        Self = 2
    }

    /// <summary>
    /// 动态分类
    /// </summary>
    public enum MomentListType
    {
        [Description("关注")]
        Followed = 0,

        [Description("推荐")]
        Recommend = 1,

        [Description("后台")]
        Web = 2
    }

}
