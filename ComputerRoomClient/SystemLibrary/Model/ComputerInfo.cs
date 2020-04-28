using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace SystemLibrary.Model
{
    public class ComputerInfo
    {
        public string Name { get; set; }
        public string CPU { get; set; }
        public string Memory { get; set; }
        public DateTime Time { get; set; }
    }
}
