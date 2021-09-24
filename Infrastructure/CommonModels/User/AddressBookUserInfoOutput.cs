namespace Infrastructure.CommonModels.User
{
    /// <summary>
    /// 通讯录用户信息
    /// </summary>
    public class AddressBookUserInfoOutput : UserInfoOutput
    { 
        /// <summary>
        /// 是否关注
        /// </summary>
        public bool IsFollowed { get; set; }

        /// <summary>
        /// 是否在线
        /// </summary>
        public bool IsOnline { get; set; }
    }


}
