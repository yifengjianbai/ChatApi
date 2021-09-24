using Infrastructure.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infrastructure.CommonModels.User
{
    /// <summary>
    /// 用户信息
    /// </summary>
    public class UserInfoOutput
    {
        /// <summary>
        /// 用户id
        /// </summary>
        public string UserId { get; set; }

        /// <summary>
        /// 昵称
        /// </summary>
        public string Nickname { get; set; }

        /// <summary>
        /// 头像
        /// </summary>
        public string AvatarUrl { get; set; }

        /// <summary>
        /// 性别
        /// </summary>
        public GenderType Genders { get; set; }


        /// <summary>
        /// 是否达人
        /// </summary>
        public bool IsVip { get; set; }
    }

}
