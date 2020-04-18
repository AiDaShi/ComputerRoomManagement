using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ComputerRoomClient.Tools;

namespace ComputerRoomClient
{
    public partial class ServerSettingForm : Form
    {
        public ServerSettingForm()
        {
            InitializeComponent();
        }

        private string IPNoValue => "IP...";
        private string PortNoValue => "Port...";
        private string AddressNoValue => "Address...";
        private string ClientNameNoValue => "Client...";

        private void InputIP_Click(object sender, EventArgs e)
        {

        }

        private void ServerSettingForm_Load(object sender, EventArgs e)
        {
            this.InputIP.Text = string.IsNullOrEmpty(Global.IP)? IPNoValue:Global.IP;
            this.InputPort.Text = string.IsNullOrEmpty(Global.Port)? PortNoValue : Global.Port;
            this.ClientName.Text = string.IsNullOrEmpty(Global.ClientName) ? ClientNameNoValue : Global.ClientName;

        }

        private void InputIP_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private async void SaveBtn_Click(object sender, EventArgs e)
        {
            Global.IP = this.InputIP.Text;
            Global.Port = this.InputPort.Text;
            Global.ClientName = this.ClientName.Text;
            var resposemessage = await Global.ServerAPIHandleName.ConnectionNetworkTest();
            if (resposemessage)
            {
                Global.GlobalRefitTools.SetServer();
                var resultbol = await Global.ServerAPIHandleName.AddNetworkName();
                if (!resultbol)
                {
                    MessageBox.Show("The Name is Exist!","Server",MessageBoxButtons.OK,MessageBoxIcon.Error);
                    return;
                }
                Global.MainForm.pictureBox5.Image = global::ComputerRoomClient.Properties.Resources.RedServer;
                Global.ServerAPIHandleName.AddMessage();
            }
            else
            {
                LogsHandle.LogsAddMessage("The NetWork is Disconnection!!!");
            }


            //日志编写
            // LogsHandle.LogsAddMessage("Welcome To ||| Computer Room Client |||");

            //Global.hubClientTools.Start(Global.IP, Global.Port+ Global.Address);
        }
    }
}
