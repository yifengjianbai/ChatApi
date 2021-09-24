using System.ComponentModel;

namespace Infrastructure.Enums
{
    /// <summary>
    /// 愿望状态
    /// </summary>
    public enum WishStatus
    {
        /// <summary>
        /// 草稿
        /// </summary>
        [Description("草稿")]
        Draft = 0,

        /// <summary>
        /// 已发布
        /// </summary>
        [Description("已发布")]
        Published = 1,

        /// <summary>
        /// 进行中
        /// </summary>
        [Description("进行中")]
        Going = 2,

        /// <summary>
        /// 完成
        /// </summary>
        [Description("完成")]
        Accomplish = 3,

        /// <summary>
        /// 撤销
        /// </summary>
        [Description("撤销")]
        revocation = 4,
    }

}
