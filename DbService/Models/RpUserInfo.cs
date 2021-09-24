using System;
using System.Collections.Generic;

#nullable disable

namespace DbService.Models
{
    public partial class RpUserInfo
    {
        public RpUserInfo()
        {
            RpAccountChangings = new HashSet<RpAccountChanging>();
            RpChatOfflineMsgs = new HashSet<RpChatOfflineMsg>();
            RpChatReadFlags = new HashSet<RpChatReadFlag>();
            RpChatUnlocks = new HashSet<RpChatUnlock>();
            RpCoinCharges = new HashSet<RpCoinCharge>();
            RpGoodsShoppings = new HashSet<RpGoodsShopping>();
            RpGrowthBadges = new HashSet<RpGrowthBadge>();
            RpGrowthCoinConverts = new HashSet<RpGrowthCoinConvert>();
            RpGrowthExperiences = new HashSet<RpGrowthExperience>();
            RpGrowthUpgrades = new HashSet<RpGrowthUpgrade>();
            RpMomentInfos = new HashSet<RpMomentInfo>();
            RpShareRecords = new HashSet<RpShareRecord>();
            RpUserAccounts = new HashSet<RpUserAccount>();
            RpUserBadges = new HashSet<RpUserBadge>();
            RpUserBags = new HashSet<RpUserBag>();
            RpUserFolloweds = new HashSet<RpUserFollowed>();
            RpUserMeetUps = new HashSet<RpUserMeetUp>();
            RpUserNotifies = new HashSet<RpUserNotify>();
            RpUserTracks = new HashSet<RpUserTrack>();
            RpVipUserCharges = new HashSet<RpVipUserCharge>();
            RpVipUserInfos = new HashSet<RpVipUserInfo>();
            RpVipUserRequires = new HashSet<RpVipUserRequire>();
            RpWishLists = new HashSet<RpWishList>();
        }

        public string UserId { get; set; }
        public long UserNum { get; set; }
        public string Phone { get; set; }
        public string NickName { get; set; }
        public string AvatarUrl { get; set; }
        public DateTime Birthday { get; set; }
        public byte Age { get; set; }
        public byte Genders { get; set; }
        public string UserTags { get; set; }
        public bool IsVip { get; set; }
        public short UserStatus { get; set; }
        public DateTime RegistTime { get; set; }
        public DateTime LastUpdate { get; set; }
        public string Password { get; set; }
        public string InviteUserId { get; set; }
        public string Memo { get; set; }
        public bool IsOnline { get; set; }
        public DateTime? LoginTime { get; set; }
        public string WeChatOpenId { get; set; }

        public virtual ICollection<RpAccountChanging> RpAccountChangings { get; set; }
        public virtual ICollection<RpChatOfflineMsg> RpChatOfflineMsgs { get; set; }
        public virtual ICollection<RpChatReadFlag> RpChatReadFlags { get; set; }
        public virtual ICollection<RpChatUnlock> RpChatUnlocks { get; set; }
        public virtual ICollection<RpCoinCharge> RpCoinCharges { get; set; }
        public virtual ICollection<RpGoodsShopping> RpGoodsShoppings { get; set; }
        public virtual ICollection<RpGrowthBadge> RpGrowthBadges { get; set; }
        public virtual ICollection<RpGrowthCoinConvert> RpGrowthCoinConverts { get; set; }
        public virtual ICollection<RpGrowthExperience> RpGrowthExperiences { get; set; }
        public virtual ICollection<RpGrowthUpgrade> RpGrowthUpgrades { get; set; }
        public virtual ICollection<RpMomentInfo> RpMomentInfos { get; set; }
        public virtual ICollection<RpShareRecord> RpShareRecords { get; set; }
        public virtual ICollection<RpUserAccount> RpUserAccounts { get; set; }
        public virtual ICollection<RpUserBadge> RpUserBadges { get; set; }
        public virtual ICollection<RpUserBag> RpUserBags { get; set; }
        public virtual ICollection<RpUserFollowed> RpUserFolloweds { get; set; }
        public virtual ICollection<RpUserMeetUp> RpUserMeetUps { get; set; }
        public virtual ICollection<RpUserNotify> RpUserNotifies { get; set; }
        public virtual ICollection<RpUserTrack> RpUserTracks { get; set; }
        public virtual ICollection<RpVipUserCharge> RpVipUserCharges { get; set; }
        public virtual ICollection<RpVipUserInfo> RpVipUserInfos { get; set; }
        public virtual ICollection<RpVipUserRequire> RpVipUserRequires { get; set; }
        public virtual ICollection<RpWishList> RpWishLists { get; set; }
    }
}
