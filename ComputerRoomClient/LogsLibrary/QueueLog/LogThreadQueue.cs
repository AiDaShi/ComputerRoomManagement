using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using LogsLibrary.InitLog;
using LogsLibrary.InterfaceLog;

namespace LogsLibrary.QueueLog
{
    public  static class LogThreadQueue
    {
        public static  Queue<string> queue = new Queue<string>();
        public static  List<InterfaceLogBase> LIFL = new List<InterfaceLogBase>();

        

        public static void  StateLogThreadQueue()
        {
            //LIFL.Add(new InitUILogLable(Global.MainForm.LogUILable));
            Task.Factory.StartNew(() =>
            {
                while (true)
                {
                    lock (queue)
                    {
                        if (queue.Count>0)
                        {
                            string str = queue.Dequeue();
                            foreach (var item in LIFL)
                            { 
                                item.WriteAsync(str);
                            }
                        }
                    }
                    Thread.Sleep(500);
                }

            });
        }

    }
}
