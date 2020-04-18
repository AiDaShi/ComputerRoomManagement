using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using SystemLibrary.Model;

namespace SystemLibrary
{
    public static class SystemScheduler
    {
        public static List<CPUModel> CPUList = new List<CPUModel>();
        public static List<MenmoryModel> MenmoryList = new List<MenmoryModel>();

        public static void StartScheduler(Dictionary<SystemType, ISystemAbout> DIS,Action<string> ErrorAction)
        {
            //LIFL.Add(new InitUILogLable(Global.MainForm.LogUILable));
            Task.Factory.StartNew(() =>
            {
                while (true)
                {
                    try
                    {
                        if (CPUList.Count > 10)
                        {
                            CPUList.RemoveAt(0);
                        }
                        if (MenmoryList.Count > 10)
                        {
                            MenmoryList.RemoveAt(0);
                        }
                        //更新数据
                        foreach (var item in DIS)
                        {
                            switch (item.Key)
                            {
                                case SystemType.CPU:
                                    CPUModel CpuNowMsg = new CPUModel();
                                    CpuNowMsg.AllValue = item.Value.GetAllProcess();
                                    CpuNowMsg.CurrentValue = item.Value.GetProcess();
                                    CPUList.Add(CpuNowMsg);
                                    break;
                                case SystemType.Memory:
                                    MenmoryModel MemoryNowMsg = new MenmoryModel();
                                    MemoryNowMsg.AllValue = item.Value.GetAllProcess();
                                    MemoryNowMsg.CurrentValue = item.Value.GetProcess();
                                    MenmoryList.Add(MemoryNowMsg);
                                    break;
                            }
                        }
                    }
                    catch (Exception e)
                    {
                        ErrorAction.Invoke(e.Message);
                    }
                    finally
                    {
                        Thread.Sleep(2000);
                    }
                }
            });

        }

    }
}
