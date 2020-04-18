using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemLibrary.InitSystem
{
    public class SystemCPU : ISystemAbout
    {
        public override string ErrorLog(string msg)
        {
            return string.Format("[Error]：{0} Class | {1} ",nameof(SystemCPU),msg);
        }

        public override string GetProcess()
        {
            return Counter.NextValue().ToString();
        }

        public override PerformanceCounter[] SetAllProcess()
        {
            // 初始化计数器
            var GetAllProcess = Process.GetProcesses().Select(x => x.ProcessName).ToList();
            var Vcounters = new PerformanceCounter[GetAllProcess.Count];
            for (int i = 0; i < Vcounters.Length; i++)
            {
                Vcounters[i] = new PerformanceCounter("Process", "% Processor Time", GetAllProcess[i]);
                //Vcounters[i].NextValue(); // 这里是为了获得CPU占用率的值
            }
            NewCounters = new PerformanceCounter("Processor", "% Processor Time", "_Total");
            //_Total
            return Vcounters;
        }

        public override string GetAllProcess()
        {
            double CounterCount = 0;

            //通过
            //double[] info = new double[Counters.Length];
            //for (int i = 0; i < Counters.Length; i++)
            //{
            //    if (Counters[i]==null)
            //    {
            //        info[i] = 0;
            //    }

            //    try
            //    {
            //        info[i] = Counters[i].NextValue();
            //    }
            //    catch (Exception e)
            //    {
            //    }
            //}
            //foreach (var item in info)
            //{
            //    CounterCount += item;
            //}
            CounterCount = NewCounters.NextValue();

            //return Math.Round(CounterCount, 2).ToString();
            return Math.Round(CounterCount, 0).ToString();
        }

        public override string GetValue()
        {
            return Math.Round(Counter.NextValue(), 2).ToString()+"%";
            //double currentMemoryTheMb = Math.Round(Counter.NextValue() / 1024.0 / 1024.0, 2);
            //return currentMemoryTheMb + "MB";
        }

        public override PerformanceCounter SetProcess()
        {
           return new PerformanceCounter("Process", "% Processor Time", base.processName);
        }
    }
}
