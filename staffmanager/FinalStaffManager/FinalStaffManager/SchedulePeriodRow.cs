using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;
using FinalStaffManager.Class;
using System.Data.SqlClient;

namespace FinalStaffManager
{
    public partial class SchedulePeriodRow : UserControl
    {
        public SchedulePeriodRow()
        {
            InitializeComponent();
        }
        public static string id, num ="";
        public static List<Label> lbl = new List<Label>();
        private void SchedulePeriodRow_Load(object sender, EventArgs e)
        {
            lblID.Visible = false;
            lbl.Add(lblNumberOfSchedule);
            lbl.Add(lblBegin);
            lbl.Add(lblEnd);
            lbl.Add(lblID);
            lbl.Add(lblStatus);
            lbl.Add(lblNumberOfSchedule);
            loadScheds();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

        }

        private void btnSchedule_Click(object sender, EventArgs e)
        {
            schedulePeriodMenu.pnl[4].Show();
            id = lblID.Text;
            schedulePeriodMenu.pnl[0].Hide();
            schedulePeriodMenu.pnl[1].Hide();
            schedulePeriodMenu.pnl[2].Show();
            schedulePeriodMenu.pnl[3].Show();
            schedulePeriodMenu.flow[0].Hide();

            schedulePeriodMenu.btn[0].Text = "Back";
            schedulePeriodMenu.btn[0].Hide();
            schedulePeriodMenu.btn[1].Text = "Return";
            schedulePeriodMenu.btn[1].Show();
            schedulePeriodMenu.lbl[1].Text = "  ";
            schedulePeriodMenu.btn[2].Show();
            schedulePeriodMenu.lbl[2].Text = lblStatus.Text;

        }
        public static void loadScheds()
        {
            try
            {
                // 1 begin && 2 end
                // 3 sched id
                // 0  is count of attendance
                int count = 0;
                List<RotationSchedule> dateList = new List<RotationSchedule>();
                List<string> date = new List<string>();
                var dates = new List<DateTime>();
                DateTime start = DateTime.ParseExact(lbl[1].Text, "MM/dd/yyyy", CultureInfo.InvariantCulture), end = DateTime.ParseExact(lbl[2].Text, "MM/dd/yyyy", CultureInfo.InvariantCulture);

                for (var dt = start; dt <= end; dt = dt.AddDays(1))
                {
                    dates.Add(dt);
                }


                SqlParameter[] f = { new SqlParameter("@sched_id", lbl[3].Text) };
                dateList = RotationScheduleHelper.getRotationDates(f);
                foreach (var d in dateList)
                {
                    date.Add(d.date);
                }

                List<string> distinct = date.Distinct().ToList();
                foreach (var c in distinct)
                {
                    count++;
                }
                Schedule_PeriodHelper.AddNumberOfSchedule(count, Convert.ToInt32(lbl[3].Text));
                lbl[0].Text = count.ToString() + "/7";
                dates.Clear();
                date.Clear();
                dateList.Clear();
                distinct.Clear();
            }
            catch (Exception)
            {
                return;
            }
            
            //num = count.ToString() + "/7";
        }

        public static void loadstatus()
        {
            try
            {
                SqlParameter[] f = { new SqlParameter("@id", lbl[3].Text) };
                List<Schedule_Period> list = Schedule_PeriodHelper.GetSelectedSchedulePeriod(f);
                foreach (var i in list)
                {
                    schedulePeriodMenu.cmb[0].Text = lbl[4].Text;
                }
            }
            catch (Exception)
            {
                return;
            }

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Are you sure you want to delete this schedule period?","Confirmation",MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    Schedule_Period s = new Schedule_Period();
                    s.scheduleperiod_id = Convert.ToInt32(lblID.Text);

                    Schedule_PeriodHelper.DeleteSchedulePeriod(s);
                    MessageBox.Show("Schedule period deleted succesfully!");
                }
                catch (Exception)
                {
                    MessageBox.Show("Deletion fail!");
                }

            }
        }
    }
}
