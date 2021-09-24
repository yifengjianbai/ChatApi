using System.ComponentModel;

namespace Infrastructure.Enums
{
    /// <summary>
    /// 附件类型
    /// </summary>
    public enum MediaType
    {
        [Description("文字")]
        Text = 1,

        [Description("图片")]
        Image = 2,

        [Description("音频")]
        Audio = 3,

        [Description("视频")]
        Video = 4,

        [Description("红笺卡片")]
        Card = 5,

    }
}
