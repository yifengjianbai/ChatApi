using System.ComponentModel;

namespace Infrastructure.Enums
{
    /// <summary>
    /// 聊天信息内容类型
    /// </summary>
    public enum ContentType
    {

        [Description("文字")]
        Text = 1,

        [Description("图片")]
        Image = 2,

        [Description("音频")]
        Audio = 3,

        [Description("视频")]
        Video = 4
    }


}
