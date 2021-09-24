using DbService.IService;
using System.Threading.Tasks;

namespace DbService.IService
{
    /// <summary>
    /// 聊天服务接口
    /// </summary>
    public interface IChatService: IRpService
    {
        Task<int> GetWeekChatCount(string userId);
    
    }
}
