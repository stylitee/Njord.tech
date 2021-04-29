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
using System.Data.SqlClient;
using System.Globalization;
using System.Text.RegularExpressions;
using FinalStaffManager.Forms;

namespace FinalStaffManager
{
    public partial class schedulePeriodMenu : UserControl
    {
        public schedulePeriodMenu()
        {
            InitializeComponent();
        }
        string begin = "", end = "";
        List<string> scodesss = null;
        int countofscode = 0;
        public static List<Panel> pnl = new List<Panel>();
        public static List<FlowLayoutPanel> flow = new List<FlowLayoutPanel>();
        public static List<Label> lbl = new List<Label>();
        public static List<Button> btn = new List<Button>();
        public static List<ComboBox> cmb = new List<ComboBox>();
        public static string schedstatus;
        int i;
        int numberOfEmployees = 0;
        //int periodflag = 0;
        private void btnAdd_Click(object sender, EventArgs e)
        {
            int count = 0;
            List<Schedule_Period> list = Schedule_PeriodHelper.getAllSchedulePeriod();
            foreach(var status in list)
            {
                if(status.status == "Open")
                {
                    count++;
                }
            }
            if(count == 0)
            {
                if (btnAdd.Text == "ADD NEW SCHEDULER PERIOD")
                {
                    DialogResult dia = MessageBox.Show("Are you sure you want to Add new Schedule Period", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dia == DialogResult.Yes)
                    {
                        pnlHeadDisplay.Hide();
                        pnlListOfSchedule.Hide();
                        //pnlHeadScheduling.Hide();
                        pnlRegistration.Show();
                        btnAdd.Text = "Save";
                        btnCancel.Show();
                    }
                    else
                    {
                        return;
                    }
                }
                else if (btnAdd.Text == "Save")
                {
                    string monday = dtrBeginDate.Value.DayOfWeek.ToString();
                    string sunday = dtrEndDate.Value.DayOfWeek.ToString();
                    if (monday == "Monday" && sunday == "Sunday")
                    {
                        Schedule_Period.saveSchedulePeriod(dtrBeginDate.Value.ToString("MM/dd/yyyy"), dtrEndDate.Value.ToString("MM/dd/yyyy"));
                    }
                    else if (monday == "Monday" && sunday != "Sunday")
                    {
                        MessageBox.Show("The dates are not 7 day span!");
                    }
                    LoadSchedulerPeriod();
                }
                else if (btnAdd.Text == "Back")
                {
                    pnlHeadDisplay.Hide();
                    pnlListOfSchedule.Hide();
                    //pnlHeadScheduling.Hide();
                }
            }
            else
            {
                MessageBox.Show("There are schedule period that still open, close it first to continue", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Information);
                count = 0;
            }
        }

        private void SchedulePeriodMenu_Load(object sender, EventArgs e)
        {
            btnPrintSchedule.Hide();
            btnSetter.Hide();
            pnlHeadDisplay.Show();
            pnlListOfSchedule.Show();
            pnlRegistration.Hide();
            btnCancel.Hide();
            
            pnlSchedulingHead.Hide();
            pnlSchedulingBody.Hide();
            //panel
            pnl.Add(pnlHeadDisplay);
            pnl.Add(pnlRegistration);
            pnl.Add(pnlSchedulingBody);
            pnl.Add(pnlSchedulingHead);
            pnl.Add(pnlCover);
            //flow
            flow.Add(pnlListOfSchedule);
            //label
            lbl.Add(lblStatus);
            lbl.Add(lblIndicator);
            lbl.Add(lblSchedStatus);
            //button
            btn.Add(btnAdd);
            btn.Add(btnCancel);
            btn.Add(btnPrintSchedule);
            LoadSchedulerPeriod();
            pnlListOfSchedule.Show();
            pnlHeadDisplay.Show();
            LoadSchedulerPeriod();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if(btnCancel.Text == "Return")
            {
                btnPrintSchedule.Hide();
                btnSetter.Hide();
                pnlRegistration.Hide();
                btnAdd.Show();
                btnAdd.Text = "ADD NEW SCHEDULER PERIOD";
                btnCancel.Hide();
                pnlSchedulingHead.Hide();
                pnlSchedulingBody.Hide();
                pnlListOfSchedule.Show();
                pnlHeadDisplay.Show();
            }
            else
            {
                pnlHeadDisplay.Show();
                pnlListOfSchedule.Show();
                pnlRegistration.Hide();
                btnCancel.Hide();
                btnAdd.Show();
                btnAdd.Text = "ADD NEW SCHEDULER PERIOD";
            }

        }

        public static void LoadSchedulerPeriod()
        {
            flow[0].Controls.Clear();
            int i = 1;
            List<Schedule_Period> list = Schedule_PeriodHelper.getAllSchedulePeriod();

            foreach(var r in list)
            {
                var s = new SchedulePeriodRow();
                s.lblItem.Text = i.ToString();
                s.lblID.Text = r.scheduleperiod_id.ToString();
                s.lblBegin.Text = r.begindate;
                s.lblEnd.Text = r.enddate;
                s.lblNumberOfSchedule.Text ="7" + "/7";
                s.lblStatus.Text = r.status;
                flow[0].Controls.Add(s);
                i++;
            }

            //SchedulePeriodRow.loadScheds();
        }

        private void lblStatus_TextChanged(object sender, EventArgs e)
        {
            populateScodesAndEmployees();
        }

        private void populateScodesAndEmployees()
        {

            List<RCODE> list = RcodeHelper.GetAllRcodes();
            DateTime Start = DateTime.ParseExact(begin, "MM/dd/yyyy", CultureInfo.InvariantCulture);
            DateTime last = DateTime.ParseExact(end, "MM/dd/yyyy", CultureInfo.InvariantCulture);

            for (var dt = Start; dt <= last; dt = dt.AddDays(1))
            {
                cmbDate.Items.Add(dt);
            }
            foreach(var rcode in list)
            {
                //codeeee = Regex.Match(rcode.desc, @"\d+").Value;
                //flag = Convert.ToInt32.
                //cmbRcode.Items.Add(rcode.rcode);
            }

        }

        private void lblIndicator_TextChanged(object sender, EventArgs e)
        {
            //set indicator text  to lblindicator = "";
            string rcode = SchedulePeriodRow.id;
            SqlParameter[] f = { new SqlParameter("@id", rcode) };
            List<Schedule_Period> list = Schedule_PeriodHelper.GetSelectedSchedulePeriod(f);
            foreach (var info in list)
            {
                begin = info.begindate;
                end = info.enddate;
                lblStatus.Text = "Schedule Period: " + info.begindate + " to " + info.enddate;
            }
        }

        private void cmbDate_TextChanged(object sender, EventArgs e)
        {
            pnlCover.Show();
            List<EmployeeSchedule> r = new List<EmployeeSchedule>();
            cmbEmployee1.Items.Clear();
            cmbEmployee2.Items.Clear();
            cmbEmployee3.Items.Clear();
            cmbEmployee4.Items.Clear();
            cmbEmployee5.Items.Clear();
            btnSetter.Show();
            int counter = 0;
            SqlParameter[] idgetter = { new SqlParameter("@sched_id", SchedulePeriodRow.id), new SqlParameter("@date", cmbDate.Text) };

            int id = Convert.ToInt32(SchedulePeriodRow.id);
            List<RotationSchedule> idvalidationview = RotationScheduleHelper.getRotationIDValidaition(idgetter);
            foreach(var testing in idvalidationview)
            {
                SqlParameter[] schedule = { new SqlParameter("rotation_id", testing.rotationId) };
                r = EmployeeScheduleHelper.getEmployeeSchedule(schedule);
                counter = counter + r.Count;
            }
            
            List<RotationSchedule> list = RotationScheduleHelper.getAllRotationSchedule();
            int dater = 0, ider = 0;
            foreach(var c in list)
            {
                if(c.date == cmbDate.Text)
                {
                    dater = 1;
                }

                if(id == c.rotationId)
                {
                    ider = 1;
                }
            }

            if (dater != 1)
            {
                pnlCover.Show();
                lblCoverStatus.Text = "This date doesnt have any RCODE schedule you want to add now?";
                btnSetter.Text = "ADD RCODE";
            }
            else if (dater == 1 && counter == 0)
            {
                lblCoverStatus.Text = "This date already have RCODE schedule, do you want to set" + Environment.NewLine + " schedule to employees?";
                btnSetter.Text = "ADD SCHEDULE TO EMPLOYEES";
            }
            else if(dater == 1 && counter != 0)
            {
                lblCoverStatus.Text = "This date already have a schedule, do you want to view" + Environment.NewLine + " " + cmbDate.Text + " schedule?";
                btnSetter.Text = "VIEW SCHEDULE";
            }
            dater = 0;
            ider = 0;
            counter = 0;
            List<Employee> listEmployee = EmployeeHelper.GetAllEmployees();

            foreach (var ALL in listEmployee)
            {
                ComboBoxItem item = new ComboBoxItem();
                item.Text = ALL.firstName.Trim() + " " + ALL.lastName.Trim();
                //mayong value
                item.Value = ALL.empID;

                cmbEmployee1.Items.Add(item);
                cmbEmployee2.Items.Add(item);
                cmbEmployee3.Items.Add(item);
                cmbEmployee4.Items.Add(item);
                cmbEmployee5.Items.Add(item);
            }
        }

        public void removeOffEmployee()
        {
            SqlParameter[] employeeid = { new SqlParameter("@schedperiodID", SchedulePeriodRow.id), new SqlParameter("@date", cmbDate.Text) };
            List<EmployeeOFF> off = new List<EmployeeOFF>();
            List<Employee> employees = new List<Employee>();

            off = EmployeeOFFHelper.getEmployeeID(employeeid);
            List<int> employee_id = new List<int>();

            SqlParameter[] empidss = { new SqlParameter("@emp_id", EmployeeOFFHelper.emmployee_ID) };
            employees = EmployeeHelper.getOffEmployee(empidss);
            if (employees.Count != 0)
            {
                foreach (var removal in employees)
                {
                    cmbEmployee1.Items.Remove(removal.fullname);
                    cmbEmployee2.Items.Remove(removal.fullname);
                    cmbEmployee3.Items.Remove(removal.fullname);
                    cmbEmployee4.Items.Remove(removal.fullname);
                    cmbEmployee5.Items.Remove(removal.fullname);
                }
            }
            employee_id.Clear();
        }

        private void lblCoverStatus_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void lblCoverStatus_SizeChanged(object sender, EventArgs e)
        {
            lblCoverStatus.Left = (pnlListOfSchedule.ClientSize.Width - lblCoverStatus.Size.Width) / 2;
        }

        private void btnSetter_Click(object sender, EventArgs e)
        {
            scodesss = new List<string>();
            if (btnSetter.Text == "ADD RCODE")
            {
                btnSave.Show();
                btnBack.Show();
                btnSave.Text = "Save Rcode";
                cmbEmployee1.Enabled = true;
                cmbEmployee2.Enabled = true;
                cmbEmployee3.Enabled = true;
                cmbEmployee4.Enabled = true;
                cmbEmployee5.Enabled = true;

                cmbListofRotationCode.Show();
                lblrcode.Text = "";
                pnlCover.Hide();
                lblScode1.Visible = false;
                lblScode2.Visible = false;
                lblScode3.Visible = false;
                lblScode4.Visible = false;
                lblScode5.Visible = false;
                cmbEmployee1.Hide();
                cmbEmployee2.Hide();
                cmbEmployee3.Hide();
                cmbEmployee4.Hide();
                cmbEmployee5.Hide();

                List<RCODE> rcodelist = RcodeHelper.GetAllRcodes();
                cmbListofRotationCode.Items.Clear();
                foreach (var rc in rcodelist)
                {
                    cmbListofRotationCode.Items.Add(rc.rcode);
                    //periodflag = Convert.ToInt32(Regex.Match(rc.desc, @"\d+").Value);
                }
                removeOffEmployee();
            }
            else if (btnSetter.Text == "ADD SCHEDULE TO EMPLOYEES")
            {
                btnSave.Text = "Save Schedule";
                cmbListofRotationCode.Hide();
                btnSave.Show();
                btnBack.Show();
                cmbEmployee1.Enabled = true;
                cmbEmployee2.Enabled = true;
                cmbEmployee3.Enabled = true;
                cmbEmployee4.Enabled = true;
                cmbEmployee5.Enabled = true;
                pnlCover.Hide();
                SqlParameter[] f = { new SqlParameter("@period_id", SchedulePeriodRow.id),
                                     new SqlParameter("@date", cmbDate.Text)};
                List<RotationSchedule> list = RotationScheduleHelper.getRcodeinSchedulerPeriod(f);
                foreach(var c in list)
                {
                    lblrcode.Text = c.rcode;
                    scodesss.Add(c.scode);
                }

                if(scodesss.Count == 5)
                {
                    cmbEmployee1.Hide();
                    cmbEmployee2.Hide();
                    cmbEmployee3.Hide();
                    cmbEmployee4.Hide();
                    cmbEmployee5.Hide();

                    lblScode1.Visible = false;
                    lblScode2.Visible = false;
                    lblScode3.Visible = false;
                    lblScode4.Visible = false;
                    lblScode5.Visible = false;

                    lblScode1.Visible = true;
                    lblScode2.Visible = true;
                    lblScode3.Visible = true;
                    lblScode4.Visible = true;
                    lblScode5.Visible = true;

                    cmbEmployee1.Show();
                    cmbEmployee2.Show();
                    cmbEmployee3.Show();
                    cmbEmployee4.Show();
                    cmbEmployee5.Show();
                    
                    lblScode1.Text = scodesss[0];
                    lblScode2.Text = scodesss[1];
                    lblScode3.Text = scodesss[2];
                    lblScode4.Text = scodesss[3];
                    lblScode5.Text = scodesss[4];
                }
                else if(scodesss.Count == 4)
                {
                    cmbEmployee1.Hide();
                    cmbEmployee2.Hide();
                    cmbEmployee3.Hide();
                    cmbEmployee4.Hide();
                    cmbEmployee5.Hide();

                    lblScode1.Visible = false;
                    lblScode2.Visible = false;
                    lblScode3.Visible = false;
                    lblScode4.Visible = false;
                    lblScode5.Visible = false;

                    lblScode1.Visible = true;
                    lblScode2.Visible = true;
                    lblScode3.Visible = true;
                    lblScode4.Visible = true;

                    cmbEmployee1.Show();
                    cmbEmployee2.Show();
                    cmbEmployee3.Show();
                    cmbEmployee4.Show();

                    lblScode1.Text = scodesss[0];
                    lblScode2.Text = scodesss[1];
                    lblScode3.Text = scodesss[2];
                    lblScode4.Text = scodesss[3];
                }
                else
                {
                    cmbEmployee1.Hide();
                    cmbEmployee2.Hide();
                    cmbEmployee3.Hide();
                    cmbEmployee4.Hide();
                    cmbEmployee5.Hide();

                    lblScode1.Visible = false;
                    lblScode2.Visible = false;
                    lblScode3.Visible = false;
                    lblScode4.Visible = false;
                    lblScode5.Visible = false;

                    lblScode1.Visible = true;
                    lblScode2.Visible = true;
                    lblScode3.Visible = true;

                    cmbEmployee1.Show();
                    cmbEmployee2.Show();
                    cmbEmployee3.Show();

                    lblScode1.Text = scodesss[0];
                    lblScode2.Text = scodesss[1];
                    lblScode3.Text = scodesss[2];
                }
                removeOffEmployee();
            }
            else if (btnSetter.Text == "VIEW SCHEDULE")
            {
                btnBack.Show();
                pnlCover.Hide();
                cmbListofRotationCode.Hide();
                SqlParameter[] f = { new SqlParameter("@period_id", SchedulePeriodRow.id),
                                     new SqlParameter("@date", cmbDate.Text)};
                List<RotationSchedule> list = RotationScheduleHelper.getRcodeinSchedulerPeriod(f);

                foreach(var m in list)
                {
                    lblrcode.Text = m.rcode;
                }

                SqlParameter[] rcode = { new SqlParameter("@rcode", lblrcode.Text) };
                List<RCODE> codes = RcodeHelper.GetSpecificRcodes(rcode);
                foreach(var c in codes)
                {
                    countofscode = Convert.ToInt32(Regex.Match(c.desc, @"\d+").Value);
                    if(countofscode == 5)
                    {
                        scodesss.Add(c.scode1);
                        scodesss.Add(c.scode2);
                        scodesss.Add(c.scode3);
                        scodesss.Add(c.scode4);
                        scodesss.Add(c.scode5);
                    }
                    else if(countofscode == 4)
                    {
                        scodesss.Add(c.scode1);
                        scodesss.Add(c.scode2);
                        scodesss.Add(c.scode3);
                        scodesss.Add(c.scode4);
                        scodesss.Add(c.scode5);
                    }
                    else
                    {
                        scodesss.Add(c.scode1);
                        scodesss.Add(c.scode2);
                        scodesss.Add(c.scode3);
                    }
                    
                }
                List<int> rotationids = new List<int>();
                List<EmployeeSchedule> employeeids = new List<EmployeeSchedule>();
                List<string> employees = new List<string>();
                List<int> empid = new List<int>();

                for (int i = 0; i < countofscode; i++)
                {
                    SqlParameter[] first = { new SqlParameter("@schedid", SchedulePeriodRow.id),
                                     new SqlParameter("@rcode", lblrcode.Text),
                                     new SqlParameter("@scode_id", scodesss[i]),
                                     new SqlParameter("@dates", cmbDate.Text)
                               
                               };
                    rotationids.Add(RotationScheduleHelper.getRotationID(first));
                }
                
                for(int i = 0; i < rotationids.Count; i++)
                {
                    SqlParameter[] s = { new SqlParameter("@rot_id", rotationids[i]) };
                    employeeids = EmployeeScheduleHelper.getEmployeeID(s);
                    foreach(var k in employeeids)
                    {
                        empid.Add(k.emp_id);
                    }
                    
                }
                for(int i = 0; i< empid.Count; i++)
                {
                    SqlParameter[] empidss = { new SqlParameter("@emp_id", empid[i]) };
                    employees.Add(EmployeeHelper.getSpecificEmployee(empidss));
                }

                cmbEmployee1.Enabled = false;
                cmbEmployee2.Enabled = false;
                cmbEmployee3.Enabled = false;
                cmbEmployee4.Enabled = false;
                cmbEmployee5.Enabled = false;

                if(employees.Count == 5)
                {
                    cmbEmployee1.Text = employees[0];
                    cmbEmployee2.Text = employees[1];
                    cmbEmployee3.Text = employees[2];
                    cmbEmployee4.Text = employees[3];
                    cmbEmployee5.Text = employees[4];
                }
                else if(employees.Count == 4)
                {
                    cmbEmployee1.Text = employees[0];
                    cmbEmployee2.Text = employees[1];
                    cmbEmployee3.Text = employees[2];
                    cmbEmployee4.Text = employees[3];
                }
                else
                {
                    cmbEmployee1.Text = employees[0];
                    cmbEmployee2.Text = employees[1];
                    cmbEmployee3.Text = employees[2];
                }
                rotationids.Clear();
                employeeids.Clear();
                employees.Clear();
                empid.Clear();

                btnSave.Hide();
                SqlParameter[] x = { new SqlParameter("@rcode", lblrcode.Text) };
                List<RCODE> y = RcodeHelper.GetSpecificRcodes(x);
                foreach (var r in y)
                {
                    int flag;
                    flag = Convert.ToInt32(Regex.Match(r.desc, @"\d+").Value);
                    if (flag == 5)
                    {
                        cmbEmployee1.Hide();
                        cmbEmployee2.Hide();
                        cmbEmployee3.Hide();
                        cmbEmployee4.Hide();
                        cmbEmployee5.Hide();

                        lblScode1.Visible = false;
                        lblScode2.Visible = false;
                        lblScode3.Visible = false;
                        lblScode4.Visible = false;
                        lblScode5.Visible = false;

                        lblScode1.Visible = true;
                        lblScode2.Visible = true;
                        lblScode3.Visible = true;
                        lblScode4.Visible = true;
                        lblScode5.Visible = true;

                        cmbEmployee1.Show();
                        cmbEmployee2.Show();
                        cmbEmployee3.Show();
                        cmbEmployee4.Show();
                        cmbEmployee5.Show();

                        lblScode1.Text = r.scode1;
                        lblScode2.Text = r.scode2;
                        lblScode3.Text = r.scode3;
                        lblScode4.Text = r.scode4;
                        lblScode5.Text = r.scode5;
                    }
                    else if (flag == 4)
                    {
                        cmbEmployee1.Hide();
                        cmbEmployee2.Hide();
                        cmbEmployee3.Hide();
                        cmbEmployee4.Hide();
                        cmbEmployee5.Hide();

                        lblScode1.Visible = false;
                        lblScode2.Visible = false;
                        lblScode3.Visible = false;
                        lblScode4.Visible = false;
                        lblScode5.Visible = false;

                        lblScode1.Visible = true;
                        lblScode2.Visible = true;
                        lblScode3.Visible = true;
                        lblScode4.Visible = true;

                        cmbEmployee1.Show();
                        cmbEmployee2.Show();
                        cmbEmployee3.Show();
                        cmbEmployee4.Show();
                        cmbEmployee5.Hide();

                        lblScode1.Text = r.scode1;
                        lblScode2.Text = r.scode2;
                        lblScode3.Text = r.scode3;
                        lblScode4.Text = r.scode4;
                    }
                    else if (flag == 3)
                    {
                        cmbEmployee1.Hide();
                        cmbEmployee2.Hide();
                        cmbEmployee3.Hide();
                        cmbEmployee4.Hide();
                        cmbEmployee5.Hide();

                        lblScode1.Visible = false;
                        lblScode2.Visible = false;
                        lblScode3.Visible = false;
                        lblScode4.Visible = false;
                        lblScode5.Visible = false;

                        lblScode1.Visible = true;
                        lblScode2.Visible = true;
                        lblScode3.Visible = true;

                        cmbEmployee1.Show();
                        cmbEmployee2.Show();
                        cmbEmployee3.Show();
                        cmbEmployee4.Hide();
                        cmbEmployee5.Hide();

                        lblScode1.Text = r.scode1;
                        lblScode2.Text = r.scode2;
                        lblScode3.Text = r.scode3;
                    }

                }

            }
            lblCoverStatus.Text = "Please choose a date";
            countofscode = scodesss.Count();
            
        }

        private void btnSetter_SizeChanged(object sender, EventArgs e)
        {
            btnSetter.Left = (pnlListOfSchedule.ClientSize.Width - btnSetter.Size.Width) / 2;
        }

        private void cmbEmployee1_TextChanged(object sender, EventArgs e)
        {
            //int id = Convert.ToInt32((cmbEmployee1.SelectedItem as ComboBoxItem).Value.ToString());
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            List<int> rotationids = new List<int>();
            List<int> employeeids = new List<int>();
            List<string> scodesparts = new List<string>();
            if(btnSave.Text == "Save Schedule")
            {
                DialogResult dia = MessageBox.Show("Are you sure you want to save this Employees? Once you saved it, it cannot be change", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                
                if(dia == DialogResult.Yes)
                {
                try
                {
                    int scodenum = 0;
                    try
                    {
                        foreach (ComboBox c in pnlEmployeeList.Controls)
                        {
                            employeeids.Add(Convert.ToInt32((c.SelectedItem as ComboBoxItem).Value.ToString()));
                        }
                    }
                    catch (Exception)
                    {

                    }
                    foreach(Label c in pnlScodeList.Controls)
                    {
                        if(c.Visible == true)
                        {
                            scodenum++;
                            scodesparts.Add(c.Text);
                        }
                    }
                    if(btnSetter.Text == "ADD RCODE")
                    {
                        for (int i = 0; i < scodenum; i++)
                        {
                            SqlParameter[] first = { new SqlParameter("@schedid", SchedulePeriodRow.id),
                                     new SqlParameter("@rcode", cmbListofRotationCode.Text),
                                     new SqlParameter("@scode_id", scodesparts[i]),
                                     new SqlParameter("@dates", cmbDate.Text)
                               
                               };
                            rotationids.Add(RotationScheduleHelper.getRotationID(first));
                        }
                    }
                    else
                    {
                        for (int i = 0; i < scodenum; i++)
                        {
                            SqlParameter[] first = { new SqlParameter("@schedid", SchedulePeriodRow.id),
                                     new SqlParameter("@rcode", lblrcode.Text),
                                     new SqlParameter("@scode_id", scodesparts[i]),
                                     new SqlParameter("@dates", cmbDate.Text)
                               
                               };
                            rotationids.Add(RotationScheduleHelper.getRotationID(first));
                        }
                    }

                    for (int i = 0; i < rotationids.Count; i++)
                    {
                        EmployeeSchedule c = new EmployeeSchedule();
                        c.rotationID = rotationids[i];
                        c.emp_id = employeeids[i];
                        EmployeeScheduleHelper.SaveEmployeeSchedule(c);
                    }
                    SchedulePeriodRow.loadScheds();
                    MessageBox.Show("Schedule's saved succesfully!");
                    cmbEmployee1.Enabled = false;
                    cmbEmployee2.Enabled = false;
                    cmbEmployee3.Enabled = false;
                    cmbEmployee4.Enabled = false;
                    cmbEmployee5.Enabled = false;
                    scodenum = 0;
                    schedulePeriodMenu.LoadSchedulerPeriod();
                }
                catch (Exception)
                {
                    MessageBox.Show("Schedule saving fail");
                }
                }
                else
                {
                    return;
                }
                rotationids.Clear();
                employeeids.Clear();
                scodesparts.Clear();
            }
            else if(btnSave.Text == "Save Rcode")
            {
                List<string> scodes = new List<string>();
                DialogResult res = MessageBox.Show("Are you sure you want to save this RCODE? After you saved it, cannot be change","Confirmation",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
                if (res == DialogResult.Yes)
                {
                    SqlParameter[] rrrcccc = { new SqlParameter("@rcode", cmbListofRotationCode.Text) };
                    List<RCODE> sss = RcodeHelper.GetSpecificRcodes(rrrcccc);

                    foreach (var i in sss)
                    {
                        if (Convert.ToInt32(Regex.Match(i.desc, @"\d+").Value) == 5)
                        {
                            scodes.Add(i.scode1);
                            scodes.Add(i.scode2);
                            scodes.Add(i.scode3);
                            scodes.Add(i.scode4);
                            scodes.Add(i.scode5);
                        }
                        else if (Convert.ToInt32(Regex.Match(i.desc, @"\d+").Value) == 4)
                        {
                            scodes.Add(i.scode1);
                            scodes.Add(i.scode2);
                            scodes.Add(i.scode3);
                            scodes.Add(i.scode4);
                        }
                        else
                        {
                            scodes.Add(i.scode1);
                            scodes.Add(i.scode2);
                            scodes.Add(i.scode3);
                        }

                    }
                    Schedule_Period.saveScheduleForADay(SchedulePeriodRow.id, cmbListofRotationCode.Text, cmbDate.Text, scodes);

                    int flag = 0;
                    SqlParameter[] rcode = { new SqlParameter("@rcode", cmbListofRotationCode.Text) };
                    List<RCODE> codes = RcodeHelper.GetSpecificRcodes(rcode);
                    foreach (var sc in codes)
                    {
                        flag = Convert.ToInt32(Regex.Match(sc.desc, @"\d+").Value);
                        if (flag == 5)
                        {
                            lblScode1.Text = sc.scode1;
                            lblScode2.Text = sc.scode2;
                            lblScode3.Text = sc.scode3;
                            lblScode4.Text = sc.scode4;
                            lblScode5.Text = sc.scode5;
                        }
                        else if (flag == 4)
                        {
                            lblScode1.Text = sc.scode1;
                            lblScode2.Text = sc.scode2;
                            lblScode3.Text = sc.scode3;
                            lblScode4.Text = sc.scode4;
                            lblScode5.Text = "scode1";
                        }
                        else
                        {
                            lblScode1.Text = sc.scode1;
                            lblScode2.Text = sc.scode2;
                            lblScode3.Text = sc.scode3;
                            lblScode4.Text = "scode4";
                            lblScode5.Text = "scode5";
                        }
                    }

                    if (flag == 5)
                    {
                        lblScode1.Visible = true;
                        lblScode2.Visible = true;
                        lblScode3.Visible = true;
                        lblScode4.Visible = true;
                        lblScode5.Visible = true;
                        cmbEmployee1.Show();
                        cmbEmployee2.Show();
                        cmbEmployee3.Show();
                        cmbEmployee4.Show();
                        cmbEmployee5.Show();
                    }
                    else if (flag == 4)
                    {
                        lblScode1.Visible = true;
                        lblScode2.Visible = true;
                        lblScode3.Visible = true;
                        lblScode4.Visible = true;
                        lblScode5.Visible = false;
                        cmbEmployee1.Show();
                        cmbEmployee2.Show();
                        cmbEmployee3.Show();
                        cmbEmployee4.Show();
                        cmbEmployee5.Hide();
                    }
                    else
                    {
                        lblScode1.Visible = true;
                        lblScode2.Visible = true;
                        lblScode3.Visible = true;
                        lblScode4.Visible = false;
                        lblScode5.Visible = false;
                        cmbEmployee1.Show();
                        cmbEmployee2.Show();
                        cmbEmployee3.Show();
                        cmbEmployee4.Hide();
                        cmbEmployee5.Hide();
                    }
                    btnSave.Text = "Save Schedule";
                }
                else
                {
                    return;
                }
                scodes.Clear();
                
            }
            countofscode = 0;
        }

        private void cmbListofRotationCode_TextChanged(object sender, EventArgs e)
        {
            //btnSave.Text = "Save Rcode";
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            btnPrintSchedule.Hide();
            btnSetter.Hide();
            pnlRegistration.Hide();
            btnAdd.Show();
            btnAdd.Text = "ADD NEW SCHEDULER PERIOD";
            btnCancel.Hide();
            pnlSchedulingHead.Hide();
            pnlSchedulingBody.Hide();
            pnlListOfSchedule.Show();
            pnlHeadDisplay.Show();
            schedulePeriodMenu.LoadSchedulerPeriod();
        }

        private void btnPrintSchedule_Click(object sender, EventArgs e)
        {
            schedstatus = lblSchedStatus.Text;
            PrintSchedule cs = new PrintSchedule();
            cs.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            pnlHeadDisplay.Show();
            pnlListOfSchedule.Show();
            pnlRegistration.Hide();
            btnCancel.Hide();
            btnAdd.Text = "ADD NEW SCHEDULER PERIOD";
            this.Hide();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if(lblSchedStatus.Text == "Open")
            {
                if(SchedulePeriodRow.lbl[0].Text != "7/7")
                {
                    MessageBox.Show("You cant change the status to close because its not yet filled with schedule");
                }
                else
                {
                    Schedule_PeriodHelper.changeSchedulePeriodStatus("Close", Convert.ToInt32(SchedulePeriodRow.lbl[3].Text));
                    MessageBox.Show("Schedule status changed to CLOSED");
                    lblSchedStatus.Text = "Close";
                    btnPrintSchedule.Hide();
                    btnSetter.Hide();
                    pnlRegistration.Hide();
                    btnCancel.Hide();
                    btnAdd.Show();
                    btnAdd.Text = "ADD NEW SCHEDULER PERIOD";
                    pnlSchedulingHead.Hide();
                    pnlSchedulingBody.Hide();
                    pnlListOfSchedule.Show();
                    pnlHeadDisplay.Show();
                    LoadSchedulerPeriod();
                }
            }
        }

        private void label8_Click(object sender, EventArgs e)
        {
            if (cmbDate.SelectedIndex < cmbDate.Items.Count - 1)
            {
                cmbDate.SelectedIndex = cmbDate.SelectedIndex + 1;
            }
        }

        private void label7_Click(object sender, EventArgs e)
        {
            if (cmbDate.SelectedIndex > 0)
            {
                cmbDate.SelectedIndex = cmbDate.SelectedIndex - 1;
            }
        }

        private void btnDayOff_Click(object sender, EventArgs e)
        {
            SetEmployeeDayOff s = new SetEmployeeDayOff();
            s.Show();
        }


        //employees
    }
}
