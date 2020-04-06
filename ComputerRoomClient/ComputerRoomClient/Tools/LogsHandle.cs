using LogsLibrary.QueueLog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComputerRoomClient.Tools
{
    public static class LogsHandle
    {
        public static void LogsAddMessage(string str)
        {
            try
            {
                LogThreadQueue.queue.Enqueue(str);
            }
            catch (Exception e)
            {

            }
        }
    }
}
