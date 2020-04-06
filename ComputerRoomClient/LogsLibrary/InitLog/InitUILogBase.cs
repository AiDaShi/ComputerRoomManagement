using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LogsLibrary.InitLog
{
    public abstract class InitUILogBase<T>
        where T : class, new()
    {
        public InitUILogBase(T text)
        {
            SetBaseControlMethod(text);
        }

        public T BaseControl { get; set; }

        public abstract void SetBaseControlMethod(T text);
    }
}
