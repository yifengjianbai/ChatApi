using DbService.Models;
using Infrastructure.AutofacManager;
using Infrastructure.Enums;
using Infrastructure.Helpers;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DbService.Service.Experience
{
    public interface IExperienceAction : IDependency
    {
        /// <summary>
        /// 是否允许增加经验值
        /// </summary>
        /// <returns></returns>
        Task IncreaseUserExpAsync(RpUserInfo userInfo, ActionType expActionType);

    }

}
