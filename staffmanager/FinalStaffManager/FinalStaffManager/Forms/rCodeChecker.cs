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
    public partial class rCodeChecker : Form
    {
        public rCodeChecker()
        {
            InitializeComponent();
        }
        int flag = 0;
        List<SCODE> scodelist = null;
        private void rCodeChecker_Load(object sender, EventArgs e)
        {
            initialTitle();
            initialColumns();
            populateRows();
            setter();
        }
        public void initialTitle()
        {
            var rcode = new RCODETableParts();
            rcode.lbltitle.Text = "ROTATION CODE " + RcodeMenu.code;
            rcode.lbltitle.Font = new Font(rcode.Font, FontStyle.Bold);
            rcode.BackColor = Color.FromArgb(224, 222, 222);
            rcode.pnlMax3.Hide();
            rcode.pnlMax4.Hide();
            rcode.pnlMax5.Hide();
            flowLayoutRcodeChecker.Controls.Add(rcode);
        }
        public void initialColumns()
        {
            if(RcodeMenu.isUpdate == 0)
            {
                int checker = Convert.ToInt32(RcodeMenu.resultString);
                if (checker == 5)
                {
                    var rcode = new RCODETableParts();
                    rcode.pnlMax5.Show();
                    rcode.pnlMax3.Hide();
                    rcode.pnlMax4.Hide();
                    rcode.lblTime5.Text = "  Time";
                    rcode.lblTime5.Font = new Font(rcode.Font, FontStyle.Bold);
                    rcode.scode5_1.Text = RcodeMenu.scodes[0];
                    rcode.scode5_2.Text = RcodeMenu.scodes[1];
                    rcode.scode5_3.Text = RcodeMenu.scodes[2];
                    rcode.scode5_4.Text = RcodeMenu.scodes[3];
                    rcode.scode5_5.Text = RcodeMenu.scodes[4];
                    rcode.staff5.Text = "STAFF";
                    flowLayoutRcodeChecker.Controls.Add(rcode);
                    flag = 5;
                }
                else if (checker == 4)
                {
                    var rcode = new RCODETableParts();
                    rcode.pnlMax4.Show();
                    rcode.pnlMax3.Hide();
                    rcode.pnlMax5.Hide();
                    rcode.lblTime4.Text = "  Time";
                    rcode.lblTime4.Font = new Font(rcode.Font, FontStyle.Bold);
                    rcode.scode4_1.Text = RcodeMenu.scodes[0];
                    rcode.scode4_2.Text = RcodeMenu.scodes[1];
                    rcode.scode4_3.Text = RcodeMenu.scodes[2];
                    rcode.scode4_4.Text = RcodeMenu.scodes[3];
                    rcode.staff4.Text = "STAFF";
                    flowLayoutRcodeChecker.Controls.Add(rcode);
                    flag = 4;
                }
                else if (checker == 3)
                {
                    var rcode = new RCODETableParts();
                    rcode.pnlMax3.Show();
                    rcode.pnlMax4.Hide();
                    rcode.pnlMax5.Hide();
                    rcode.lblTime3.Text = "  Time";
                    rcode.lblTime3.Font = new Font(rcode.Font, FontStyle.Bold);
                    rcode.scode3_1.Text = RcodeMenu.scodes[0];
                    rcode.scode3_2.Text = RcodeMenu.scodes[1];
                    rcode.scode3_3.Text = RcodeMenu.scodes[2];
                    rcode.staff3.Text = "STAFF";
                    flowLayoutRcodeChecker.Controls.Add(rcode);
                    flag = 3;
                }
            }
            else if(RcodeMenu.isUpdate == 1)
            {
                //
                int checker = Convert.ToInt32(RcodeMenu.temp);
                if (checker == 5)
                {
                    var rcode = new RCODETableParts();
                    rcode.pnlMax5.Show();
                    rcode.pnlMax3.Hide();
                    rcode.pnlMax4.Hide();
                    rcode.lblTime5.Text = "  Time";
                    rcode.lblTime5.Font = new Font(rcode.Font, FontStyle.Bold);
                    rcode.scode5_1.Text = RcodeMenu.scodes[0];
                    rcode.scode5_2.Text = RcodeMenu.scodes[1];
                    rcode.scode5_3.Text = RcodeMenu.scodes[2];
                    rcode.scode5_4.Text = RcodeMenu.scodes[3];
                    rcode.scode5_5.Text = RcodeMenu.scodes[4];
                    rcode.staff5.Text = "STAFF";
                    flowLayoutRcodeChecker.Controls.Add(rcode);
                    flag = 5;
                }
                else if (checker == 4)
                {
                    var rcode = new RCODETableParts();
                    rcode.pnlMax4.Show();
                    rcode.pnlMax3.Hide();
                    rcode.pnlMax5.Hide();
                    rcode.lblTime4.Text = "  Time";
                    rcode.lblTime4.Font = new Font(rcode.Font, FontStyle.Bold);
                    rcode.scode4_1.Text = RcodeMenu.scodes[0];
                    rcode.scode4_2.Text = RcodeMenu.scodes[1];
                    rcode.scode4_3.Text = RcodeMenu.scodes[2];
                    rcode.scode4_4.Text = RcodeMenu.scodes[3];
                    rcode.staff4.Text = "STAFF";
                    flowLayoutRcodeChecker.Controls.Add(rcode);
                    flag = 4;
                }
                else if (checker == 3)
                {
                    var rcode = new RCODETableParts();
                    rcode.pnlMax3.Show();
                    rcode.pnlMax4.Hide();
                    rcode.pnlMax5.Hide();
                    rcode.lblTime3.Text = "  Time";
                    rcode.lblTime3.Font = new Font(rcode.Font, FontStyle.Bold);
                    rcode.scode3_1.Text = RcodeMenu.scodes[0];
                    rcode.scode3_2.Text = RcodeMenu.scodes[1];
                    rcode.scode3_3.Text = RcodeMenu.scodes[2];
                    rcode.staff3.Text = "STAFF";
                    flowLayoutRcodeChecker.Controls.Add(rcode);
                    flag = 3;
                }
            }
            
        }

        public void populateRows()
        {
            int timeflag = 0;
            TimeSpan time = new TimeSpan(7, 30, 0);
            var incremented = new TimeSpan(0,0,0);
            if(flag == 5)
            {
                for (int i = 0; i < 28; i++)
                {
                    var rcode = new RCODETableParts();
                    rcode.pnlMax5.Show();
                    rcode.pnlMax3.Hide();
                    rcode.pnlMax4.Hide();
                    if(timeflag == 0)
                    {
                        incremented = time + TimeSpan.FromMinutes(30);
                        rcode.lblTime5.Text = time.ToString(@"hh\:mm") + "-" + incremented.ToString(@"hh\:mm");
                    }
                    else
                    {
                        var timeme = incremented;
                        incremented = incremented + TimeSpan.FromMinutes(30);
                        rcode.lblTime5.Text = timeme.ToString(@"hh\:mm") + "-" + incremented.ToString(@"hh\:mm");
                        timeflag = 1;
                    }
                    //FIRST SCODE
                    SqlParameter[] a = { new SqlParameter("@code", RcodeMenu.scodes[0]) };
                    scodelist = ScodeHelper.GetSelectedScode(a);
                    foreach(var c in scodelist)
                    {
                        string[] ranges = rcode.lblTime5.Text.Split('-');
                        TimeSpan startRange = TimeSpan.Parse(ranges[0]);
                        TimeSpan endRange = TimeSpan.Parse(ranges[1]);

                        TimeSpan firstIn = TimeSpan.Parse(c.firstIn);
                        TimeSpan firstOut = TimeSpan.Parse(c.firstOut);
                        TimeSpan secondIn = TimeSpan.Parse(c.secondIn);
                        TimeSpan secondOut = TimeSpan.Parse(c.secondOut);
                        if(startRange > firstIn && startRange < firstOut || endRange > firstIn && endRange < firstOut
                            || startRange > secondIn && startRange < secondOut || endRange > secondIn && endRange < secondOut)
                        {
                            rcode.scode5_1.Text = "  1";
                        }
                        else
                        {
                            rcode.scode5_1.Text = "";
                        }
                    }
                    //seconde scode
                    SqlParameter[] b = { new SqlParameter("@code", RcodeMenu.scodes[1]) };
                    scodelist = ScodeHelper.GetSelectedScode(b);
                    foreach (var c in scodelist)
                    {
                        string[] ranges = rcode.lblTime5.Text.Split('-');
                        TimeSpan startRange = TimeSpan.Parse(ranges[0]);
                        TimeSpan endRange = TimeSpan.Parse(ranges[1]);

                        TimeSpan firstIn = TimeSpan.Parse(c.firstIn);
                        TimeSpan firstOut = TimeSpan.Parse(c.firstOut);
                        TimeSpan secondIn = TimeSpan.Parse(c.secondIn);
                        TimeSpan secondOut = TimeSpan.Parse(c.secondOut);
                        if (startRange > firstIn && startRange < firstOut || endRange > firstIn && endRange < firstOut
                            || startRange > secondIn && startRange < secondOut || endRange > secondIn && endRange < secondOut)
                        {
                            rcode.scode5_2.Text = "  1";
                        }
                        else
                        {
                            rcode.scode5_2.Text = "";
                        }
                    }

                    //3rd scode

                    SqlParameter[] h = { new SqlParameter("@code", RcodeMenu.scodes[2]) };
                    scodelist = ScodeHelper.GetSelectedScode(h);
                    foreach (var g in scodelist)
                    {
                        string[] ranges = rcode.lblTime5.Text.Split('-');
                        TimeSpan startRange = TimeSpan.Parse(ranges[0]);
                        TimeSpan endRange = TimeSpan.Parse(ranges[1]);

                        TimeSpan firstIn = TimeSpan.Parse(g.firstIn);
                        TimeSpan firstOut = TimeSpan.Parse(g.firstOut);
                        TimeSpan secondIn = TimeSpan.Parse(g.secondIn);
                        TimeSpan secondOut = TimeSpan.Parse(g.secondOut);
                        if (startRange > firstIn && startRange < firstOut || endRange > firstIn && endRange < firstOut
                            || startRange > secondIn && startRange < secondOut || endRange > secondIn && endRange < secondOut)
                        {
                            rcode.scode5_3.Text = "  1";
                        }
                        else
                        {
                            rcode.scode5_3.Text = "";
                        }
                    }

                    //4th scode

                    SqlParameter[] e = { new SqlParameter("@code", RcodeMenu.scodes[3]) };
                    scodelist = ScodeHelper.GetSelectedScode(e);
                    foreach (var g in scodelist)
                    {
                        string[] ranges = rcode.lblTime5.Text.Split('-');
                        TimeSpan startRange = TimeSpan.Parse(ranges[0]);
                        TimeSpan endRange = TimeSpan.Parse(ranges[1]);

                        TimeSpan firstIn = TimeSpan.Parse(g.firstIn);
                        TimeSpan firstOut = TimeSpan.Parse(g.firstOut);
                        TimeSpan secondIn = TimeSpan.Parse(g.secondIn);
                        TimeSpan secondOut = TimeSpan.Parse(g.secondOut);
                        if (startRange > firstIn && startRange < firstOut || endRange > firstIn && endRange < firstOut
                            || startRange > secondIn && startRange < secondOut || endRange > secondIn && endRange < secondOut)
                        {
                            rcode.scode5_4.Text = "  1";
                        }
                        else
                        {
                            rcode.scode5_4.Text = "";
                        }
                    }

                    //5th
                    SqlParameter[] f = { new SqlParameter("@code", RcodeMenu.scodes[4]) };
                    scodelist = ScodeHelper.GetSelectedScode(f);
                    foreach (var g in scodelist)
                    {
                        string[] ranges = rcode.lblTime5.Text.Split('-');
                        TimeSpan startRange = TimeSpan.Parse(ranges[0]);
                        TimeSpan endRange = TimeSpan.Parse(ranges[1]);

                        TimeSpan firstIn = TimeSpan.Parse(g.firstIn);
                        TimeSpan firstOut = TimeSpan.Parse(g.firstOut);
                        TimeSpan secondIn = TimeSpan.Parse(g.secondIn);
                        TimeSpan secondOut = TimeSpan.Parse(g.secondOut);
                        if (startRange > firstIn && startRange < firstOut || endRange > firstIn && endRange < firstOut
                            || startRange > secondIn && startRange < secondOut || endRange > secondIn && endRange < secondOut)
                        {
                            rcode.scode5_5.Text = "  1";
                        }
                        else
                        {
                            rcode.scode5_5.Text = "";
                        }
                    }
                    int checker = 0;
                    if (rcode.scode5_1.Text == "  1")
                    {
                        checker++;
                    }
                    if (rcode.scode5_2.Text == "  1")
                    {
                        checker++;
                    }
                    if (rcode.scode5_3.Text == "  1")
                    {
                        checker++;
                    }
                    if (rcode.scode5_4.Text == "  1")
                    {
                        checker++;
                    }
                    if (rcode.scode5_5.Text == "  1")
                    {
                        checker++;
                    }
                    rcode.staff5.Text = "   " + checker.ToString();
                    checker = 0;
                    if(Convert.ToInt32(rcode.staff5.Text) < 2)
                    {
                        rcode.BackColor = Color.FromArgb(185, 9, 0);
                    }

                    flowLayoutRcodeChecker.Controls.Add(rcode);
                    timeflag = 1;
                    statusChecker();
                }
            }
            else if(flag == 4)
            {
                for (int i = 0; i < 28; i++)
                {
                    var rcode = new RCODETableParts();
                    rcode.pnlMax5.Hide();
                    rcode.pnlMax3.Hide();
                    rcode.pnlMax4.Show();
                    if (timeflag == 0)
                    {
                        incremented = time + TimeSpan.FromMinutes(30);
                        rcode.lblTime4.Text = time.ToString(@"hh\:mm") + "-" + incremented.ToString(@"hh\:mm");
                    }
                    else
                    {
                        var timeme = incremented;
                        incremented = incremented + TimeSpan.FromMinutes(30);
                        rcode.lblTime4.Text = timeme.ToString(@"hh\:mm") + "-" + incremented.ToString(@"hh\:mm");
                    }
                    //FIRST SCODE
                    SqlParameter[] a = { new SqlParameter("@code", RcodeMenu.scodes[0]) };
                    scodelist = ScodeHelper.GetSelectedScode(a);
                    foreach (var c in scodelist)
                    {
                        string[] ranges = rcode.lblTime4.Text.Split('-');
                        TimeSpan startRange = TimeSpan.Parse(ranges[0]);
                        TimeSpan endRange = TimeSpan.Parse(ranges[1]);

                        TimeSpan firstIn = TimeSpan.Parse(c.firstIn);
                        TimeSpan firstOut = TimeSpan.Parse(c.firstOut);
                        TimeSpan secondIn = TimeSpan.Parse(c.secondIn);
                        TimeSpan secondOut = TimeSpan.Parse(c.secondOut);
                        if (startRange > firstIn && startRange < firstOut || endRange > firstIn && endRange < firstOut
                            || startRange > secondIn && startRange < secondOut || endRange > secondIn && endRange < secondOut)
                        {
                            rcode.scode4_1.Text = "  1";
                        }
                        else
                        {
                            rcode.scode4_1.Text = "";
                        }
                    }
                    //seconde scode
                    SqlParameter[] b = { new SqlParameter("@code", RcodeMenu.scodes[1]) };
                    scodelist = ScodeHelper.GetSelectedScode(b);
                    foreach (var c in scodelist)
                    {
                        string[] ranges = rcode.lblTime4.Text.Split('-');
                        TimeSpan startRange = TimeSpan.Parse(ranges[0]);
                        TimeSpan endRange = TimeSpan.Parse(ranges[1]);

                        TimeSpan firstIn = TimeSpan.Parse(c.firstIn);
                        TimeSpan firstOut = TimeSpan.Parse(c.firstOut);
                        TimeSpan secondIn = TimeSpan.Parse(c.secondIn);
                        TimeSpan secondOut = TimeSpan.Parse(c.secondOut);
                        if (startRange > firstIn && startRange < firstOut || endRange > firstIn && endRange < firstOut
                            || startRange > secondIn && startRange < secondOut || endRange > secondIn && endRange < secondOut)
                        {
                            rcode.scode4_2.Text = "  1";
                        }
                        else
                        {
                            rcode.scode4_2.Text = "";
                        }
                    }

                    //3rd scode

                    SqlParameter[] h = { new SqlParameter("@code", RcodeMenu.scodes[2]) };
                    scodelist = ScodeHelper.GetSelectedScode(h);
                    foreach (var g in scodelist)
                    {
                        string[] ranges = rcode.lblTime4.Text.Split('-');
                        TimeSpan startRange = TimeSpan.Parse(ranges[0]);
                        TimeSpan endRange = TimeSpan.Parse(ranges[1]);

                        TimeSpan firstIn = TimeSpan.Parse(g.firstIn);
                        TimeSpan firstOut = TimeSpan.Parse(g.firstOut);
                        TimeSpan secondIn = TimeSpan.Parse(g.secondIn);
                        TimeSpan secondOut = TimeSpan.Parse(g.secondOut);
                        if (startRange > firstIn && startRange < firstOut || endRange > firstIn && endRange < firstOut
                            || startRange > secondIn && startRange < secondOut || endRange > secondIn && endRange < secondOut)
                        {
                            rcode.scode4_3.Text = "  1";
                        }
                        else
                        {
                            rcode.scode4_3.Text = "";
                        }

                    }

                    //4th scode

                    SqlParameter[] e = { new SqlParameter("@code", RcodeMenu.scodes[3]) };
                    scodelist = ScodeHelper.GetSelectedScode(e);
                    foreach (var g in scodelist)
                    {
                        string[] ranges = rcode.lblTime4.Text.Split('-');
                        TimeSpan startRange = TimeSpan.Parse(ranges[0]);
                        TimeSpan endRange = TimeSpan.Parse(ranges[1]);

                        TimeSpan firstIn = TimeSpan.Parse(g.firstIn);
                        TimeSpan firstOut = TimeSpan.Parse(g.firstOut);
                        TimeSpan secondIn = TimeSpan.Parse(g.secondIn);
                        TimeSpan secondOut = TimeSpan.Parse(g.secondOut);
                        if (startRange > firstIn && startRange < firstOut || endRange > firstIn && endRange < firstOut
                            || startRange > secondIn && startRange < secondOut || endRange > secondIn && endRange < secondOut)
                        {
                            rcode.scode4_4.Text = "  1";
                        }
                        else
                        {
                            rcode.scode4_4.Text = "";
                        }
                    }
                    int checker = 0;
                    if (rcode.scode4_1.Text == "  1")
                    {
                        checker++;
                    }
                    if (rcode.scode4_2.Text == "  1")
                    {
                        checker++;
                    }
                    if (rcode.scode4_3.Text == "  1")
                    {
                        checker++;
                    }
                    if (rcode.scode4_4.Text == "  1")
                    {
                        checker++;
                    }
                    rcode.staff4.Text = "   " + checker.ToString();
                    checker = 0;
                    if (Convert.ToInt32(rcode.staff4.Text) < 2)
                    {
                        rcode.BackColor = Color.FromArgb(185, 9, 0);
                    }
                    statusChecker();
                    flowLayoutRcodeChecker.Controls.Add(rcode);
                    timeflag = 1;
                }
            }
            else if(flag ==  3)
            {
                for (int i = 0; i < 28; i++)
                {
                    var rcode = new RCODETableParts();
                    rcode.pnlMax5.Hide();
                    rcode.pnlMax3.Show();
                    rcode.pnlMax4.Hide();
                    if (timeflag == 0)
                    {
                        incremented = time + TimeSpan.FromMinutes(30);
                        rcode.lblTime3.Text = time.ToString(@"hh\:mm") + "-" + incremented.ToString(@"hh\:mm");
                    }
                    else
                    {
                        var timeme = incremented;
                        incremented = incremented + TimeSpan.FromMinutes(30);
                        rcode.lblTime3.Text = timeme.ToString(@"hh\:mm") + "-" + incremented.ToString(@"hh\:mm");
                    }
                    //FIRST SCODE
                    SqlParameter[] a = { new SqlParameter("@code", RcodeMenu.scodes[0]) };
                    scodelist = ScodeHelper.GetSelectedScode(a);
                    foreach (var c in scodelist)
                    {
                        string[] ranges = rcode.lblTime3.Text.Split('-');
                        TimeSpan startRange = TimeSpan.Parse(ranges[0]);
                        TimeSpan endRange = TimeSpan.Parse(ranges[1]);

                        TimeSpan firstIn = TimeSpan.Parse(c.firstIn);
                        TimeSpan firstOut = TimeSpan.Parse(c.firstOut);
                        TimeSpan secondIn = TimeSpan.Parse(c.secondIn);
                        TimeSpan secondOut = TimeSpan.Parse(c.secondOut);
                        if (startRange > firstIn && startRange < firstOut || endRange > firstIn && endRange < firstOut
                            || startRange > secondIn && startRange < secondOut || endRange > secondIn && endRange < secondOut)
                        {
                            rcode.scode3_1.Text = "  1";
                        }
                        else
                        {
                            rcode.scode3_1.Text = "";
                        }
                    }
                    //seconde scode
                    SqlParameter[] b = { new SqlParameter("@code", RcodeMenu.scodes[1]) };
                    scodelist = ScodeHelper.GetSelectedScode(b);
                    foreach (var c in scodelist)
                    {
                        string[] ranges = rcode.lblTime3.Text.Split('-');
                        TimeSpan startRange = TimeSpan.Parse(ranges[0]);
                        TimeSpan endRange = TimeSpan.Parse(ranges[1]);

                        TimeSpan firstIn = TimeSpan.Parse(c.firstIn);
                        TimeSpan firstOut = TimeSpan.Parse(c.firstOut);
                        TimeSpan secondIn = TimeSpan.Parse(c.secondIn);
                        TimeSpan secondOut = TimeSpan.Parse(c.secondOut);
                        if (startRange > firstIn && startRange < firstOut || endRange > firstIn && endRange < firstOut
                            || startRange > secondIn && startRange < secondOut || endRange > secondIn && endRange < secondOut)
                        {
                            rcode.scode3_2.Text = "  1";
                        }
                        else
                        {
                            rcode.scode3_2.Text = "";
                        }
                    }

                    //3rd scode

                    SqlParameter[] h = { new SqlParameter("@code", RcodeMenu.scodes[2]) };
                    scodelist = ScodeHelper.GetSelectedScode(h);
                    foreach (var g in scodelist)
                    {
                        string[] ranges = rcode.lblTime3.Text.Split('-');
                        TimeSpan startRange = TimeSpan.Parse(ranges[0]);
                        TimeSpan endRange = TimeSpan.Parse(ranges[1]);

                        TimeSpan firstIn = TimeSpan.Parse(g.firstIn);
                        TimeSpan firstOut = TimeSpan.Parse(g.firstOut);
                        TimeSpan secondIn = TimeSpan.Parse(g.secondIn);
                        TimeSpan secondOut = TimeSpan.Parse(g.secondOut);
                        if (startRange > firstIn && startRange < firstOut || endRange > firstIn && endRange < firstOut
                            || startRange > secondIn && startRange < secondOut || endRange > secondIn && endRange < secondOut)
                        {
                            rcode.scode3_3.Text = "  1";
                        }
                        else
                        {
                            rcode.scode3_3.Text = "";
                        }
                    }
                    int checker = 0;
                    if (rcode.scode3_1.Text == "  1")
                    {
                        checker++;
                    }
                    if (rcode.scode3_2.Text == "  1")
                    {
                        checker++;
                    }
                    if (rcode.scode3_3.Text == "  1")
                    {
                        checker++;
                    }
                    rcode.staff3.Text = "   " + checker.ToString();
                    checker = 0;
                    if (Convert.ToInt32(rcode.staff3.Text) < 2)
                    {
                        rcode.BackColor = Color.FromArgb(185, 9, 0);
                    }

                    flowLayoutRcodeChecker.Controls.Add(rcode);
                    timeflag = 1;
                    statusChecker();
                }
            }
            flag = 0;
            timeflag = 0;
        }
        private void statusChecker()
        {
            // to check if there is inadequate amount of employeee
            if (flag == 5)
            {
                int validator = 0, minutes;
                foreach (RCODETableParts c in flowLayoutRcodeChecker.Controls)
                {
                    if (c.staff5.Text.Contains("   2"))
                    {
                        validator++;
                    }
                }
                int timevalidation = 60;
                minutes = 30 * validator;
                if (minutes > timevalidation)
                {
                    foreach (RCODETableParts c in flowLayoutRcodeChecker.Controls)
                    {
                        if (c.staff5.Text.Contains("   2"))
                        {
                            c.BackColor = Color.FromArgb(255, 163, 0);
                        }
                    }
                }
            }
            else if(flag == 4)
            {
                int validator = 0, minutes;
                foreach (RCODETableParts c in flowLayoutRcodeChecker.Controls)
                {
                    if (c.staff5.Text.Contains("   2"))
                    {
                        validator++;
                    }
                }
                int timevalidation = 120;
                minutes = 30 * validator;
                if (minutes > timevalidation)
                {
                    foreach (RCODETableParts c in flowLayoutRcodeChecker.Controls)
                    {
                        if (c.staff5.Text.Contains("   2"))
                        {
                            c.BackColor = Color.FromArgb(255, 163, 0);
                        }
                    }
                }
            }
            else if(flag == 3)
            {
                int validator = 0, minutes;
                foreach (RCODETableParts c in flowLayoutRcodeChecker.Controls)
                {
                    if (c.staff5.Text.Contains("   2"))
                    {
                        validator++;
                    }
                }
                int timevalidation = 150;
                minutes = 30 * validator;
                if (minutes > timevalidation)
                {
                    foreach (RCODETableParts c in flowLayoutRcodeChecker.Controls)
                    {
                        if (c.staff5.Text.Contains("   2"))
                        {
                            c.BackColor = Color.FromArgb(255, 163, 0);
                        }
                    }
                }
            }
        }

        private void btnDone_Click(object sender, EventArgs e)
        {
            string name = "", desc = "";
            string temp = "", temp1 = "";
            name = RcodeMenu.txt[0].Text;
            desc = RcodeMenu.cmb[0].Text;
            if(btnDone.Text == "Save")
            {
                if(RcodeMenu.scodes.Count == 5)
                {
                    RCODE.saveRcode(name, desc, RcodeMenu.scodes[0], RcodeMenu.scodes[1], RcodeMenu.scodes[2], RcodeMenu.scodes[3], RcodeMenu.scodes[4], RcodeMenu.scodes.Count);
                    RcodeMenu.updateRcodes();
                }
                else if(RcodeMenu.scodes.Count == 4)
                {

                    RCODE.saveRcode(name, desc, RcodeMenu.scodes[0], RcodeMenu.scodes[1], RcodeMenu.scodes[2], RcodeMenu.scodes[3], temp, RcodeMenu.scodes.Count);
                    RcodeMenu.updateRcodes();
                }
                else if(RcodeMenu.scodes.Count == 3)
                {
                    RCODE.saveRcode(name, desc, RcodeMenu.scodes[0], RcodeMenu.scodes[1], RcodeMenu.scodes[2], temp1, temp, RcodeMenu.scodes.Count);
                    RcodeMenu.updateRcodes();
                }
                RcodeMenu.scodes.Clear();
                this.Close();
            }
            else if(btnDone.Text == "Back")
            {
                RcodeMenu.scodes.Clear();
                this.Close();
            }
            else if(btnDone.Text == "Update")
            {
                if (RcodeMenu.scodes.Count == 5)
                {
                    RCODE.UpdateRcode(name, desc, RcodeMenu.scodes[0], RcodeMenu.scodes[1], RcodeMenu.scodes[2], RcodeMenu.scodes[3], RcodeMenu.scodes[4], RcodeMenu.scodes.Count);
                }
                else if (RcodeMenu.scodes.Count == 4)
                {

                    RCODE.UpdateRcode(name, desc, RcodeMenu.scodes[0], RcodeMenu.scodes[1], RcodeMenu.scodes[2], RcodeMenu.scodes[3], temp, RcodeMenu.scodes.Count);
                }
                else if (RcodeMenu.scodes.Count == 3)
                {
                    RCODE.UpdateRcode(name, desc, RcodeMenu.scodes[0], RcodeMenu.scodes[1], RcodeMenu.scodes[2], temp1, temp, RcodeMenu.scodes.Count);
                }
                RcodeMenu.scodes.Clear();
                this.Close();
            }
        }

        private void setter()
        {
            int i = 0;
            foreach (RCODETableParts c in flowLayoutRcodeChecker.Controls)
            {
                if (c.BackColor == Color.FromArgb(185, 9, 0) || c.BackColor == Color.FromArgb(255, 163, 0))
                {
                    i++;
                }
            }
            if (i == 0 && RcodeMenu.flag == 1)
            {
                btnDone.Text = "Save";
                RcodeMenu.flag = 0;
            }
            else if (i == 0 && RcodeMenu.flag == 2)
            {
                btnDone.Text = "Update";
                RcodeMenu.flag = 0;
            }
            else
            {
                btnDone.Text = "Back";
                RcodeMenu.flag = 0;
            }
        }

    }
}
