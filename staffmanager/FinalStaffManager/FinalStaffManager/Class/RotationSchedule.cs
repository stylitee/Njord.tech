using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalStaffManager.Class
{
    public class RotationSchedule
    {
        public int rotationId { get; set; }
        public int schedulePeriodId { get; set; }
        public string rcode { get; set; }
        public string scode { get; set; }
        public string date { get; set; }
    }
}
