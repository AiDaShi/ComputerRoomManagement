using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LogsLibrary.QueueLog;
using Microsoft.AspNet.SignalR.Client;

namespace ComputerRoomClient.Tools
{
    public class HubClientTools
    {
        private HubConnection connection = null;
        private IHubProxy countHub = null;

        public void Start(string ip, string port)
        {
            Start("127.0.0.1", ip, port, LogsHandle.FromHubLogsAdd);
        }
        public void Start(string localhostip, string ip, string port)
        {
            Start(localhostip, ip, port, LogsHandle.FromHubLogsAdd);
        }

        public void Start(string localhostip, string ip, string port, Action<string> LogHandle)
        {
            LogHandle.Invoke("Connection Server ...");
            string ipaddress = string.Format("http://{0}:{1}", ip, port);
            if (connection == null)
            {
                connection = new HubConnection(ipaddress);
                countHub = connection.CreateHubProxy("CountHub");
                countHub.On<string, string>("Login", LogHandleMethod);
                connection.Start().ContinueWith(task =>
                {
                    if (!task.IsFaulted)
                    {
                        LogHandle.Invoke("Connection Server Is Successful!");
                    }
                    else
                    {
                        LogHandle.Invoke("Connection Server Is Error!");
                    }
                }).Wait();
            }
            else
            {
                LogHandle.Invoke("Connection Server Is Connected!");
            }

        }

        public void Stop()
        {
            if (connection != null)
            {
                connection.Stop();
            }

        }

        public void LogHandleMethod(string username, string Message)
        {
            LogsHandle.FromHubLogsAdd("username:" + username + "| Message:" + Message);
        }
        public void GetUserMessage(string username, string Message)
        {
            LogsHandle.FromHubLogsAdd("username:" + username + "| Message:" + Message);
        }
    }
}
