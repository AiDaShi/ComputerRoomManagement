using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ComputerRoomManagement.Controllers;
using Microsoft.Extensions.Caching.Distributed;
using Microsoft.Extensions.Logging;
using StackExchange.Redis;

namespace ComputerRoomManagement.ViewComponents
{
    public class CounterViewComponent:ViewComponent
    {

        private readonly IConnectionMultiplexer _redis;
        private readonly IDistributedCache _distributedCache;
        private readonly IDatabase _db;
        private readonly ILogger<HomeController> _logger;
        public CounterViewComponent(ILogger<HomeController> logger, IConnectionMultiplexer redis, IDistributedCache distributedCache)
        {
            //分布式缓存使用方式
            _distributedCache = distributedCache;
            //非分布式缓存使用方式
            _redis = redis;
            _db = _redis.GetDatabase();
            _logger = logger;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var controller = RouteData.Values["controller"].ToString();
            var action = RouteData.Values["action"].ToString();
            if (!string.IsNullOrWhiteSpace(controller) && !string.IsNullOrWhiteSpace(action))
            {
                var pageId = $"{controller}-{action}";
                _db.StringIncrement(pageId);
                var count =await _db.StringGetAsync(pageId);
                return View("Default", pageId +": "+ count);
                
            }
            throw new  Exception("Cannot get pageId");
        }
    }
}
