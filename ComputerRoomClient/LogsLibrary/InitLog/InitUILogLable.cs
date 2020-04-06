using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LogsLibrary.InterfaceLog;

namespace LogsLibrary.InitLog
{
    public class InitUILogLable : InitUILogBase<TextBox>, InterfaceUILogBase<TextBox>
    {
        
        public InitUILogLable(TextBox text)
            :base(text)
        {
        }

        public async Task WriteAsync(string Context)
        {
            (base.BaseControl as TextBox).AppendText(Context+"\r\n");
        }

        public override void SetBaseControlMethod(TextBox text)
        {
            base.BaseControl = text;
        }
    }
}
