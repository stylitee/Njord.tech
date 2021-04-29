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

namespace FinalStaffManager
{
    public partial class SRSScode : UserControl
    {
        public SRSScode()
        {
            InitializeComponent();
        }
        List<SCODE> setlist = null;
        public static List<Panel> panelist = new List<Panel>();
        public static List<Button> butonist = new List<Button>();
        public static List<Label> labelist = new List<Label>();
        public static List<FlowLayoutPanel> flowelist = new List<FlowLayoutPanel>();
        private void txtFirstShiftIn_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
            (e.KeyChar != ':'))
            {
                e.Handled = true;
            }

            if ((e.KeyChar == ':') && ((sender as TextBox).Text.IndexOf(':') > -1))
            {
                e.Handled = true;
            }
        }

        public static void loadScodeList()
        {
            int i = 1;
            List<SCODE> codelist = ScodeHelper.GetAllScodes();

            foreach(var code in codelist)
            {
                var scodes = new srsScodeItems();
                scodes.lblItem.Text = i.ToString();
                scodes.lblCodeName.Text = code.scode;
                scodes.lblCodeDescription.Text = code.desc;
                scodes.lblFirstTimeIn.Text = code.firstIn;
                scodes.lblFirstOut.Text = code.firstOut;
                scodes.lblSecondIn.Text = code.secondIn;
                scodes.lblSecondOut.Text = code.secondOut;
                flowelist[0].Controls.Add(scodes);
                i++;
            }
        }

        private void SRSScode_Load(object sender, EventArgs e)
        {
            panelist.Add(pnlRegistration);
            panelist.Add(pnlHead);
            flowelist.Add(pnlListofScode);
            labelist.Add(lblStatus);
            butonist.Add(btnSave);
            butonist.Add(btnCancel);
            pnlRegistration.Hide();
            btnCancel.Hide();
            loadScodeList();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if(btnSave.Text == "ADD NEW SCODE")
            {
                DialogResult result = MessageBox.Show("Are you sure yu want to add new Scode?", "Adding of new Scode", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    MessageBox.Show("Time input should be on 24-hour format", "Reminder", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    lblStatus.Text = "New Scode Entry";
                    pnlListofScode.Hide();
                    pnlHead.Hide();
                    pnlRegistration.Show();
                    btnSave.Text = "Save";
                    btnCancel.Show();
                }
                else
                {
                    return;
                }
            }
            else if(btnSave.Text == "Save")
            {
                try
                {
                    TimeSpan earlyshift = TimeSpan.Parse("07:30");
                    TimeSpan outshift = TimeSpan.Parse("21:30");
                    string[] firstshiftIn = txtFirstShiftIn.Text.Split(':');
                    string[] firstshiftOut = txtFirstShiftOut.Text.Split(':');
                    string[] SecondshiftIn = txtSecondShiftIn.Text.Split(':');
                    string[] SecondshiftOut = txtSecondShiftOut.Text.Split(':');

                    int firstShiftInHour = Convert.ToInt32(firstshiftIn[0]);
                    int firstShiftInMinutes = Convert.ToInt32(firstshiftIn[1]);
                    int firstShiftOutHour = Convert.ToInt32(firstshiftOut[0]);
                    int firstShiftOutMinutes = Convert.ToInt32(firstshiftOut[1]);

                    int secondShiftInHour = Convert.ToInt32(SecondshiftIn[0]);
                    int secondShiftInMinutes = Convert.ToInt32(SecondshiftIn[1]);
                    int secondShiftOutHour = Convert.ToInt32(SecondshiftOut[0]);
                    int secondShiftOutMinutes = Convert.ToInt32(SecondshiftOut[1]);

                    var timeSpanFirstShiftIn = new TimeSpan(firstShiftInHour, firstShiftInMinutes, 0);
                    var timeSpanFirstShiftOut = new TimeSpan(firstShiftOutHour, firstShiftOutMinutes, 0);

                    var timeSpanSecondShiftIn = new TimeSpan(secondShiftInHour, secondShiftInMinutes, 0);
                    var timeSpanSecondShiftOut = new TimeSpan(secondShiftOutHour, secondShiftOutMinutes, 0);

                    var totalHoursFistShift = timeSpanFirstShiftOut - timeSpanFirstShiftIn;
                    var totalHoursSecondShift = timeSpanSecondShiftOut - timeSpanSecondShiftIn;
                    var totalHours = totalHoursFistShift + totalHoursSecondShift;

                    var interval1 = new TimeSpan(firstShiftOutHour, firstShiftOutMinutes, 0);
                    var interval2 = new TimeSpan(secondShiftInHour, secondShiftInMinutes, 0);
                    var thirtyminuteInterval = interval2 - interval1;
                    int counter = 0;
                    foreach (Control c in pnlRegistration.Controls)
                    {
                        if (c.Text.Contains(":30"))
                        {
                            counter++;
                        }
                    }

                    DialogResult dia = MessageBox.Show("Are you sure you want to save this new Scode: " + txtScodeDesction.Text + "?",
                                                        "Saving Mode", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dia == DialogResult.Yes)
                    {
                        if (counter >= 1)
                        {
                            if ((int)totalHours.TotalHours > 8 && (int)totalHours.TotalHours < 14)
                            {
                                if ((int)thirtyminuteInterval.Minutes <= 30)
                                {
                                    if (timeSpanFirstShiftIn >= earlyshift && timeSpanSecondShiftOut <= outshift)
                                    {
                                        SCODE.SaveScode(txtScodeTitle, txtScodeDesction, txtFirstShiftIn, txtFirstShiftOut,
                                                        txtSecondShiftIn, txtSecondShiftOut);
                                        clearTextBoxes();
                                        pnlListofScode.Controls.Clear();
                                        loadScodeList();
                                    }
                                    else
                                    {
                                        MessageBox.Show("Morning shift in must not be 7:30am and out must not be over 21:30 (24-hour format)", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    }
                                }
                                else
                                {
                                    MessageBox.Show("There should be atleast 30 minutes break between two shifts!", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                            }
                            else
                            {
                                MessageBox.Show("The total working hour is " + totalHours.TotalHours.ToString() + ", it must be not less than 8 hours or not more than 14 hours!", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        else
                        {
                            MessageBox.Show("There must be atleast 30 minute interval", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        return;
                    }      
                }
                catch (Exception)
                {
                    MessageBox.Show("Some fields are missing");
                }
                    
            }
            else if(btnSave.Text == "Update")
            {
                DialogResult result = MessageBox.Show("Are you sure you want to save this update?", "Update", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if(result ==  DialogResult.Yes)
                {
                    SCODE.Update(txtScodeTitle, txtScodeDesction, txtFirstShiftIn, txtFirstShiftOut, txtSecondShiftIn, txtSecondShiftOut);
                    clearTextBoxes();
                    pnlListofScode.Controls.Clear();
                    loadScodeList();
                }
            }
            
        }
        private void clearTextBoxes()
        {
            txtScodeTitle.Text = "";
            txtScodeDesction.Text = "";
            txtFirstShiftIn.Text = "";
            txtFirstShiftOut.Text = "";
            txtSecondShiftIn.Text = "";
            txtSecondShiftOut.Text = "";
        }

        private void btnSave_TextChanged(object sender, EventArgs e)
        {
            if(btnSave.Text == "Update")
            {
                populateUpdateTexboxes();
            }
            else
            {
                return;
            }
            
        }

        private void populateUpdateTexboxes()
        {
            string code = srsScodeItems.scode;
            SqlParameter[] p = { new SqlParameter("@code", code) };
            setlist = ScodeHelper.GetSelectedScode(p);

            foreach(var mycode in setlist)
            {
                txtScodeTitle.Text = mycode.scode;
                txtScodeTitle.ReadOnly = true;
                txtScodeDesction.Text = mycode.desc;
                txtFirstShiftIn.Text = mycode.firstIn;
                txtFirstShiftOut.Text = mycode.firstOut;
                txtSecondShiftIn.Text = mycode.secondIn;
                txtSecondShiftOut.Text = mycode.secondOut;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            pnlListofScode.Show();
            pnlHead.Show();
            lblStatus.Text = "List of Scode";
            pnlRegistration.Hide();
            btnCancel.Hide();
            btnSave.Text = "ADD NEW SCODE";
            clearTextBoxes();
        }
    }
}
