using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ComputerRoomManagement.Hubs;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.SignalR;

namespace ComputerRoomManagement.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CountController : ControllerBase
    {
        private readonly IHubContext<CountHub> _countHub;

        public CountController(IHubContext<CountHub> countHub)
        {
            _countHub = countHub;
        }

        public async Task<IActionResult> Post()
        {
            await _countHub.Clients.All.SendAsync("someFunc",new {random="abcd"});
            return Accepted(1);
        }
    }
}