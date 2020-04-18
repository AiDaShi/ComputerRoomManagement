using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ComputerRoomManagement.DTOModel;
using ComputerRoomManagement.Filters;
using ComputerRoomManagement.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using StackExchange.Redis;

namespace ComputerRoomManagement.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HealthController : ControllerBase
    {
        private readonly IDatabase _db;
        private readonly ILogger<HomeController> _logger;

        public HealthController(ILogger<HomeController> logger, IConnectionMultiplexer redis)
        {
            _db = redis.GetDatabase();
            _logger = logger;
        }
        /// <summary>
        /// 获取所有信息
        /// </summary>
        /// <returns></returns>
        [HttpGet("GetAllComputerInfo")]
        public async Task<ResposeName<List<Computer<ComputerInfo>>>> GetAllComputerInfo()
        {

            List<Computer<ComputerInfo>> JsonConvertComputerInfoList = new List<Computer<ComputerInfo>>();
            ResposeName<List<Computer<ComputerInfo>>> RS = new ResposeName<List<Computer<ComputerInfo>>>();
            DateTime dateTime = DateTime.Now.AddSeconds(-10);
            try
            {
                var UserSortedSet = _db.SortedSetRangeByRank("ComputerName", 0, -1);
                foreach (var child in UserSortedSet)
                {
                    Computer<ComputerInfo> OneCC = new Computer<ComputerInfo>();
                    OneCC.Name = child.ToString();
                    
                    var ComputerInfoList = await _db.ListRangeAsync("List." + child.ToString(), 0, -1);
                    OneCC.Data = new List<ComputerInfo>();
                    foreach (var item in ComputerInfoList)
                    {
                        try
                        {
                            var one = JsonConvert.DeserializeObject<ComputerInfo>(item.ToString());
                            if (DateTime.Compare(one.Time, dateTime) > 0)
                            {
                                OneCC.Data.Add(one);
                                break;
                            }
                        }
                        catch (Exception e)
                        {
                            _logger.LogError(
                                $"/Health/GetAllComputerInfo Convert Json {item.ToString()} Error:{e.Message}");
                            continue;
                        }
                    }
                    JsonConvertComputerInfoList.Add(OneCC);
                }

                RS.code = 200;
                RS.data = JsonConvertComputerInfoList;

            }
            catch (Exception e)
            {
                _logger.LogError($"/Health/GetAllComputerInfo Very Important Error:{e.Message}");
                RS.code = 404;
                RS.msg = e.Message;
                RS.data = null;
            }
            return RS;
        }
        /// <summary>
        /// 添加单个信息
        /// </summary>
        /// <param name="computer"></param>
        /// <returns></returns>
        [HttpPost("AddMessage")]
        public Task<ResposeName<ComputerInfo>> AddMessage([FromBody] ComputerInfo computer)
        {
            ResposeName<ComputerInfo> RS = new ResposeName<ComputerInfo>();
            try
            {
                computer.Time = DateTime.Now;
                var jsonSR = JsonConvert.SerializeObject(computer);
                _db.ListLeftPush("List." + computer.Name, jsonSR);
                RS.code = 200;
                RS.data = computer;
            }
            catch (Exception e)
            {
                _logger.LogError($"/Health/GetOneByAllComputerInfo Very Important Error:{e.Message}");
                RS.code = 404;
                RS.msg = e.Message;
                RS.data = null;
            }
            return Task.FromResult(RS);
        }

        /// <summary>
        /// 获取单个信息
        /// </summary>
        /// <param name="computer"></param>
        /// <returns></returns>
        [ServiceFilter(typeof(GlobalFilter))]
        [HttpPost("GetOneByAllComputerInfo")]
        public async Task<ResposeName<List<ComputerInfo>>> GetOneByAllComputerInfo([FromForm] ComputerInfo computer)
        {

            List<ComputerInfo> JsonConvertComputerInfoList = new List<ComputerInfo>();
            ResposeName<List<ComputerInfo>> RS = new ResposeName<List<ComputerInfo>>();
            try
            {
                var ComputerInfoList = await _db.ListRangeAsync("List." + computer.Name, 0, -1);
                foreach (var item in ComputerInfoList)
                {
                    try
                    {
                        var one = JsonConvert.DeserializeObject<ComputerInfo>(item.ToString());
                        JsonConvertComputerInfoList.Add(one);
                    }
                    catch (Exception e)
                    {
                        _logger.LogError(
                            $"/Health/GetOneByAllComputerInfo Convert Json {item.ToString()} Error:{e.Message}");
                        continue;
                    }
                }

                RS.code = 200;
                RS.data = JsonConvertComputerInfoList;

            }
            catch (Exception e)
            {
                _logger.LogError($"/Health/GetOneByAllComputerInfo Very Important Error:{e.Message}");
                RS.code = 404;
                RS.msg = e.Message;
                RS.data = null;
            }
            return RS;
        }


    }
}