using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using StackExchange.Redis;

namespace ComputerRoomManagement
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var host = CreateHostBuilder(args).Build();
            var GloablePullWorkFlowScope = host.Services.CreateScope();
            var _db = GloablePullWorkFlowScope.ServiceProvider.GetService<IConnectionMultiplexer>().GetDatabase();
            try
            {
                //初始化删除数据

                var UserSortedSet = _db.SortedSetRangeByRank("ComputerName", 0, -1);
                foreach (var child in UserSortedSet)
                {
                    var ComputerInfoList = _db.ListRange("List." + child.ToString(), 0, -1);
                    foreach (var item in ComputerInfoList)
                    {
                        _db.ListRemove("List." + child.ToString(), item);
                    }
                    _db.SortedSetRemove("ComputerName", child);
                }
            }
            catch (Exception e)
            {
                
            }
            host.Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}
