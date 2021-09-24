using System.ComponentModel;

namespace Infrastructure.Enums
{
    public enum UserStatus
    {

        [Description("正常")]
        Normal = 1,

        [Description("禁用")]
        Forbidden = 2,

        [Description("达人过期")]

        Expired = 3,
    }

}
