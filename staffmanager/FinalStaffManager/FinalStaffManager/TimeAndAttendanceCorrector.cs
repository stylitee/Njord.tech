using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using FinalStaffManager.Class;
using System.Data.SqlClient;
using FinalStaffManager.Forms;

namespace FinalStaffManager
{
    public partial class TimeAndAttendanceCorrector : UserControl
    {
        public TimeAndAttendanceCorrector()
        {
            InitializeComponent();
        }
        const int gap = 5;
        int allflags = 0;
        List<ImportedAttendance> control = new List<ImportedAttendance>();
        List<string> dates = new List<string>();
        List<string> times = new List<string>();
        List<int> datecount = new List<int>();
        List<string> nameswithid = new List<string>();
        List<string> names = new List<string>();
        List<string> specificname = new List<string>();
        List<string> alldatesnow = new List<String>();
        public static int employeeidhere = 0;
        public static string empFullName = "";
        public static List<ComboBox> cmb = new List<ComboBox>();
        string filename;
        DateTime sDate, eDate;
        private void btnImport_Click(object sender, EventArgs e)
        {
            cmbNames.Items.Clear();
            cmbNames.ResetText();
            cmbDates.Items.Clear();
            cmbDates.ResetText();
            pnlAttendance.Controls.Clear();
            names.Clear();
            nameswithid.Clear();

            OpenFileDialog opendatfile = new OpenFileDialog();
            opendatfile.Title = "Select Attendance File";
            if (opendatfile.ShowDialog() == DialogResult.OK)
            {
                filename = opendatfile.FileName;

                List<string> lines = File.ReadAllLines(filename).ToList();
                foreach (var attendance in lines)
                {
                    string[] entries = attendance.Split(',', '-');
                    if(dates.Count == 0)
                    {
                        dates.Add(entries[6].Trim());
                        if (nameswithid.Count == 0)
                        {
                            nameswithid.Add(entries[1].Trim() + "-" + entries[2].Trim() + ", " + entries[3].Trim() + ", " + entries[4].Trim());
                            names.Add(entries[2].Trim() + ", " + entries[3].Trim() + ", " + entries[4].Trim());
                        }
                        else
                        {
                            if (nameswithid.Contains(entries[1].Trim() + "-" + entries[2].Trim() + ", " + entries[3].Trim() + ", " + entries[4].Trim()))
                            {
                                continue;
                            }
                            else
                            {
                                nameswithid.Add(entries[1].Trim() + "-" + entries[2].Trim() + ", " + entries[3].Trim() + ", " + entries[4].Trim());
                                names.Add(entries[2].Trim() + ", " + entries[3].Trim() + ", " + entries[4].Trim());
                            }
                        }

                    }
                    else
                    {
                        if (dates.Contains(entries[6].Trim()))
                        {
                            if (nameswithid.Count == 0)
                            {
                                nameswithid.Add(entries[1].Trim() + "-" + entries[2].Trim() + ", " + entries[3].Trim() + ", " + entries[4].Trim());
                                names.Add(entries[2].Trim() + ", " + entries[3].Trim() + ", " + entries[4].Trim());
                            }
                            else
                            {
                                if (nameswithid.Contains(entries[1].Trim() + "-" + entries[2].Trim() + ", " + entries[3].Trim() + ", " + entries[4].Trim()))
                                {
                                    continue;
                                }
                                else
                                {
                                    nameswithid.Add(entries[1].Trim() + "-" + entries[2].Trim() + ", " + entries[3].Trim() + ", " + entries[4].Trim());
                                    names.Add(entries[2].Trim() + ", " + entries[3].Trim() + ", " + entries[4].Trim());
                                }
                            }
                            continue;
                        }
                        else
                        {
                            dates.Add(entries[6].Trim());
                            if (nameswithid.Count == 0)
                            {
                                nameswithid.Add(entries[1].Trim() + "-" + entries[2].Trim() + ", " + entries[3].Trim() + ", " + entries[4].Trim());
                                names.Add(entries[2].Trim() + ", " + entries[3].Trim() + ", " + entries[4].Trim());
                            }
                            else
                            {
                                if (nameswithid.Contains(entries[1].Trim() + "-" + entries[2].Trim() + ", " + entries[3].Trim() + ", " + entries[4].Trim()))
                                {
                                    continue;
                                }
                                else
                                {
                                    nameswithid.Add(entries[1].Trim() + "-" + entries[2].Trim() + ", " + entries[3].Trim() + ", " + entries[4].Trim());
                                    names.Add(entries[2].Trim() + ", " + entries[3].Trim() + ", " + entries[4].Trim());
                                }
                            }

                        }
                    }
                    
                }
            }
            else
            {
                return;
            }

            string complete1stdates = "", complete2nddates = "";
            string inputtedDate = Path.GetFileName(filename);
            string month = inputtedDate.Substring(0, 2);
            string beginning = inputtedDate.Substring(2, 2);
            string end = inputtedDate.Substring(4, 2);
            string year = inputtedDate.Substring(6, 4);

            string beginningdate = beginning + month + year;
            string comeplete1stdate = beginningdate.Insert(2, "/");
            string endingDate = end + month + year;
            string complete2nddate = endingDate.Insert(2, "/");
            complete1stdates = comeplete1stdate.Insert(5, "/");
            complete2nddates = complete2nddate.Insert(5, "/");

            sDate = DateTime.Parse(complete1stdates);
            eDate = DateTime.Parse(complete2nddates);

            btnImport.Text = Path.GetFileName(filename);
            btnLoad.Enabled = true;
        }

        
        private void button1_Click(object sender, EventArgs e)
        {
            AttendanceLoaded();
        }

        private void TimeAndAttendanceCorrector_Load(object sender, EventArgs e)
        {
            btnLoad.Enabled = false;
            cmb.Add(cmbDates);
            cmb.Add(cmbNames);
        }

        private void comboBox1_TextChanged(object sender, EventArgs e)
        {
            int count = 0;
            List<AllImportedAttendance> list = new List<AllImportedAttendance>();
            List<string> date = new List<string>();
            try
            {
                specificname.Clear();
                string name = cmbNames.Text;
                var d = File.ReadAllLines(filename);
                var t = d.Where(g => g.Contains(name));
                string[] splited;
                foreach (var item in t)
                {
                    splited = item.Split(new string[] { name }, StringSplitOptions.None); ;
                    specificname.Add(splited[1]);
                    allflags = 1;
                }
                AttendanceLoaded();
                int id = Convert.ToInt32((cmbNames.SelectedItem as ComboBoxItem).Value.ToString());
                //if else na pag igwa na syang same attendance dae na sya masave

                foreach (ImportedAttendance c in pnlAttendance.Controls)
                {
                    SqlParameter[] datas = {new SqlParameter("@empid",      id),
                                             new SqlParameter("@dates",      c.lblDate.Text)};
                    list = ImportedAttendanceHelper.checkDatesForData(datas);
                }


                if (ImportedAttendanceHelper.flag == 0)
                {
                    AllImportedAttendance attendance = new AllImportedAttendance();
                    List<string> temp = new List<string>();
                    foreach (ImportedAttendance c in pnlAttendance.Controls)
                    {
                        if (c.txt1stam.Text != "--------------")
                        {
                            attendance.saveActualAttendance(id, c.lblDate.Text, c.txt1stam.Text, c.txt1stpm.Text, c.txt2ndam.Text, c.txt2ndpm.Text,
                                c.txt1stovertime.Text, c.txt2ndovertime.Text);
                        }
                        else
                        {
                            continue;
                        }

                    }
                }
                else
                {
                    return;
                }
                count = 0;
                ImportedAttendanceHelper.flag = 0;
            }
            catch (Exception)
            {
                return;
            }
            
        }
       
        private void attendanceCorrector()
        {
            List<string> tempdates = new List<string>();
            int num = 1, mynum = 1;
            if (allflags == 0 )
            {
                attendanceCorrectorProcess();
                alldatesnow.Clear();
                control.Clear();
            }
            else if(allflags == 1)
            {
                pnlAttendance.Controls.Clear();
                attendanceCorrectorProcess();
                tempdates.Clear();

                foreach (ImportedAttendance c in pnlAttendance.Controls)
                {
                    c.lblItem.Text = mynum.ToString();
                    tempdates.Add(c.lblDate.Text);
                    control.Add(c);
                    mynum++;
                }

                foreach (var dater in alldatesnow)
                {
                    if(tempdates.Contains(dater))
                    {
                        continue;
                    }
                    else
                    {
                        var attend = new ImportedAttendance();
                        attend.lblDate.Text = dater;
                        attend.lblItem.Text = mynum.ToString();
                        attend.txt1stam.Text = "--------------";
                        attend.txt1stam.ReadOnly = true;
                        attend.txt1stpm.Text = "--------------";
                        attend.txt1stpm.ReadOnly = true;
                        attend.txt2ndam.Text = "--------------";
                        attend.txt2ndam.ReadOnly = true;
                        attend.txt2ndpm.Text = "--------------";
                        attend.txt2ndpm.ReadOnly = true;
                        attend.txt1stovertime.Text = "--------------";
                        attend.txt1stovertime.ReadOnly = true;
                        attend.Top = 1 * (attend.Height + gap);
                        attend.txt2ndovertime.Text = "--------------";
                        attend.txt2ndovertime.ReadOnly = true;
                        mynum++;
                        control.Add(attend);
                    }
                }
                pnlAttendance.Controls.Clear();
                control.Sort();
                foreach (ImportedAttendance c in control)
                {
                    c.lblItem.Text = num.ToString();
                    pnlAttendance.Controls.Add(c);
                    num++;
                }
                alldatesnow.Clear();
                control.Clear();
                tempdates.Clear();
                num = 1;
            }
                
        }

        private void attendanceCorrectorProcess()
        {
            int item = 1, index = 0, flag = 1, identifier = 0, num = 0;
            identifier = alldatesnow.Count - dates.Count;
            if(allflags == 1)
            {
                switch (num)
                {
                    case 0:
                        if (dates.Contains(alldatesnow[index]))
                        {
                            int i = 0;
                            foreach (var oras in times)
                            {
                                string[] everytime = oras.Split(',', '-');
                                int result = everytime.Count(x => x.Contains(':'));
                                if (result == 1)
                                {

                                    var attend = new ImportedAttendance();
                                    attend.lblDate.Text = everytime[0].Trim();
                                    attend.lblItem.Text = item.ToString();
                                    attend.txt1stam.Text = everytime[1].Trim();
                                    attend.txt1stam.ReadOnly = true;
                                    attend.Top = 1 * (attend.Height + gap);
                                    pnlAttendance.Controls.Add(attend);
                                    item++;
                                }
                                else if (result == 2)
                                {
                                    var attend = new ImportedAttendance();
                                    attend.lblDate.Text = everytime[0].Trim();
                                    attend.lblItem.Text = item.ToString();
                                    attend.txt1stam.Text = everytime[1].Trim();
                                    attend.txt1stam.ReadOnly = true;
                                    attend.txt1stpm.Text = everytime[2].Trim();
                                    attend.txt1stpm.ReadOnly = true;
                                    attend.Top = 1 * (attend.Height + gap);
                                    pnlAttendance.Controls.Add(attend);
                                    item++;
                                }
                                else if (result == 3)
                                {
                                    var attend = new ImportedAttendance();
                                    attend.lblDate.Text = everytime[0].Trim();
                                    attend.lblItem.Text = item.ToString();
                                    attend.txt1stam.Text = everytime[1].Trim();
                                    attend.txt1stam.ReadOnly = true;
                                    attend.txt1stpm.Text = everytime[2].Trim();
                                    attend.txt1stpm.ReadOnly = true;
                                    attend.txt2ndam.Text = everytime[3].Trim();
                                    attend.txt2ndam.ReadOnly = true;
                                    attend.Top = 1 * (attend.Height + gap);
                                    pnlAttendance.Controls.Add(attend);
                                    item++;
                                }
                                else if (result == 4)
                                {
                                    var attend = new ImportedAttendance();
                                    attend.lblDate.Text = everytime[0].Trim();
                                    attend.lblItem.Text = item.ToString();
                                    attend.txt1stam.Text = everytime[1].Trim();
                                    attend.txt1stam.ReadOnly = true;
                                    attend.txt1stpm.Text = everytime[2].Trim();
                                    attend.txt1stpm.ReadOnly = true;
                                    attend.txt2ndam.Text = everytime[3].Trim();
                                    attend.txt2ndam.ReadOnly = true;
                                    attend.txt2ndpm.Text = everytime[4].Trim();
                                    attend.txt2ndpm.ReadOnly = true;
                                    attend.Top = 1 * (attend.Height + gap);
                                    pnlAttendance.Controls.Add(attend);
                                    item++;
                                }
                                else if (result == 5)
                                {
                                    var attend = new ImportedAttendance();
                                    attend.lblDate.Text = everytime[0].Trim();
                                    attend.lblItem.Text = item.ToString();
                                    attend.txt1stam.Text = everytime[1].Trim();
                                    attend.txt1stam.ReadOnly = true;
                                    attend.txt1stpm.Text = everytime[2].Trim();
                                    attend.txt1stpm.ReadOnly = true;
                                    attend.txt2ndam.Text = everytime[3].Trim();
                                    attend.txt2ndam.ReadOnly = true;
                                    attend.txt2ndpm.Text = everytime[4].Trim();
                                    attend.txt2ndpm.ReadOnly = true;
                                    attend.txt1stovertime.Text = everytime[5].Trim();
                                    attend.txt1stovertime.ReadOnly = true;
                                    attend.Top = 1 * (attend.Height + gap);
                                    pnlAttendance.Controls.Add(attend);
                                    item++;
                                }
                                else if (result == 6)
                                {
                                    var attend = new ImportedAttendance();
                                    attend.lblDate.Text = everytime[0].Trim();
                                    attend.lblItem.Text = item.ToString();
                                    attend.txt1stam.Text = everytime[1].Trim();
                                    attend.txt1stam.ReadOnly = true;
                                    attend.txt1stpm.Text = everytime[2].Trim();
                                    attend.txt1stpm.ReadOnly = true;
                                    attend.txt2ndam.Text = everytime[3].Trim();
                                    attend.txt2ndam.ReadOnly = true;
                                    attend.txt2ndpm.Text = everytime[4].Trim();
                                    attend.txt2ndpm.ReadOnly = true;
                                    attend.txt1stovertime.Text = everytime[5].Trim();
                                    attend.txt1stovertime.ReadOnly = true;
                                    attend.Top = 1 * (attend.Height + gap);
                                    attend.txt2ndovertime.Text = everytime[6].Trim();
                                    attend.txt2ndovertime.ReadOnly = true;
                                    pnlAttendance.Controls.Add(attend);
                                    item++;
                                }
                                flag = times.Count;
                            }
                            item = 1;
                            index = dates.IndexOf(times[times.Count - 1]);
                        }
                        else
                        {
                            if (flag < identifier)
                            {
                                var attend = new ImportedAttendance();
                                attend.lblDate.Text = alldatesnow[index].Trim();
                                attend.lblItem.Text = item.ToString();
                                attend.txt1stam.Text = "--------------";
                                attend.txt1stam.ReadOnly = true;
                                attend.txt1stpm.Text = "--------------";
                                attend.txt1stpm.ReadOnly = true;
                                attend.txt2ndam.Text = "--------------";
                                attend.txt2ndam.ReadOnly = true;
                                attend.txt2ndpm.Text = "--------------";
                                attend.txt2ndpm.ReadOnly = true;
                                attend.txt1stovertime.Text = "--------------";
                                attend.txt1stovertime.ReadOnly = true;
                                attend.Top = 1 * (attend.Height + gap);
                                attend.txt2ndovertime.Text = "--------------";
                                attend.txt2ndovertime.ReadOnly = true;
                                pnlAttendance.Controls.Add(attend);
                                item++;
                                index++;
                                goto case 0;
                            }
                            else if (index == alldatesnow.Count - 1)
                            {
                                break;
                            }
                        }

                        break;
                }
                index = 0;
            }
            else if(allflags == 0)
            {
                foreach (var oras in times)
                {
                    string[] everytime = oras.Split(',', '-');
                    int result = everytime.Count(x => x.Contains(':'));
                    if (result == 1)
                    {

                        var attend = new ImportedAttendance();
                        attend.lblDate.Text = everytime[0].Trim();
                        attend.lblItem.Text = item.ToString();
                        attend.txt1stam.Text = everytime[1].Trim();
                        attend.txt1stam.ReadOnly = true;
                        attend.Top = 1 * (attend.Height + gap);
                        pnlAttendance.Controls.Add(attend);
                        item++;
                    }
                    else if (result == 2)
                    {
                        var attend = new ImportedAttendance();
                        attend.lblDate.Text = everytime[0].Trim();
                        attend.lblItem.Text = item.ToString();
                        attend.txt1stam.Text = everytime[1].Trim();
                        attend.txt1stam.ReadOnly = true;
                        attend.txt1stpm.Text = everytime[2].Trim();
                        attend.txt1stpm.ReadOnly = true;
                        attend.Top = 1 * (attend.Height + gap);
                        pnlAttendance.Controls.Add(attend);
                        item++;
                    }
                    else if (result == 3)
                    {
                        var attend = new ImportedAttendance();
                        attend.lblDate.Text = everytime[0].Trim();
                        attend.lblItem.Text = item.ToString();
                        attend.txt1stam.Text = everytime[1].Trim();
                        attend.txt1stam.ReadOnly = true;
                        attend.txt1stpm.Text = everytime[2].Trim();
                        attend.txt1stpm.ReadOnly = true;
                        attend.txt2ndam.Text = everytime[3].Trim();
                        attend.txt2ndam.ReadOnly = true;
                        attend.Top = 1 * (attend.Height + gap);
                        pnlAttendance.Controls.Add(attend);
                        item++;
                    }
                    else if (result == 4)
                    {
                        var attend = new ImportedAttendance();
                        attend.lblDate.Text = everytime[0].Trim();
                        attend.lblItem.Text = item.ToString();
                        attend.txt1stam.Text = everytime[1].Trim();
                        attend.txt1stam.ReadOnly = true;
                        attend.txt1stpm.Text = everytime[2].Trim();
                        attend.txt1stpm.ReadOnly = true;
                        attend.txt2ndam.Text = everytime[3].Trim();
                        attend.txt2ndam.ReadOnly = true;
                        attend.txt2ndpm.Text = everytime[4].Trim();
                        attend.txt2ndpm.ReadOnly = true;
                        attend.Top = 1 * (attend.Height + gap);
                        pnlAttendance.Controls.Add(attend);
                        item++;
                    }
                    else if (result == 5)
                    {
                        var attend = new ImportedAttendance();
                        attend.lblDate.Text = everytime[0].Trim();
                        attend.lblItem.Text = item.ToString();
                        attend.txt1stam.Text = everytime[1].Trim();
                        attend.txt1stam.ReadOnly = true;
                        attend.txt1stpm.Text = everytime[2].Trim();
                        attend.txt1stpm.ReadOnly = true;
                        attend.txt2ndam.Text = everytime[3].Trim();
                        attend.txt2ndam.ReadOnly = true;
                        attend.txt2ndpm.Text = everytime[4].Trim();
                        attend.txt2ndpm.ReadOnly = true;
                        attend.txt1stovertime.Text = everytime[5].Trim();
                        attend.txt1stovertime.ReadOnly = true;
                        attend.Top = 1 * (attend.Height + gap);
                        pnlAttendance.Controls.Add(attend);
                        item++;
                    }
                    else if (result == 6)
                    {
                        var attend = new ImportedAttendance();
                        attend.lblDate.Text = everytime[0].Trim();
                        attend.lblItem.Text = item.ToString();
                        attend.txt1stam.Text = everytime[1].Trim();
                        attend.txt1stam.ReadOnly = true;
                        attend.txt1stpm.Text = everytime[2].Trim();
                        attend.txt1stpm.ReadOnly = true;
                        attend.txt2ndam.Text = everytime[3].Trim();
                        attend.txt2ndam.ReadOnly = true;
                        attend.txt2ndpm.Text = everytime[4].Trim();
                        attend.txt2ndpm.ReadOnly = true;
                        attend.txt1stovertime.Text = everytime[5].Trim();
                        attend.txt1stovertime.ReadOnly = true;
                        attend.Top = 1 * (attend.Height + gap);
                        attend.txt2ndovertime.Text = everytime[6].Trim();
                        attend.txt2ndovertime.ReadOnly = true;
                        pnlAttendance.Controls.Add(attend);
                        item++;
                    }
                }
                item = 1;
            }
        }

        private void AttendanceLoaded()
        {
            if(allflags == 0)
            {
                foreach(var pangalan in nameswithid)
                {
                    string[] splitter = pangalan.Split('-');
                    ComboBoxItem item = new ComboBoxItem();
                    item.Text = splitter[1];
                    //mayong value
                    item.Value = Convert.ToInt32(splitter[0]);
                    cmbNames.Items.Add(item);
                }

                for (var dt = sDate; dt <= eDate; dt = dt.AddDays(1))
                {
                    alldatesnow.Add(dt.ToString("MM/dd/yyyy"));
                }

                foreach(var availdate in alldatesnow)
                {
                    ComboBoxItem item = new ComboBoxItem();
                    item.Text = availdate;

                    cmbDates.Items.Add(item);
                }
                string temptime = "";
                int numberOfRecords = 0, index = 0, flag = 0, count = 1;
                datecount.Clear();
                dates.Clear();
                times.Clear();
                foreach (var namer in names)
                {

                    var d = File.ReadAllLines(filename);
                    var t = d.Where(g => g.Contains(namer));
                    string[] splited;
                    foreach (var item in t)
                    {
                        splited = item.Split(new string[] { namer }, StringSplitOptions.None); ;
                        specificname.Add(splited[1]);
                        allflags = 1;
                    }
                    foreach (var uses in specificname)
                    {
                        string[] entries = uses.Split(',');
                        if (dates.Count == 0)
                        {
                            dates.Add(entries[2].Trim());

                        }
                        else
                        {
                            if (dates.Contains(entries[2].Trim()))
                            {
                                continue;
                            }
                            else
                            {
                                dates.Add(entries[2].Trim());

                            }
                        }
                    }
                    for (int i = 0; i <= dates.Count() - 1; i++)
                    {
                        numberOfRecords = specificname.Count(x => x.Contains(dates[i]));
                        datecount.Add(numberOfRecords);
                    }
                    foreach (var attendance in specificname)
                    {
                        string[] entries = attendance.Split(',', '-');
                        string thisdate = dates[index].Replace(",", string.Empty);
                        if (thisdate == entries[2].Trim())
                        {
                            temptime = temptime + entries[1].Trim() + ",";

                            if (count < datecount[index])
                            {
                                flag++;
                                count++;
                                continue;
                            }
                            else
                            {
                                temptime = dates[index] + "- " + temptime;

                                times.Add(temptime);
                                temptime = "";
                                index++;
                                flag = 0;
                                count = 1;
                            }
                        }
                    }
                    index = 0;
                    allflags = 0;
                    attendanceCorrector();
                    specificname.Clear();
                    dates.Clear();
                    datecount.Clear();
                    times.Clear();
                }
            }
            else if(allflags == 1)
            {
                for (var dt = sDate; dt <= eDate; dt = dt.AddDays(1))
                {
                    alldatesnow.Add(dt.ToString("MM/dd/yyyy"));
                }
                datecount.Clear();
                dates.Clear();
                times.Clear();
                foreach (var uses in specificname)
                {
                    string[] entries = uses.Split(',');
                    if (dates.Count == 0)
                    {
                        dates.Add(entries[2].Trim());

                    }
                    else
                    {
                        if (dates.Contains(entries[2].Trim()))
                        {
                            continue;
                        }
                        else
                        {
                            dates.Add(entries[2].Trim());

                        }
                    }
                }
                string temptime = "";
                int numberOfRecords = 0, index = 0, flag = 0, count = 1;
                for (int i = 0; i <= dates.Count() - 1; i++)
                {
                    numberOfRecords = specificname.Count(x => x.Contains(dates[i]));
                    datecount.Add(numberOfRecords);
                }
                foreach (var attendance in specificname)
                {
                    string[] entries = attendance.Split(',', '-');
                    string thisdate = dates[index].Replace(",", string.Empty);
                    if (thisdate == entries[2].Trim())
                    {
                        temptime = temptime + entries[1].Trim() + ",";

                        if (count < datecount[index])
                        {
                            flag++;
                            count++;
                            continue;
                        }
                        else
                        {
                            temptime = dates[index] + "- " + temptime;

                            times.Add(temptime);
                            temptime = "";
                            index++;
                            flag = 0;
                            count = 1;
                        }
                    }
                    else
                    {
                        MessageBox.Show("alrright");
                    }
                }
                flag = 0;
                pnlAttendance.Controls.Clear();
                attendanceCorrector();
                allflags = 0;
            }

        }

        private void cmbDates_SelectedIndexChanged(object sender, EventArgs e)
        {
            MessageBox.Show(cmbDates.Text);
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            int message = 0;
            DialogResult result = MessageBox.Show("Are you sure you want to save attendance?", "Attention!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if(result == DialogResult.Yes)
            {
                try
                {
                    int id = Convert.ToInt32((cmbNames.SelectedItem as ComboBoxItem).Value.ToString());
                    AllImportedAttendance attendance = new AllImportedAttendance();
                    List<string> temp = new List<string>();
                    foreach (ImportedAttendance c in pnlAttendance.Controls)
                    {
                        if (c.txt1stam.Text != "--------------")
                        {
                            attendance.saveImportedFile(id, c.lblDate.Text, c.txt1stam.Text, c.txt1stpm.Text, c.txt2ndam.Text, c.txt2ndpm.Text,
                                c.txt1stovertime.Text, c.txt2ndovertime.Text);
                            message = 1;
                        }
                        else
                        {
                            continue;
                        }

                    }
                    if (message == 1)
                    {
                        MessageBox.Show("Attendance succesfully saved!", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Saving failed!", "Fail", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception)
                {
                    try
                    {
                        string[] splitter = cmbNames.Text.Split(',');
                        MessageBox.Show("ID number of Employee: " + splitter[1].Trim() + " " + splitter[2].Trim() + ". " + splitter[0].Trim() + " is not found!", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Import an employee file first!", "ERROR",MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    
                }
            }
            else
            {
                return;
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                employeeidhere = Convert.ToInt32((cmbNames.SelectedItem as ComboBoxItem).Value.ToString());
                string[] rearrange = cmbNames.Text.Split(',');
                empFullName = rearrange[1] + " " + rearrange[2] + ". " + rearrange[0];
                AttendanceComaperer viewer = new AttendanceComaperer();
                viewer.Show();
            }
            catch (Exception)
            {
                MessageBox.Show("Please select an employee first!");
                return;
            }

        }

        private void btnImport_TextChanged(object sender, EventArgs e)
        {
            btnImport.Image = null;
        }
    }
}
