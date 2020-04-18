using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using SystemLibrary;
using SystemLibrary.Model;

namespace ComputerRoomClient.Tools
{
    public class ServerAPIHandle
    {
        public ServerAPIHandle()
            : this(true)
        {

        }

        public ServerAPIHandle(bool KeepConnectionField)
        {
            _KeepConnectionField = KeepConnectionField;
            KeepConnection = () => _KeepConnectionField;
        }
        /// <summary>
        /// 测试是否联网
        /// </summary>
        /// <returns></returns>
        public async Task<bool> ConnectionNetworkTest()
        {
            try
            {
                HttpClient httpClient = new HttpClient();
                var ResposeMessage = await httpClient.GetAsync("http://www.baidu.com");
                return ResposeMessage.IsSuccessStatusCode;
            }
            catch (Exception e)
            {
                LogsHandle.LogsAddMessage("[Error]:" + e.Message);
            }
            return false;

        }



        /// <summary>
        /// 添加本地信息到服务器端
        /// </summary>
        /// <returns></returns>
        public async Task<bool> AddNetworkName()
        {
            try
            {
                var Result = await Global.GlobalRefitTools._ServerAPI.AddName(Global.ClientName);
                if (Result.code == 200)
                {
                    LogsHandle.LogsAddMessage("服务器请求成功！！！");
                    LogsHandle.LogsAddMessage("正在设置服务器连接...");
                    ctx.Name = Result.data;
                    return true;
                }
                else
                {
                    throw new Exception("Server:" + Result.msg);
                }
            }
            catch (Exception e)
            {
                LogsHandle.LogsAddMessage(e.Message);
            }
            return false;
        }

        ComputerInfo ctx = new ComputerInfo();
        /// <summary>
        /// 进行健康处理
        /// </summary>
        /// <returns></returns>
        public void AddMessage()
        {
            Task.Factory.StartNew(async () =>
            {
                while (KeepConnection.Invoke())
                {

                    ctx.CPU = SystemScheduler.CPUList.Last().AllValue;
                    ctx.Memory = SystemScheduler.MenmoryList.Last().AllValue;
                    try
                    {
                        var Result = await Global.GlobalRefitTools._ServerAPI.AddMessage(ctx);
                        if (Result.code == 200)
                        {
                            LogsHandle.LogsAddMessage("向服务器发送健康情况！！！");
                        }
                        else
                        {
                            throw new Exception("服务器请求失败|" + Result.msg);
                        }
                    }
                    catch (Exception e)
                    {
                        LogsHandle.LogsAddMessage(e.Message);
                        Global.MainForm.pictureBox5.Image = global::ComputerRoomClient.Properties.Resources.BlackServer;
                        break;
                    }
                    Thread.Sleep(6000);
                }
            });
        }

        public void SetCF(bool iscon)
        {
            _KeepConnectionField = iscon;
        }

        private bool _KeepConnectionField { get; set; }
        public Func<bool> KeepConnection { get; set; }


    }
}
