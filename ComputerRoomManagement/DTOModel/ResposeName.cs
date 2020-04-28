using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ComputerRoomManagement.DTOModel
{
    public class ResposeName<T>
    {
        public int code { get; set; }
        public string msg { get; set; }
        public T data { get; set; }
    }
}
