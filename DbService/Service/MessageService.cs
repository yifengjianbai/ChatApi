using DbService.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DbService.Service
{
    /// <summary>
    /// 聊天模块DbService
    /// </summary>
    public class MessageService : IMessageService
    {
        private RpDbContext _dbContext;

        public MessageService(RpDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        /// <summary>
        /// 保存离线消息
        /// </summary>
        /// <param name="rpChatOfflineMsg"></param>
        /// <returns></returns>
        public bool SaveOfflineMsg(RpChatOfflineMsg rpChatOfflineMsg)
        {
            _dbContext.RpChatOfflineMsgs.Add(rpChatOfflineMsg);
            return _dbContext.SaveChanges() > 0;
        }

        /// <summary>
        /// 获取离线消息
        /// </summary>
        /// <param name="userId"></param>
        /// <returns></returns>
        public List<RpChatOfflineMsg> GetOfflineMsg(string userId)
        {
            return _dbContext.RpChatOfflineMsgs.Where(om => om.FriendId == userId).ToList();
        }

        /// <summary>
        /// 删除离线消息
        /// </summary>
        /// <param name="rpChatOfflineMsgs"></param>
        public void RemoveOfflineMsg(List<RpChatOfflineMsg> rpChatOfflineMsgs)
        {
            _dbContext.RpChatOfflineMsgs.RemoveRange(rpChatOfflineMsgs);
        }

        /// <summary>
        /// 保存离线已读记录
        /// </summary>
        /// <param name="rpChatReadFlag"></param>
        /// <returns></returns>
        public bool SaveReadOfflineMsg(RpChatReadFlag rpChatReadFlag)
        {
            _dbContext.RpChatReadFlags.Add(rpChatReadFlag);
            return _dbContext.SaveChanges() > 0;
        }

        /// <summary>
        /// 获取离线已读记录
        /// </summary>
        /// <param name="userId"></param>
        /// <returns></returns>
        public List<RpChatReadFlag> GetReadOfflineMsg(string userId)
        {
            return _dbContext.RpChatReadFlags.Where(om => om.UserId == userId).ToList();
        }

        /// <summary>
        /// 删除离线已读记录
        /// </summary>
        /// <param name="rpChatOfflineMsgs"></param>
        public void RemoveReadOfflineMsg(List<RpChatReadFlag> rpChatReadFlags)
        {
            _dbContext.RpChatReadFlags.RemoveRange(rpChatReadFlags);
        }
    }
}
