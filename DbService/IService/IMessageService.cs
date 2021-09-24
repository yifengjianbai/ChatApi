using DbService.IService;
using DbService.Models;
using System.Collections.Generic;

namespace DbService.Service
{
    /// <summary>
    /// 聊天消息记录
    /// </summary>
    public interface IMessageService : IRpService
    {
        /// <summary>
        /// 获取离线消息
        /// </summary>
        /// <param name="userId"></param>
        /// <returns></returns>
        List<RpChatOfflineMsg> GetOfflineMsg(string userId);

        /// <summary>
        /// 获取已读消息记录
        /// </summary>
        /// <param name="userId"></param>
        /// <returns></returns>
        List<RpChatReadFlag> GetReadOfflineMsg(string userId);

        /// <summary>
        /// 删除离线消息
        /// </summary>
        /// <param name="rpChatOfflineMsgs"></param>
        void RemoveOfflineMsg(List<RpChatOfflineMsg> rpChatOfflineMsgs);

        /// <summary>
        /// 保存离线已读记录
        /// </summary>
        /// <param name="rpChatReadFlags"></param>
        void RemoveReadOfflineMsg(List<RpChatReadFlag> rpChatReadFlags);

        /// <summary>
        /// 保存离线消息
        /// </summary>
        /// <param name="rpChatOfflineMsg"></param>
        /// <returns></returns>
        bool SaveOfflineMsg(RpChatOfflineMsg rpChatOfflineMsg);

        /// <summary>
        /// 保存离线已读消息
        /// </summary>
        /// <param name="rpChatReadFlag"></param>
        /// <returns></returns>
        bool SaveReadOfflineMsg(RpChatReadFlag rpChatReadFlag);
    }
}