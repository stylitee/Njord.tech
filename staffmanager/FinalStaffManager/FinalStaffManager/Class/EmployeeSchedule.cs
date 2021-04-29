using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalStaffManager.Class
{
    public class EmployeeSchedule
    {
        public int id { get; set; }
        public int rotationID { get; set; }
        public int emp_id { get; set; }
        public RotationSchedule rot_id { get; set; }
        public Employee employ_id { get; set; }
    }
}
