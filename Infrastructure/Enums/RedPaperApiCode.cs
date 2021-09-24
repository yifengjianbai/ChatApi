using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace Infrastructure.Enums
{
    /// <summary>
    /// 自定义api返回码
    /// </summary>
    public enum RedPaperApiCode
    {

        /// <summary>
        /// 请求成功
        /// </summary>
        [Description("请求成功")]
        Success = 200,

        /// <summary>
        /// 开发者权限不足
        /// </summary>
        [Description("开发者权限不足")]
        Insufficient_ISV_Permissions = 1,

        /// <summary>
        /// 用户权限不足
        /// </summary>
        [Description("用户权限不足")]
        Insufficient_User_Permissions = 2,

        /// <summary>
        /// 远程服务错误
        /// </summary>
        [Description("远程服务出错")]
        Remote_Service_Error = 3,

        /// <summary>
        /// 缺少方法名参数
        /// </summary>
        [Description("缺少方法名参数")]
        Missing_Method = 4,

        /// <summary>
        /// 不存在的方法名
        /// </summary>
        [Description("不存在的方法名")]
        Invalid_Method = 5,

        /// <summary>
        /// 非法数据格式
        /// </summary>
        [Description("非法数据格式")]
        Invalid_Format = 6,

        /// <summary>
        /// 缺少签名参数
        /// </summary>
        [Description("缺少签名参数")]
        Missing_Signature = 7,

        /// <summary>
        /// 非法签名
        /// </summary>
        [Description("非法签名")]
        Invalid_Signature = 8,

        /// <summary>
        /// 错误参数
        /// </summary>
        [Description("错误参数")]
        Error_Param = 9,


        /// <summary>
        /// 服务错误
        /// </summary>
        [Description("服务错误")]
        Server_Error = 10,

       
    }
}
