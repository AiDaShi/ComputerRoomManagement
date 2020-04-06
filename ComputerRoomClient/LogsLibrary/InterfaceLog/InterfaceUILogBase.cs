using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LogsLibrary.InterfaceLog
{
    public interface InterfaceUILogBase<T> : InterfaceLogBase 
        where T: class,new()
    {
        T BaseControl { get; set; }
    } 
}
