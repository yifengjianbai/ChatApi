using Infrastructure.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infrastructure.CommonModels.Wish
{
    /// <summary>
    /// 愿望添加模型
    /// </summary>
    public class WishAddModel
    {
        /// <summary>
        /// 愿望id
        /// </summary>
        public string WishId { get; set; }
        /// <summary>
        /// 愿望名称
        /// </summary>
        public string WishName { get; set; }
        /// <summary>
        /// 愿望描述
        /// </summary>
        public string WishDesc { get; set; }

        /// <summary>
        /// 愿望文本类型
        /// </summary>
        public ContentType WishDescType { get; set; }

        /// <summary>
        /// 实现方式
        /// </summary>
        public RealizeType RealizeType { get; set; }

        /// <summary>
        /// 指定实现人
        /// </summary>
        public string RealizeUser { get; set; }

        /// <summary>
        /// 礼物编号
        /// </summary>
        public string GiftCode { get; set; }

        /// <summary>
        /// 礼物名称
        /// </summary>
        public string GiftName { get; set; }

        /// <summary>
        /// 礼物图片
        /// </summary>
        public string GiftPicUrl { get; set; }

        /// <summary>
        /// 礼物价值
        /// </summary>
        public int GiftValue { get; set; }

        /// <summary>
        /// 愿望状态
        /// </summary>
        public WishStatus WishStatus { get; set; }

   
        /// <summary>
        /// 创建用户
        /// </summary>
        public string UserId { get; set; }

        /// <summary>
        /// 愿望分类
        /// </summary>
        public string WishCatalog { get; set; }

        /// <summary>
        /// 使用使用免费次数
        /// </summary>
        public bool IsFree { get; set; }
    }
}
