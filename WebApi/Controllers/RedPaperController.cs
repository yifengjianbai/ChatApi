using Infrastructure;
using Infrastructure.Enums;
using Microsoft.AspNetCore.Mvc;
using WebApi.Models.Response;

namespace WebApi.Controllers
{
    /// <summary>
    /// 基础控制器
    /// </summary>
    [ApiController]
    public class RedPaperController : ControllerBase
    {
        /// <summary>
        /// 成功反馈
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="data"></param>
        /// <param name="msg"></param>
        /// <returns></returns>
        protected virtual ResponseBase<T> Success<T>(T data = default(T), string msg = "")
        {
            var result = new ResponseBase<T>()
            {
                Message = RedPaperApiCode.Success.GetDescription(),
                Code = (int)RedPaperApiCode.Success,
                Result = data
            };
            return result;

        }

        /// <summary>
        /// 失败反馈
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="msg"></param>
        /// <param name="code"></param>
        /// <param name="data"></param>
        /// <returns></returns>
        protected virtual ResponseBase<T> Fail<T>(string msg = "", int code = 0, T data = default(T))
        {
            var result = new ResponseBase<T>()
            {
                Code = code,
                Message = msg,
                Result = data
            };
            return result;
        }

    }
}
