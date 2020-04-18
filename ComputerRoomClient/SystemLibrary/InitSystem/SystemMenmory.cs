using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Management;
using System.Text;
using System.Threading.Tasks;

namespace SystemLibrary.InitSystem
{
    public class SystemMenmory: ISystemAbout
    {
        public override string ErrorLog(string msg)
        {
            return string.Format("[Error]：{0} Class | {1} ", nameof(SystemMenmory), msg);
        }

        public override string GetAllProcess()
        {
            double CounterCount = 0;
            //Using All
            //double[] info = new double[Counters.Length];
            //for (int i = 0; i < Counters.Length; i++)
            //{
            //    if (Counters[i] == null)
            //    {
            //        info[i] = 0;
            //    }
            //    info[i] = Counters[i].NextValue();
            //}
            //foreach (var item in info)
            //{
            //    CounterCount += item;
            //}
            //CounterCount = NewCounters.NextValue();

            //network

            //获取总物理内存大小
            ManagementClass cimobject1 = new ManagementClass("Win32_PhysicalMemory");
            ManagementObjectCollection moc1 = cimobject1.GetInstances();
            double available = 0, capacity = 0;
            foreach (ManagementObject mo1 in moc1)
            {
                capacity += ((Math.Round(Int64.Parse(mo1.Properties["Capacity"].Value.ToString()) / 1024 / 1024 / 1024.0, 1)));
            }
            moc1.Dispose();
            cimobject1.Dispose();


            //获取内存可用大小
            ManagementClass cimobject2 = new ManagementClass("Win32_PerfFormattedData_PerfOS_Memory");
            ManagementObjectCollection moc2 = cimobject2.GetInstances();
            foreach (ManagementObject mo2 in moc2)
            {
                available += ((Math.Round(Int64.Parse(mo2.Properties["AvailableMBytes"].Value.ToString()) / 1024.0, 1)));

            }
            moc2.Dispose();
            cimobject2.Dispose();

            //Console.WriteLine("总内存=" + capacity.ToString() + "G");
            //Console.WriteLine("可使用=" + available.ToString() + "G");
            //Console.WriteLine("已使用=" + ((capacity - available)).ToString() + "G," + (Math.Round((capacity - available) / capacity * 100, 0)).ToString() + "%");
            //Console.ReadKey();


            return (Math.Round((capacity - available) / capacity * 100, 0)).ToString();
        }

        public override string GetProcess()
        {
            return Math.Round(Counter.NextValue() / 1024.0 / 1024.0, 2).ToString();
        }

        public override string GetValue()
        {
            double currentMemoryTheMb = Math.Round(Counter.NextValue() / 1024.0 / 1024.0, 2);
            return currentMemoryTheMb + "MB";
        }

        public override PerformanceCounter[] SetAllProcess()
        {
            // 初始化计数器
            // Process.GetProcesses().Length

            //var Vcounters = new PerformanceCounter[System.Environment.ProcessorCount];
            var GetAllProcess = Process.GetProcesses().Select(x=>x.ProcessName).ToList();
            
            var Vcounters = new PerformanceCounter[GetAllProcess.Count];
            for (int i = 0; i < Vcounters.Length; i++)
            {
                try
                {
                    Vcounters[i] = new PerformanceCounter("Process", "Working Set", GetAllProcess[i]);
                    //Vcounters[i].NextValue(); // 这里是为了获得CPU占用率的值

                }
                catch (Exception e)
                {
                    Vcounters[i] = null;
                }
            }
            //NewCounters = new PerformanceCounter("Processor", "Working Set", "_Total");
            return Vcounters;
        }

        public override PerformanceCounter SetProcess()
        {
            return new PerformanceCounter("Process", "Working Set", processName);
        }
    }
}
