using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ComputerRoomManagement.Controllers;
using ComputerRoomManagement.Filters;
using ComputerRoomManagement.Hubs;
using ComputerRoomManagement.Services;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Cors.Infrastructure;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.StaticFiles;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using StackExchange.Redis;

namespace ComputerRoomManagement
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
            services.AddControllersWithViews();

            #region 添加Filter

            services.AddSingleton<GlobalFilter>();

            #endregion

            #region solenovex

            services.AddSingleton<CountService>();

            //services.AddSignalR()
                //.AddMessagePackProtocol();




            #endregion

            ////注入SignalR实时通讯，默认用json传输
            services.AddSignalR(options =>
            {
                //客户端发保持连接请求到服务端最长间隔，默认30秒，改成4分钟，网页需跟着设置connection.keepAliveIntervalInMilliseconds = 12e4;即2分钟
                options.ClientTimeoutInterval = TimeSpan.FromMinutes(4);
                //服务端发保持连接请求到客户端间隔，默认15秒，改成2分钟，网页需跟着设置connection.serverTimeoutInMilliseconds = 24e4;即4分钟
                options.KeepAliveInterval = TimeSpan.FromMinutes(2);
            }).AddMessagePackProtocol();
            //注入跨域
            services.AddCors(option => option.AddPolicy("cors",
                policy => policy.AllowAnyHeader().AllowAnyMethod().AllowCredentials()
                    .WithOrigins("http://localhost:8001", "http://localhost:8000", "http://localhost:8002")));

            #region Redis普通建立连接

            //services.AddSingleton<ConnectionMultiplexer>(ConnectionMultiplexer.Connect("localhost"));

            #endregion

            #region Redis

            services.AddSingleton<IConnectionMultiplexer>(ConnectionMultiplexer.Connect("120.79.219.156:6379"));
            services.AddDistributedRedisCache(option =>
            {
                option.Configuration = "120.79.219.156";
                //实例名称
                option.InstanceName = "RedisDemoInstance";
            });

            #endregion



        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            //添加WebSocket支持，SignalR优先使用WebSocket传输
            app.UseWebSockets();
            //app.UseWebSockets(new WebSocketOptions
            //{
            //    //发送保持连接请求的时间间隔，默认2分钟
            //    KeepAliveInterval = TimeSpan.FromMinutes(2)
            //});

            //app.UseSignalR()

            app.UseHttpsRedirection();

            #region 添加静态枚举

            var provider = new FileExtensionContentTypeProvider();
            provider.Mappings[".json"] = "application/json";

            #endregion
            app.UseStaticFiles(new StaticFileOptions()
            {
                ContentTypeProvider = provider
            });

            app.UseRouting();

            app.UseAuthorization();
            //app.UseCors();
            //允许跨域，不支持向所有域名开放了，会有错误提示
            app.UseCors("cors");

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");

                endpoints.MapHub<CountHub>("/count");
            });
        }
    }
}
