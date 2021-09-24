using DbService.Models;
using Infrastructure.Enums;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DbService.IService.SystemSetting
{
    public interface IBagService : IRpService
    {
  
        /// <summary>
        /// 取出
        /// </summary>
        /// <param name="goods"></param>
        /// <param name="userId"></param>
        /// <param name="topicId"></param>
        /// <param name="topicType"></param>
        /// <returns></returns>
        Task TakeOutUnCommitAsync(RpGoodsSell goods, string userId, string donorId, string topicId, TopicType topicType, DateTime time);

        /// <summary>
        /// 存入
        /// </summary>
        /// <param name="goods"></param>
        /// <param name="userId"></param>
        /// <param name="topicId"></param>
        /// <param name="topicType"></param>
        /// <returns></returns>
        Task PutInUnCommitAsync(RpGoodsSell goods, string userId, string donorId, string topicId, TopicType topicType, DateTime time);
    }
}
