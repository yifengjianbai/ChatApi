using Autofac;
using DbService;
using Infrastructure.CommonModels;
using Infrastructure.Helpers;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.IdentityModel.Tokens;
using Microsoft.OpenApi.Models;
using Swashbuckle.AspNetCore.SwaggerUI;
using System;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using WebApi.MiddleWare;

namespace WebApi
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);
            services.AddControllers();

            //ע���Ȩ��Ȩ,ids4
            services.AddAuthentication("Bearer")
            .AddJwtBearer("Bearer", options =>
            {
                string address = ((ConfigurationSection)Configuration.GetSection("AppSetting:IdentityServerUrl")).Value;
                options.Authority = address;
                options.RequireHttpsMetadata = false;
                //options.Audience = "scope3";
                options.TokenValidationParameters = new TokenValidationParameters
                {
                    ValidateAudience = false
                };
            });

            //ע�����ݿ������ַ���
            var connection = Configuration["DbConnection:SqlServer"];
            RpDbContext.ConnectStr = connection;
            services.AddDbContext<RpDbContext>(options => options.UseSqlServer(connection));


            //services.AddAuthorization(options =>
            //{
            //    options.AddPolicy("ApiScope", policy =>
            //    {
            //        policy.RequireAuthenticatedUser();
            //        policy.RequireClaim("scope", "scope1");
            //    });
            //});

            services.AddSwaggerGen(option =>
            {
                option.SwaggerDoc("v1", new OpenApiInfo
                {
                    Version = "v1",
                    Title = "ChatApi",
                    Description = "hardman tech"
                });

                //// ��ȡxml�ļ���
                //var xmlFile = $"{Assembly.GetExecutingAssembly().GetName().Name}.xml";
                //// ��ȡxml�ļ�·��
                //var xmlPath = Path.Combine(AppContext.BaseDirectory, xmlFile);
                //option.IncludeXmlComments(xmlPath, true);
                foreach (var name in Directory.GetFiles(AppContext.BaseDirectory, "*.*",
                    SearchOption.AllDirectories).Where(f => Path.GetExtension(f).ToLower() == ".xml"))
                {
                    option.IncludeXmlComments(name, includeControllerXmlComments: true);
                }
            });

            //services.AddMvc(options =>
            //{
            //    options.Filters.Add<DistributeLockFilter>();
            //});

            //ע��ֲ�ʽ������
            services.AddSingleton<DistributeLockFilter>();

            services.AddAutoMapper(typeof(AutoMapperProfile));

            //����redis����
            RedisHelper.SetConnection(Configuration["DbConnection:Redis"]);

       

            Configuration.RegistServer(services);
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            //Console.WriteLine($"�����ɹ����ӿڷ��ʵ�ַ:{conf["urls"].TrimEnd()}/swagger/index.html");

            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            //app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthentication();

            app.UseAuthorization();

            app.UseCustomExceptionMiddleware();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();//.RequireAuthorization("ApiScope");
            });

            app.UseSwagger();

           

            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "V1 Docs");
                c.DocExpansion(DocExpansion.None);
                c.OAuthClientId("RedPaperApi");  //oauth�ͻ�������
                c.OAuthAppName("RedPaper�ӿ�"); // ����
            });
        }

        /// <summary>
        /// IOCע��
        /// </summary>
        /// <param name="builder"></param>
        public void ConfigureContainer(ContainerBuilder builder)
        {
            AutofacExtensions.InitAutofac(builder);
        }


    }
}
