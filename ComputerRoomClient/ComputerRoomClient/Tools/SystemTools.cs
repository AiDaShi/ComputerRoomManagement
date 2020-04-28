using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SystemLibrary;
using SystemLibrary.InitSystem;
using SystemLibrary.Model;

namespace ComputerRoomClient.Tools
{
    public static class SystemTools
    {
       static Dictionary<SystemType,ISystemAbout> DIS = new Dictionary<SystemType,ISystemAbout>();

       private static void SetTypeToNeed()
       {
           DIS.Add(SystemType.CPU,new SystemCPU());
           DIS.Add(SystemType.Memory,new SystemMenmory());
       }

       public static void StartSystemWorkFlow()
       {
           Task.Factory.StartNew(() =>
           {
               SetTypeToNeed();
               SystemScheduler.StartScheduler(DIS, (s) => { LogsHandle.LogsAddMessage("Find A Error | " + s); });
           });
       }

    }

    
}
