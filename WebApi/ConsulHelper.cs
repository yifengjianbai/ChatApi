using Consul;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebApi
{
    public static class ConsulHelper
    {
        public static async void RegistServer(this IConfiguration configuration, IServiceCollection serviceCollection)
        {
            string address = ((ConfigurationSection)configuration.GetSection("AppSetting:ServiceDiscoveryUrl")).Value;
            ConsulClient consulClient = new ConsulClient(c =>
            {
                c.Address = new Uri(address);
            });

            serviceCollection.AddSingleton(consulClient);

            string ip = configuration["ip"];
            int port = int.Parse(configuration["port"]);

            await consulClient.Agent.ServiceRegister(new AgentServiceRegistration()
            {
                ID = $"{ip}:{port}",
                Name = "ChatApi",
                Address = ip,
                Port = port,
                //健康检查
                Check = new AgentServiceCheck()
                {
                    Interval = TimeSpan.FromSeconds(10),
                    HTTP = $"http://{ip}:{port}/api/Login/Check",
                    Timeout = TimeSpan.FromSeconds(5),
                    DeregisterCriticalServiceAfter = TimeSpan.FromSeconds(20)
                }
            });
        }
    }
}
