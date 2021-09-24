using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Ocelot.DependencyInjection;
using Ocelot.Middleware;
using Ocelot.Provider.Consul;
using Ocelot.Cache.CacheManager;
using Ocelot.Cache;
using GateWay;
using Ocelot.Provider.Polly;
using IdentityServer4.AccessTokenValidation;
using Microsoft.IdentityModel.Tokens;
using IdentityServer4.Configuration;

namespace GetWay
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
            RedisHelper.SetConnection(configuration["DbConnection:Redis"]);
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            //��֤
            var authenticationProviderKey = "oct";
            services.AddAuthentication()
                .AddJwtBearer(authenticationProviderKey, x =>
                {
                    x.Authority = "http://localhost:5000";
                    x.RequireHttpsMetadata = false;
                    x.TokenValidationParameters = new TokenValidationParameters
                    {
                        ValidateAudience = false
                    };
                });

            services
                .AddOcelot()
                .AddConsul()//ʹ��Consul
                .AddCacheManager(x =>//ʹ�û���
                {
                    x.WithDictionaryHandle();
                })
                .AddPolly();//polly���������۶ϡ����������Եȵ�

            //ʹ���Զ��建�棬��������WithDictionaryHandle
            services.AddSingleton<IOcelotCache<CachedResponse>, OcelotCacheExtension>();
            services.AddControllers();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            app.UseOcelot();//���ocelot�м��
            //if (env.IsDevelopment())
            //{
            //    app.UseDeveloperExceptionPage();
            //}

            //app.UseHttpsRedirection();

            //app.UseRouting();

            //app.UseAuthorization();

            //app.UseEndpoints(endpoints =>
            //{
            //    endpoints.MapControllers();
            //});
        }
    }
}
