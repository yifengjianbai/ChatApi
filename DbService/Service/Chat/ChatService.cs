using DbService.IService;
using DbService.Models;
using DbService.Repositories;
using Infrastructure.Helpers;
using System.Threading.Tasks;

namespace DbService.Service
{
    public class ChatService : IChatService
    {

        private readonly IRpRepository<RpChatUnlock> _chatRepo;

        public ChatService(IRpRepository<RpChatUnlock> chatRepo)
        {
            _chatRepo = chatRepo;
        }

        /// <summary>
        /// 本周解锁私聊对象数目
        /// </summary>
        /// <param name="userId"></param>
        /// <returns></returns>
        public async Task<int> GetWeekChatCount(string userId)
        {
            return await _chatRepo.CountAsync(x => x.CreateTime > UtilHelper.WeekStartTime && x.UserId.Equals(userId));
        }
    }
}
