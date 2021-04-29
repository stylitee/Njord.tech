using FinalStaffManager.Class;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalStaffManager.Forms
{
    public partial class SetEmployeeDayOff : Form
    {
        public SetEmployeeDayOff()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                int id = Convert.ToInt32((cmbEmployeeList.SelectedItem as ComboBoxItem).Value.ToString());
                EmployeeOFFHelper.saveEmployeeOf(id, lblID.Text, cmbDate.Text);
                MessageBox.Show("Employee Day Off save!");
            }
            catch (Exception)
            {
                MessageBox.Show("Employee Dayoff fail!");
            }

        }
        private void loadAll()
        {
            string begin = "", end = "";
            List<Employee> listEmployee = EmployeeHelper.GetAllEmployees();
            foreach(var emp in listEmployee)
            {
                ComboBoxItem item = new ComboBoxItem();
                item.Text = emp.lastName + " " + emp.firstName;

                item.Value = emp.empID;
                cmbEmployeeList.Items.Add(item);
            }

            List<Schedule_Period> list = Schedule_PeriodHelper.getAllSchedulePeriod();
            foreach(var schedperiod in list)
            {
                if(schedperiod.status == "Open")
                {
                    lblSchedperiod.Text = schedperiod.begindate + "  to " + schedperiod.enddate;
                    begin = schedperiod.begindate;
                    end = schedperiod.enddate;
                    lblID.Text = schedperiod.scheduleperiod_id.ToString();
                    lblID.Visible = false;
                }
            }

            string[] bdate = begin.Split('/');
            string[] edate = end.Split('/');

            begin = bdate[1] + "/" + bdate[0] + "/" + bdate[2];
            end = edate[1] + "/" + edate[0] + "/" + edate[2];
            DateTime b = DateTime.Parse(begin);
            DateTime e = DateTime.Parse(end);
            var dates = new List<DateTime>();

            for (var dt = b; dt <= e; dt = dt.AddDays(1))
            {
                dates.Add(dt);
            }

            foreach(var day in dates)
            {
                cmbDate.Items.Add(day);
            }
        }

        private void SetEmployeeDayOff_Load(object sender, EventArgs e)
        {
            loadAll();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
