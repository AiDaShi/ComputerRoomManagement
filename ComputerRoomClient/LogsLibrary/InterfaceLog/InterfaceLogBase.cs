using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogsLibrary.InterfaceLog
{
    public interface InterfaceLogBase
    {
        Task WriteAsync(string Context);
    }
}
