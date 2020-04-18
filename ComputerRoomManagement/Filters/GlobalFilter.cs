using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ComputerRoomManagement.Controllers;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.Extensions.Logging;
using StackExchange.Redis;

namespace ComputerRoomManagement.Filters
{
    public class GlobalFilter : Attribute, IActionFilter
    {
        private readonly IDatabase _db;
        private readonly ILogger<HomeController> _logger;

        public GlobalFilter(ILogger<HomeController> logger, IConnectionMultiplexer redis)
        {
            _db = redis.GetDatabase();
            _logger = logger;
        }
        public void OnActionExecuted(ActionExecutedContext context)
        {

        }

        public void OnActionExecuting(ActionExecutingContext context)
        {
            var controller = context.RouteData.Values["controller"].ToString();
            if (controller.ToLower() == "health")
            {
                var UserSortedSet = _db.SortedSetRangeByRank("ComputerName", 0, -1);
                string name = context.HttpContext.Request.Form["Name"];
                RedisValue TheOneUser = UserSortedSet.FirstOrDefault(x => x.ToString() == name);
                if (TheOneUser.IsNull)
                {
                    _logger.LogError("");

                    context.Result = new RedirectResult("/Error/401");
                    return;
                }
            }
        }
    }
}
