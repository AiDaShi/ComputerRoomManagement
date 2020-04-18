using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using ComputerRoomClient.Tools;
using LogsLibrary.InitLog;
using LogsLibrary.QueueLog;

namespace ComputerRoomClient
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Global.MainForm = new Form1();
            Global.IsConnectionServer = false;

            #region SetLogger
            //Set Log Method
            LogThreadQueue.LIFL.Add(new InitUILogLable(Global.MainForm.LogUILable));
            LogThreadQueue.StateLogThreadQueue();
            #endregion

            Application.Run(Global.MainForm);
        }
    }
}
