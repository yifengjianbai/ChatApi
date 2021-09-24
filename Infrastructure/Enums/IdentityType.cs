using System.ComponentModel;

namespace Infrastructure.Enums
{
    /// <summary>
    /// 身份
    /// </summary>
    public enum IdentityType
    {
        [Description("素人")]
        Normal = 0,

        [Description("达人")]
        Vip = 1
    }
}
