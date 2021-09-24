using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Autofac.Extensions.DependencyInjection;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using NLog.Web;

namespace WebApi
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
         Host.CreateDefaultBuilder(args)
             .UseServiceProviderFactory(new AutofacServiceProviderFactory()) //将默认ServiceProviderFactory指定为AutofacServiceProviderFactory
             .ConfigureWebHostDefaults(webBuilder =>
             {
                 webBuilder.UseUrls(args[2]).UseStartup<Startup>();
                 //webBuilder.UseStartup<Startup>();
                
             }).UseNLog();

    }
}
