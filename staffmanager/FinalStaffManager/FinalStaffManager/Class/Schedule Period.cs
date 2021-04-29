using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalStaffManager.Class
{
    public class Schedule_Period
    {
        public int scheduleperiod_id { get; set; }
        public string begindate { get; set; }
        public string enddate { get; set; }
        public string status { get; set; }
        public int numofscheed { get; set; }

        public static void saveSchedulePeriod(string begindate, string enddate)
        {
            Schedule_Period s = new Schedule_Period();
            s.begindate = begindate;
            s.enddate = enddate;
            s.status = "Open";
            s.numofscheed = 0;

            Schedule_PeriodHelper.SaveSchedulePeriod(s);
            MessageBox.Show("Schedule saved succesfully", "Saved", MessageBoxButtons.OK,MessageBoxIcon.Question);
        }

        public static void saveScheduleForADay(string scheduleperiod_id,string rcode,string date, List<string>scode)
        {
            try
            {
                for (int i = 0; i < scode.Count; i++)
                {
                    Schedule_PeriodHelper.SaveScheduleForADay(scheduleperiod_id, rcode, date, scode[i]);
                }
                MessageBox.Show("RCODE for this Scheduler Period is save; date: " + date,"Confirmation",MessageBoxButtons.OK,MessageBoxIcon.Question);
            }
            catch (Exception)
            {
                
                throw;
            }

        }
    }
}
