using Consul;
using Microsoft.AspNetCore.Mvc.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace WebApi.MiddleWare
{
    /// <summary>
    /// 自定义分布式锁过滤器
    /// </summary>
    public class DistributeLockFilter : IActionFilter
    {
        private ConsulClient _ConsulClient;
        public DistributeLockFilter(ConsulClient consulClient)
        {
            _ConsulClient = consulClient;
        }

        public void OnActionExecuting(ActionExecutingContext context)
        {
            var s = _ConsulClient.Session.Create().GetAwaiter().GetResult();
            KVPair kVPair = new KVPair(context.ActionDescriptor.ToString())
            {
                Value = Encoding.UTF8.GetBytes("distribute lock"),
                Session = s.Response
            };

            var kv = _ConsulClient.KV.Get(kVPair.Key).GetAwaiter().GetResult();
            if (kv.StatusCode == System.Net.HttpStatusCode.NotFound)
            {
                _ConsulClient.KV.Put(kVPair);
            }

            var res = _ConsulClient.KV.Acquire(kVPair).GetAwaiter().GetResult();
            while (!res.Response)
            {
                Thread.Sleep(50);
                res = _ConsulClient.KV.Acquire(kVPair).GetAwaiter().GetResult();
            }
        }

        public void OnActionExecuted(ActionExecutedContext context)
        {
            var kv = _ConsulClient.KV.Get(context.ActionDescriptor.ToString()).GetAwaiter().GetResult();
            _ConsulClient.KV.Release(kv.Response).GetAwaiter().GetResult();
        }
    }
}
