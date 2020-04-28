using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ComputerRoomManagement.Models
{
    public class ComputerMonthlyAndDay
    {
        public double MonthlyCountCPU { get; set; }
        public double DayCountCPU { get; set; }
        public double DayCountMemory { get; set; }
        public double MonthlyCountMemory { get; set; }
    }
}
