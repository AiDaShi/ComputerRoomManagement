using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ComputerRoomClient.Tools;
using Refit;

namespace ComputerRoomClient
{
    public  static class Global
    {

        public static Form1 MainForm { get; set; }

        public static bool IsConnectionServer{ get; set; }

        public static string IP { get; set; }
        public static string Address { get; set; }
        public static string ClientName { get; set; }
        public static string Port { get; set; }
        public static ServerAPIHandle ServerAPIHandleName =new ServerAPIHandle();
        
        public static RefitTools GlobalRefitTools =new  RefitTools();
        //public static HubClientTools hubClientTools =new HubClientTools();

    }
}
