using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using ComputerRoomManagement.Services;
using Microsoft.AspNetCore.SignalR;

namespace ComputerRoomManagement.Hubs
{
    public class CountHub:Hub
    {
        private readonly CountService _countService;

        public CountHub(CountService countService)
        {
            _countService = countService;
        }

        public async Task GetLatestCount(string random)
        {
            int count;
            count = _countService.GetLatestCount();
            do
            {
                Thread.Sleep(1000);
                await Clients.All.SendAsync("ReceiveUpdate", count);
                count++;
            } while (count < 10);
            await Clients.All.SendAsync("Finished");
        }

        public override async Task OnConnectedAsync()
        {
            var connectionId = Context.ConnectionId;
            await Clients.Client(connectionId).SendAsync("someFunc", new { });
            await Clients.AllExcept(connectionId).SendAsync("someFunc");

            await Groups.AddToGroupAsync(connectionId, "MyGroup");
            await Groups.RemoveFromGroupAsync(connectionId, "MyGroup");

            await Clients.Group("MyGroup").SendAsync("someFunc");
        }


        public async Task Login(string random)
        {
            var connectionId = Context.ConnectionId;
            await Clients.Client(connectionId).SendAsync("LogHandleMethod", connectionId,"已经与服务器连接上了");
        }


        public async Task GetUserMessage(string message)
        {
            var connectionId = Context.ConnectionId;
            await Clients.Client(connectionId).SendAsync("GetUserMessage", connectionId, "服务器接受到了你的请求！消息如下:"+ message);
        }

        public override async Task  OnDisconnectedAsync(Exception exception)
        {
            var connectionId = Context.ConnectionId;
            await Clients.Client(connectionId).SendAsync("someFunc", new { });

        }
    }
}
