using Infrastructure.CommonModels.User;
using Infrastructure.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infrastructure.CommonModels.Moment
{
    /// <summary>
    /// 动态输出模型
    /// </summary>
    public class MomentOutput : UserInfoOutput
    {
        /// <summary>
        /// 动态id
        /// </summary>
        public string MomentId { get; set; }

        /// <summary>
        /// 动态内容
        /// </summary>
        public string Content { get; set; }

        /// <summary>
        /// 内容分类
        /// </summary>
        public MomentType MomentType { get; set; }

        /// <summary>
        /// 是否匿名
        /// </summary>
        public bool IsAnonymous { get; set; }

        /// <summary>
        /// 打赏礼物数量
        /// </summary>
        public int GiftCount { get; set; }

        /// <summary>
        /// 点在数量
        /// </summary>
        public int LikeCount { get; set; }

        /// <summary>
        /// 访问次数
        /// </summary>
        public int VisitCount { get; set; }


        /// <summary>
        /// @用户
        /// </summary>
        public List<UserInfoOutput> AtUserInfos { get; set; }

        /// <summary>
        /// 关联的愿望
        /// </summary>
        public string AtWishId { get; set; }

        /// <summary>
        /// 关联的愿望名称
        /// </summary>
        public string AtWishName { get; set; }

        /// <summary>
        /// 所在的城市
        /// </summary>
        public string City { get; set; }
   
        /// <summary>
        /// 创建时间
        /// </summary>
        public DateTime CreateTime { get; set; }

        /// <summary>
        /// 是否有附件
        /// </summary>
        public bool HasAttath { get; set; }

        /// <summary>
        /// 是否是达人动态
        /// </summary>
        public bool IsVipMoment { get; set; }

    }
}
