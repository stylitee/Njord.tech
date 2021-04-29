using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalStaffManager.Class
{
    public class EmployeeOFF
    {
        public int id { get; set; }
        public Employee employee { get; set; }
        public Schedule_Period sched { get; set; }
        public string date { get; set; }
    }
}
