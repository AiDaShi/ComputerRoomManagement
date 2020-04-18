using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemLibrary
{
    public abstract class ISystemAbout
    {

        public ISystemAbout()
        {
            processName = Process.GetCurrentProcess().ProcessName;
            Counter= SetProcess();

            #region 获取多个

            Counters = SetAllProcess();

            #endregion
        }

        protected string processName { get; set; }
        protected PerformanceCounter Counter { get; set; }
        public abstract PerformanceCounter SetProcess();
        public abstract string GetValue();
        public abstract string ErrorLog(string msg);

        public abstract string GetProcess();
        #region 获取多个

        protected PerformanceCounter NewCounters;
        // 用于获得CPU信息
        protected  PerformanceCounter[] Counters;
        public abstract PerformanceCounter[] SetAllProcess();
        public abstract string GetAllProcess();



        #endregion
    }
}
