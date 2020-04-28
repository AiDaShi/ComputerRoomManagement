using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using SystemLibrary;
using ComputerRoomClient.Tools;

namespace ComputerRoomClient
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            Control.CheckForIllegalCrossThreadCalls = false;//关闭跨线程访问检测
            InitializeComponent();
            LogsHandle.LogsAddMessage("Welcome To ||| Computer Room Client |||");
            LogsHandle.LogsAddMessage("Welcome To ||| Computer Room Client |||");
            LogsHandle.LogsAddMessage("Welcome To ||| Computer Room Client |||");

            #region SetSystem

            SystemTools.StartSystemWorkFlow();

            #endregion
        }

        private void customizeDesing()
        {
            //The Menu's visible is false
            panelMediaSubmenu.Visible = false;
            //
            

        }

        /// <summary>
        /// Hide Menu
        /// </summary>
        private void hideSubMenu()
        {
            if (panelMediaSubmenu.Visible == true)
            {
                panelMediaSubmenu.Visible = false;
            }
        }

        private void showSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                hideSubMenu();
                subMenu.Visible = true;
            }
            else
                subMenu.Visible = false;
        }

        private void btnMedia_Click(object sender, EventArgs e)
        {
            showSubMenu(panelMediaSubmenu);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //your code
            openChildForm(new ServerSettingForm());

            //hide menu
            hideSubMenu();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //your code

            //hide menu
            hideSubMenu();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private Form activeForm = null;
        private void openChildForm(Form childForm)
        {

            if (activeForm != null)
            {
                activeForm.Close();
            }
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            if (panelChildForm.Controls.Count > 2)
            {
                panelChildForm.Controls.RemoveAt(2);
            }
            panelChildForm.Controls.Add(childForm);
            panelChildForm.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();

        }

        private void LocationStateBtn_Click(object sender, EventArgs e)
        {


            //hide menu
            hideSubMenu();
        }

        #region 实现拖动
        private Point mousePoint = new Point();
        private void FrmLogin_MouseDown(object sender, MouseEventArgs e)
        {
            this.mousePoint.X = e.X;
            this.mousePoint.Y = e.Y;
        }
        private void FrmLogin_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Top = Control.MousePosition.Y - mousePoint.Y + 13;
                this.Left = Control.MousePosition.X - mousePoint.X + 13;
            }
        }
        #endregion

        private void Form1_Load(object sender, EventArgs e)
        {
            Task.Factory.StartNew(() =>
            {
                while (true)
                {
                    Thread.Sleep(3000);
                    if (SystemScheduler.CPUList.Count > 0)
                    {
                        this.CPULablePercent.Text = SystemScheduler.CPUList.Last().AllValue + "%";
                    }
                    if (SystemScheduler.MenmoryList.Count > 0)
                    {
                        this.MenmoryLablePercent.Text = SystemScheduler.MenmoryList.Last().AllValue + "%";
                    }
                    //this.CPULablePercent.Text = 
                    Thread.Sleep(3000);
                }

            });
        }
    }
}
