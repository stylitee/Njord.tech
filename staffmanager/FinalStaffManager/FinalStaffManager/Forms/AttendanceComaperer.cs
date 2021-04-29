using FinalStaffManager.Class;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalStaffManager.Forms
{
    public partial class AttendanceComaperer : Form
    {
        public AttendanceComaperer()
        {
            InitializeComponent();
        }
        List<string> scodelisted = new List<string>();
        private void AttendanceComaperer_Load(object sender, EventArgs e)
        {
            titleHeader();
            Actualload();
            CtitleHeader();
            CorrectedLoad();
            loadOtherInfo();
        }
        
        private void Actualload()
        {
            int item = 1, scodeitem = 0;
            int id = TimeAndAttendanceCorrector.employeeidhere;
            List<string> date = new List<string>();
            List<AllImportedAttendance> list = new List<AllImportedAttendance>();
            List<string> scodeAndRcode = new List<string>();
            for(int i = 0; i < 15; i++)
            {
                date.Add(TimeAndAttendanceCorrector.cmb[0].Items[i].ToString());
            }

            for (int i = 0; i < 15; i++)
            {
                SqlParameter[] datas = {new SqlParameter("@empid",      id),
                                             new SqlParameter("@dates",      date[i])};
                string[] revertdates = date[i].Split('/');
                string rightdate = revertdates[1] + "/" + revertdates[0] + "/" + revertdates[2]; 
                SqlParameter[] ss = {new SqlParameter("@emp_id",      id),
                                             new SqlParameter("@date",      rightdate)};
                list = ImportedAttendanceHelper.checkDatesForData(datas);
                scodeAndRcode = ImportedAttendanceHelper.selectRcodeAndScode(ss);
                foreach(var c in list)
                {
                    var control = new AttendanceComapererViewerRow();
                    control.lblItem.Text = item.ToString();
                    control.lblDate.Text = c.date;
                    control.fIn.Text = c.firstShiftIn;
                    control.fOut.Text = c.firstShiftOut;
                    control.sIn.Text = c.secondShiftIn;
                    control.sOut.Text = c.secondShiftOut;
                    control.overIn.Text = c.overtimeIn;
                    control.overOut.Text = c.overtimeOut;
                    //if (ImportedAttendanceHelper.scodes.Count != 0)
                    //{
                    //    control.lblScode.Text = ImportedAttendanceHelper.scodes[scodeitem];
                    //    scodelisted.Add(ImportedAttendanceHelper.scodes[scodeitem]);

                    //}

                    flpActual.Controls.Add(control);
                    item++;
                    scodeitem++;
                }
                
            }
            ImportedAttendanceHelper.scodes.Clear();
            scodeitem = 0;
            item = 1;

        }

        private void CorrectedLoad()
        {
            int item = 1, scodeitem = 0;
            int id = TimeAndAttendanceCorrector.employeeidhere;
            List<string> date = new List<string>();
            List<AllImportedAttendance> list = new List<AllImportedAttendance>();
            for (int i = 0; i < 15; i++)
            {
                date.Add(TimeAndAttendanceCorrector.cmb[0].Items[i].ToString());
            }

            for (int i = 0; i < 15; i++)
            {

                SqlParameter[] datas = {new SqlParameter("@empid",      id),
                                             new SqlParameter("@dates",      date[i])};
                list = ImportedAttendanceHelper.checkforDatainCorrected(datas);
                foreach (var c in list)
                {
                    var control = new AttendanceComapererViewerRow();
                    control.lblItem.Text = item.ToString();
                    control.lblDate.Text = c.date;
                    control.fIn.Text = c.firstShiftIn;
                    control.fOut.Text = c.firstShiftOut;
                    control.sIn.Text = c.secondShiftIn;
                    control.sOut.Text = c.secondShiftOut;
                    control.overIn.Text = c.overtimeIn;
                    control.overOut.Text = c.overtimeOut;
                    //if (ImportedAttendanceHelper.scodes.Count != 0)
                    //{
                    //    control.lblScode.Text = ImportedAttendanceHelper.scodes[scodeitem];

                    //}

                    flpCorrected.Controls.Add(control);
                    item++;
                    scodeitem++;
                }

            }
            scodeitem = 0;
            item = 1;

        }

        public void loadOtherInfo()
        {
            try
            {
                int totallate = 0, totalovertime = 0;
                List<SCODE> scodelist = new List<SCODE>();
                foreach (AttendanceComapererViewerRow c in flpCorrected.Controls)
                {
                    string secondshiftInValue = "";
                    SqlParameter[] h = { new SqlParameter("@code", c.lblScode.Text) };
                    scodelist = ScodeHelper.GetSelectedScode(h);
                    foreach (var attendancescode in scodelist)
                    {
                        string[] time = attendancescode.secondIn.Split(':');
                        TimeSpan start = new TimeSpan(12, 0, 0);
                        TimeSpan end = new TimeSpan(23, 59, 0);
                        TimeSpan current = new TimeSpan(Convert.ToInt32(time[0]), Convert.ToInt32(time[1]), 0);
                        if ((current > start) && (current < end))
                        {
                            DateTime d = DateTime.Parse(attendancescode.secondIn + " PM");
                            secondshiftInValue = d.ToString("HH:mm");
                        }
                        else
                        {
                            secondshiftInValue = attendancescode.secondIn;
                        }
                        //computation for late

                        string[] fin = attendancescode.firstIn.Split(':');
                        string[] sin = secondshiftInValue.Split(':');

                        string[] afin = c.fIn.Text.Split(':');
                        string[] asin = c.sIn.Text.Split(':');
                        TimeSpan firstshiftInSched = new TimeSpan(Convert.ToInt32(fin[0]), Convert.ToInt32(fin[1]), 0);
                        TimeSpan ActfirstshiftInSched = new TimeSpan(Convert.ToInt32(afin[0]), Convert.ToInt32(afin[1]), 0);

                        TimeSpan secondshiftInSched = new TimeSpan(Convert.ToInt32(sin[0]), Convert.ToInt32(sin[1]), 0);
                        TimeSpan ActsecondshiftInSched = new TimeSpan(Convert.ToInt32(asin[0]), Convert.ToInt32(asin[1]), 0);

                        if (firstshiftInSched < ActfirstshiftInSched)
                        {
                            var timefin = ActfirstshiftInSched - firstshiftInSched;
                            string[] timesplitter = timefin.ToString().Split(':');
                            totallate = totallate + Convert.ToInt32(timesplitter[1]);
                        }

                        if (secondshiftInSched < ActsecondshiftInSched)
                        {
                            var timesin = ActsecondshiftInSched - secondshiftInSched;
                            string[] timesplitter = timesin.ToString().Split(':');
                            totallate = totallate + Convert.ToInt32(timesplitter[1]);
                        }

                        //computation for overtime
                        TimeSpan overtimeInnn = new TimeSpan();
                        TimeSpan overtimeOuttt = new TimeSpan();
                        int overtimeflag1 = 0, overtimeflag2 = 0;
                        string[] fOut = attendancescode.firstOut.Split(':');
                        string[] sout = attendancescode.secondOut.Split(':');
                        if (c.overIn.Text != "" || c.overIn.Text != null)
                        {
                            string[] overtimeIn = c.overIn.Text.Split(':');
                            overtimeInnn = new TimeSpan(Convert.ToInt32(overtimeIn[0]), Convert.ToInt32(overtimeIn[1]), 0);
                            overtimeflag1 = 1;
                        }

                        if (c.overOut.Text != "" || c.overOut.Text != null)
                        {
                            string[] overtimeOut = c.overOut.Text.Split(':');
                            overtimeOuttt = new TimeSpan(Convert.ToInt32(overtimeOut[0]), Convert.ToInt32(overtimeOut[1]), 0);
                            overtimeflag2 = 1;
                        }

                        if (overtimeflag1 == 1 && overtimeflag2 == 1)
                        {
                            var total = overtimeOuttt - overtimeInnn;
                            string[] timesplitter = total.ToString().Split(':');
                            totalovertime = totalovertime + Convert.ToInt32(timesplitter[1]);
                        }


                        string[] afOut = c.fOut.Text.Split(':');
                        string[] asOut = c.sOut.Text.Split(':');
                        TimeSpan firstshiftOutSched = new TimeSpan(Convert.ToInt32(fOut[0]), Convert.ToInt32(fOut[1]), 0);
                        TimeSpan ActfirstshiftOutSched = new TimeSpan(Convert.ToInt32(afOut[0]), Convert.ToInt32(afOut[1]), 0);

                        TimeSpan secondshiftOutSched = new TimeSpan(Convert.ToInt32(sout[0]), Convert.ToInt32(sout[1]), 0);
                        TimeSpan ActsecondshiftOutSched = new TimeSpan(Convert.ToInt32(asOut[0]), Convert.ToInt32(asOut[1]), 0);

                        if (firstshiftOutSched < ActfirstshiftOutSched)
                        {
                            var timefin = ActfirstshiftOutSched - firstshiftOutSched;
                            string[] timesplitter = timefin.ToString().Split(':');
                            totalovertime = totalovertime + Convert.ToInt32(timesplitter[1]);
                        }

                        if (secondshiftOutSched < ActsecondshiftOutSched)
                        {
                            var timesin = ActsecondshiftOutSched - secondshiftOutSched;
                            string[] timesplitter = timesin.ToString().Split(':');
                            totalovertime = totalovertime + Convert.ToInt32(timesplitter[1]);
                        }
                    }
                    lblEmployeeID.Text = TimeAndAttendanceCorrector.employeeidhere.ToString();
                    EmployeeFullName.Text = TimeAndAttendanceCorrector.cmb[1].Text;
                    lblLate.Text = totallate.ToString();
                    lblOvertime.Text = totalovertime.ToString();
                    totallate = 0;
                    totalovertime = 0;
                }
            }
            catch (Exception)
            {
               
                
            }
            
        }

        public void titleHeader()
        {
            var control = new AttendanceComapererViewerRow();
            control.BackColor = Color.LightGray;
            control.lblItem.Text = "No.";
            control.lblDate.Text = "Date:";
            control.fIn.Text = "1stShift(In)";
            control.fOut.Text = "1stShift(Out)";
            control.sIn.Text = "2ndShift(In)";
            control.sOut.Text = "2ndShift(Out)";
            control.overIn.Text = "Overtime(In)";
            control.overOut.Text = "Overtime(Out)";
            control.lblScode.Text = "SCODE";
            flpActual.Controls.Add(control);
        }

        public void CtitleHeader()
        {
            var control = new AttendanceComapererViewerRow();
            control.BackColor = Color.LightGray;
            control.lblItem.Text = "No.";
            control.lblDate.Text = "Date:";
            control.fIn.Text = "1stShift(In)";
            control.fOut.Text = "1stShift(Out)";
            control.sIn.Text = "2ndShift(In)";
            control.sOut.Text = "2ndShift(Out)";
            control.overIn.Text = "Overtime(In)";
            control.overOut.Text = "Overtime(Out)";
            control.lblScode.Text = "SCODE";
            flpCorrected.Controls.Add(control);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
