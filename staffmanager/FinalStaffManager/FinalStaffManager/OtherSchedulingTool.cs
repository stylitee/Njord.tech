using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FinalStaffManager.Class;
using System.Globalization;
using System.Data.SqlClient;

namespace FinalStaffManager
{
    public partial class OtherSchedulingTool : UserControl
    {
        public OtherSchedulingTool()
        {
            InitializeComponent();
            scheduleperiod();
        }
        string begindate = "", enddate = "";
        List<DateTime> dates = new List<DateTime>();
        List<DateTime> properformatDate = new List<DateTime>();

        //public void loadTable()
        //{
        //    var rcode = new RCODETableParts();
        //    rcode.pnlMax5.Show();
        //    rcode.pnlMax3.Hide();
        //    rcode.pnlMax4.Hide();
        //    if (timeflag == 0)
        //    {
        //        incremented = time + TimeSpan.FromMinutes(30);
        //        rcode.lblTime5.Text = time.ToString(@"hh\:mm") + "-" + incremented.ToString(@"hh\:mm");
        //    }
        //    else
        //    {
        //        var timeme = incremented;
        //        incremented = incremented + TimeSpan.FromMinutes(30);
        //        rcode.lblTime5.Text = timeme.ToString(@"hh\:mm") + "-" + incremented.ToString(@"hh\:mm");
        //    }
        //}

        public void initialTitle()
        {
            DateTime S = DateTime.ParseExact(begindate, "MM/dd/yyyy", CultureInfo.InvariantCulture);
            DateTime E = DateTime.ParseExact(enddate, "MM/dd/yyyy", CultureInfo.InvariantCulture);

            for (var dt = S; dt <= E; dt = dt.AddDays(1))
            {
                dates.Add(dt);
                properformatDate.Add(dt);
            }
            var period = new OtherSchedulingPeriodRow();
            period.lblTime.Text = "";
            period.lblScodeDay1.Text = dates[0].ToString("MMM dd");
            period.lblScodeDay2.Text = dates[1].ToString("MMM dd");
            period.lblScodeDay3.Text = dates[2].ToString("MMM dd");
            period.lblScodeDay4.Text = dates[3].ToString("MMM dd");
            period.lblScodeDay5.Text = dates[4].ToString("MMM dd");
            period.lblScodeDay6.Text = dates[5].ToString("MMM dd");
            period.lblScodeDay7.Text = dates[6].ToString("MMM dd");
            flpTable.Controls.Add(period);
        }

        public void scheduleperiod()
        {
            List<Schedule_Period> list = Schedule_PeriodHelper.getAllSchedulePeriod();
            List<Employee> listEmployee = EmployeeHelper.GetAllEmployees();

            foreach (var r in list)
            {
                ComboBoxItem item = new ComboBoxItem();
                item.Text = r.begindate + " to " + r.enddate;

                item.Value = r.scheduleperiod_id;
                cmbSchedulePeriod.Items.Add(item);
            }

            foreach(var employee in listEmployee)
            {
                ComboBoxItem item = new ComboBoxItem();
                if(employee.middleName == "")
                {
                    item.Text = employee.firstName + " " + employee.middleName;
                }
                else
                {
                    item.Text = employee.firstName + " " + employee.middleName.Substring(0, 1) + " " + employee.lastName;
                }
                
                item.Value = employee.empID;
                cmbEmployeeList.Items.Add(item);
            }
        }

        private void cmbSchedulePeriod_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void employee()
        {
            flpTable.Controls.Clear();
            int initator = 0, flag = 0;
            //List<string> scodelistnow = new List<string>();
            //List<string> datelistnow = new List<string>();
            int timeflag = 0;
            DateTime S = DateTime.ParseExact(begindate, "MM/dd/yyyy", CultureInfo.InvariantCulture);
            DateTime E = DateTime.ParseExact(enddate, "MM/dd/yyyy", CultureInfo.InvariantCulture);
            TimeSpan time = new TimeSpan(7, 30, 0);
            var incremented = new TimeSpan(0, 0, 0);

            for (int i = 0; i < 30; i++)
            {
                var sched = new OtherSchedulingPeriodRow();
                if (timeflag == 0)
                {
                    incremented = time + TimeSpan.FromMinutes(30);
                    sched.lblTime.Text = time.ToString(@"hh\:mm") + "-" + incremented.ToString(@"hh\:mm");
                }
                else
                {
                    var timeme = incremented;
                    incremented = incremented + TimeSpan.FromMinutes(30);
                    sched.lblTime.Text = timeme.ToString(@"hh\:mm") + "-" + incremented.ToString(@"hh\:mm");
                }
                SqlParameter[] SchedAndEmp = { new SqlParameter("@emp_id", (cmbEmployeeList.SelectedItem as ComboBoxItem).Value.ToString()),
                                              new SqlParameter("@sched_id",Convert.ToInt32((cmbSchedulePeriod.SelectedItem as ComboBoxItem).Value.ToString()))};
                List<EmployeeSchedule> scodeanddates = new List<EmployeeSchedule>();
                scodeanddates = EmployeeScheduleHelper.GetEmployeeSCHED(SchedAndEmp);
                foreach(var c in scodeanddates)
                {
                    List<SCODE> scodelista = null;
                    SqlParameter[] a = { new SqlParameter("@code", c.rot_id.scode) };
                    scodelista = ScodeHelper.GetSelectedScode(a);

                    foreach (var wew in scodelista)
                    {
                        string[] ranges = sched.lblTime.Text.Split('-');
                        TimeSpan startRange = TimeSpan.Parse(ranges[0]);
                        TimeSpan endRange = TimeSpan.Parse(ranges[1]);

                        TimeSpan firstIn = TimeSpan.Parse(wew.firstIn);
                        TimeSpan firstOut = TimeSpan.Parse(wew.firstOut);
                        TimeSpan secondIn = TimeSpan.Parse(wew.secondIn);
                        TimeSpan secondOut = TimeSpan.Parse(wew.secondOut);

                        if (startRange > firstIn && startRange < firstOut || endRange > firstIn && endRange < firstOut
                        || startRange > secondIn && startRange < secondOut || endRange > secondIn && endRange < secondOut)
                        {
                            string[] format = c.rot_id.date.Split('/');
                            if (properformatDate[initator].ToString("MM/dd/yyyy") == format[1] + "/" + format[0] + "/" + format[2])
                            {
                                if (properformatDate[initator].ToString("MM/dd/yyyy") == format[1] + "/" + format[0] + "/" + format[2])
                                {
                                    sched.lblScodeDay1.Text = " " + c.rot_id.scode;
                                    initator++;
                                }
                                else if (properformatDate[initator].ToString("MM/dd/yyyy") == format[1] + "/" + format[0] + "/" + format[2])
                                {
                                    sched.lblScodeDay2.Text = " " + c.rot_id.scode;
                                    initator++;
                                }
                                else if (properformatDate[initator].ToString("MM/dd/yyyy") == format[1] + "/" + format[0] + "/" + format[2])
                                {
                                    sched.lblScodeDay3.Text = " " + c.rot_id.scode;
                                    initator++;
                                }
                                else if (properformatDate[initator].ToString("MM/dd/yyyy") == format[1] + "/" + format[0] + "/" + format[2])
                                {
                                    sched.lblScodeDay4.Text = " " + c.rot_id.scode;
                                    initator++;
                                }
                                else if (properformatDate[initator].ToString("MM/dd/yyyy") == format[1] + "/" + format[0] + "/" + format[2])
                                {
                                    sched.lblScodeDay5.Text = " " + c.rot_id.scode;
                                    initator++;
                                }
                                else if (properformatDate[initator].ToString("MM/dd/yyyy") == format[1] + "/" + format[0] + "/" + format[2])
                                {
                                    sched.lblScodeDay6.Text = " " + c.rot_id.scode;
                                    initator++;
                                }
                                else if (properformatDate[initator].ToString("MM/dd/yyyy") == format[1] + "/" + format[0] + "/" + format[2])
                                {
                                    sched.lblScodeDay7.Text = " " + c.rot_id.scode;
                                    initator++;
                                }

                            }
                            else
                            {
                                sched.lblScodeDay1.Text = "";
                            }
                        }
                        else
                        {

                        }
                    }
                }
                initator = 0;
                flpTable.Controls.Add(sched);
                flag++;
                timeflag = 1;

            }
        }

       

        private void cmbEmployeeList_TextChanged(object sender, EventArgs e)
        {
            begindate = cmbSchedulePeriod.Text.Substring(0, 10);
            enddate = cmbSchedulePeriod.Text.Substring(14, 10);

            initialTitle();
            employee();
        }

        private void OtherSchedulingTool_Load(object sender, EventArgs e)
        {

        }

    }
}
