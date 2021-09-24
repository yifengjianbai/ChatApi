using Infrastructure.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infrastructure.CommonModels
{
    public class RegistUserInfo
    {
     
        /// <summary>
        /// 手机号码
        /// </summary>
        public string Phone { get; set; }

        /// <summary>
        /// 密码
        /// </summary>
        public string Password { get; set; }

        /// <summary>
        /// 昵称
        /// </summary>
        public string NickName { get; set; }

        /// <summary>
        /// 用户头像
        /// </summary>
        public string AvatarUrl { get; set; }

        /// <summary>
        /// 性别
        /// </summary>
        public GenderType Genders { get; set; }

        /// <summary>
        /// 生日
        /// </summary>
        public DateTime Birthday { get; set; }

        /// <summary>
        /// 年龄
        /// </summary>
        public int Age { get { return DateTime.Now.Year - Birthday.Year; } }

        /// <summary>
        /// 个性标签
        /// 格式：xxx,xxx,xxx,xx
        /// </summary>
        public string Tags { get; set; }

        /// <summary>
        /// 是否为达人
        /// </summary>
        public bool IsVip { get; set; }

        /// <summary>
        /// 持续时间
        /// 单位：天
        /// </summary>
        public int VipDuration { get; set; }


        /// <summary>
        /// 花费金额
        /// </summary>
        public decimal Fee { get; set; }



    }
}
