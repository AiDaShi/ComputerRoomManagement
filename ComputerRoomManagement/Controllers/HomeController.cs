using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using ComputerRoomManagement.LayminiuiTools;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ComputerRoomManagement.Models;
using Microsoft.Extensions.Caching.Distributed;
using StackExchange.Redis;

namespace ComputerRoomManagement.Controllers
{
    public class HomeController : Controller
    {
        private readonly IConnectionMultiplexer _redis;
        private readonly IDistributedCache _distributedCache;
        private readonly IDatabase _db;
        private readonly ILogger<HomeController> _logger;
        public HomeController(ILogger<HomeController> logger,IConnectionMultiplexer redis, IDistributedCache distributedCache)
        {
            //分布式缓存使用方式
            _distributedCache = distributedCache;
            //非分布式缓存使用方式
            _redis = redis;
            _db = _redis.GetDatabase();
            _logger = logger;
        }

        public IActionResult Index()
        {
            _db.StringSet("fullName", "Michael Jackson");

            var name = _db.StringGet("fullName").ToString();

            return View("Index",name);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult Panel()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }


        //[HttpGet(nameof(SystemMenu))]
        //public IActionResult SystemMenu()
        //{
        //    List<SystemMenuEntity> systemMenuEntities = new List<SystemMenuEntity>();
        //    using (SystemMenuDbContext dbContext = new SystemMenuDbContext())
        //    {
        //        systemMenuEntities = dbContext.SystemMenus.Where(s => s.id > 0).ToList();
        //    }

        //    SystemMenu rootNode = new SystemMenu()
        //    {
        //        Id = 0,
        //        Icon = "",
        //        Href = "",
        //        Title = "根目录",
        //    };

        //    GetTreeNodeListByNoLockedDTOArray(systemMenuEntities.ToArray(), rootNode);

        //    MenusInfoResultDTO menusInfoResultDTO = new MenusInfoResultDTO();
        //    menusInfoResultDTO.MenuInfo = rootNode.Child;
        //    menusInfoResultDTO.LogoInfo = new LogoInfo();
        //    menusInfoResultDTO.HomeInfo = new HomeInfo();

        //    return new JsonResult(menusInfoResultDTO);
        //}

        /// <summary>
        /// 递归处理数据
        /// </summary>
        /// <param name="systemMenuEntities"></param>
        /// <param name="rootNode"></param>
        public static void GetTreeNodeListByNoLockedDTOArray(SystemMenuEntity[] systemMenuEntities, SystemMenu rootNode)
        {
            if (systemMenuEntities == null || systemMenuEntities.Count() <= 0)
            {
                return;
            }

            var childreDataList = systemMenuEntities.Where(p => p.pid == rootNode.Id);
            if (childreDataList != null && childreDataList.Count() > 0)
            {
                rootNode.Child = new List<SystemMenu>();

                foreach (var item in childreDataList)
                {
                    SystemMenu treeNode = new SystemMenu()
                    {
                        Id = item.id,
                        Icon = item.icon,
                        Href = item.href,
                        Title = item.title,
                    };
                    rootNode.Child.Add(treeNode);
                }

                foreach (var item in rootNode.Child)
                {
                    GetTreeNodeListByNoLockedDTOArray(systemMenuEntities, item);
                }
            }
        }


    }
}
