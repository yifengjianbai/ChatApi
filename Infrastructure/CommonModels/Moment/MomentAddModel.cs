using Infrastructure.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infrastructure.CommonModels.Moment
{
    /// <summary>
    /// 动态添加类型
    /// </summary>
    public class MomentAddModel
    {
        /// <summary>
        /// 动态id
        /// </summary>
        public string MomentId { get; set; }
        /// <summary>
        /// 用户Id
        /// </summary>
        public string UserId { get; set; }

        /// <summary>
        /// 内容
        /// </summary>
        public string Content { get; set; }

        /// <summary>
        /// 是否置顶
        /// </summary>
        public bool OnTop { get; set; }

        /// <summary>
        /// 可见范围
        /// </summary>
        public MomentScope Scope { get; set; }

        /// <summary>
        /// 是否匿名发布
        /// </summary>
        public bool IsAnonymous { get; set; }
 
        /// <summary>
        /// @用户
        /// </summary>
        public string AtUserIds { get; set; }

        /// <summary>
        /// 关联的愿望Id
        /// </summary>
        public string AtWishId { get; set; }

        /// <summary>
        /// 所在城市
        /// </summary>
        public string City { get; set; }

        /// <summary>
        /// 用户定位
        /// </summary>
        public string UserLocation { get; set; }

        /// <summary>
        /// 用户GPS地址
        /// 记录经纬度：1231.0098,2342.123
        /// </summary>
        public string GpsInfo { get; set; }

        /// <summary>
        /// 动态分类
        /// </summary>
        public MomentType MomentType { get; set; }

      
        /// <summary>
        /// 是否免费发布
        /// </summary>
        public bool IsFree { get; set; }


        /// <summary>
        /// 是否vip动态
        /// </summary>
        public bool IsVipMoment { get; set; }


        /// <summary>
        /// 是否有附件
        /// </summary>
        public bool HasAttath { get; set; }

        /// <summary>
        /// 附件
        /// </summary>
        public ICollection<Attachment> Attachments { get; set; }
    }

    /// <summary>
    /// 附件信息
    /// </summary>
    public class Attachment
    {
       /// <summary>
       /// 附件类型
       /// </summary>
        public  MediaType MediaType { get; set; }

        /// <summary>
        /// 附件地址
        /// </summary>
        public string MediaUrl { get; set; }

        /// <summary>
        /// 主题id
        /// </summary>
        public string TopicId { get; set; }

        /// <summary>
        /// 主题类型
        /// </summary>
        public TopicType TopicType { get; set; }
    }



    public class MomentQuery
    {

        /// <summary>
        /// 动态列表分类
        /// </summary>
        public MomentListType ListType { get; set; }

        /// <summary>
        /// 当前用户Id
        /// </summary>
        public string CurrentUserId { get; set; }

    }


}
