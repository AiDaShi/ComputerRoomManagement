using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Refit;

namespace ComputerRoomClient.Tools
{
    public class RefitTools
    {
        public ServerAPI _ServerAPI { get; set; }
        public void SetServer()
        {
             _ServerAPI = RestService.For<ServerAPI>("http://"+ Global.IP+":"+ Global.Port);
        }
    }
}
