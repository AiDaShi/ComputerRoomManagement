using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ComputerRoomManagement.DTOModel;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Caching.Distributed;
using Microsoft.Extensions.Logging;
using StackExchange.Redis;

namespace ComputerRoomManagement.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SettingController : ControllerBase
    {
        private readonly IDatabase _db;
        private readonly ILogger<HomeController> _logger;
        
        public SettingController(ILogger<HomeController> logger, IConnectionMultiplexer redis)
        {
            _db = redis.GetDatabase();
            _logger = logger;
        }

        [HttpPost]
        public async Task<ResposeName<string>> AddName(string Name)
        {
            var UserSortedSet =await _db.SortedSetRangeByRankAsync("ComputerName",0,-1);
            ResposeName<string> RS = new ResposeName<string>();
            foreach (var item in UserSortedSet)
            {
                if (item.ToString()==Name)
                {
                    RS.code = 404;
                    RS.msg = $"The ComputerName {Name} is exist!!!";
                    return RS;
                }
            }
            int i = 0;
            if (UserSortedSet!=null)
            {
                i = UserSortedSet.Length;
            }
            _db.SortedSetAdd("ComputerName", Name, i);
            RS.code = 200;
            RS.data = Name;
            return RS;
        }


        [HttpGet("AllName")]
        public async Task<ResposeName<List<RedisValue>>> AllName()
        {
            var UserSortedSet = await _db.SortedSetRangeByRankAsync("ComputerName", 0, -1);
            ResposeName<List<RedisValue>> RS = new ResposeName<List<RedisValue>>();
            RS.code = 200;
            RS.data = UserSortedSet.ToList();
            return RS;
        }



    }
}