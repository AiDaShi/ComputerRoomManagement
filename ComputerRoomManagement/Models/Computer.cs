using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ComputerRoomManagement.Models
{
    public class Computer<T>
    {
        public string Name { get; set; }
        public List<T> Data { get; set; }
    }
}
