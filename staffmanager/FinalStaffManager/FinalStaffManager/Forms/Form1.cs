using FinalStaffManager.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalStaffManager
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            home1.BringToFront();
            timer1.Start();
            lblDate.Text = DateTime.Now.ToLongDateString();
            lblTime.Text = DateTime.Now.ToLongTimeString();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            home1.BringToFront();
        }

        private void btnEmployee_Click(object sender, EventArgs e)
        {
            employeeFileManager1.BringToFront();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timeAndAttendanceCorrector1.BringToFront();
        }

        private void btnStaffRotationScheduler_Click(object sender, EventArgs e)
        {
            staffRotationMenu.BringToFront();
            SchedulePeriodRow.loadstatus();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            other_Sceduling_Tool1.BringToFront();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Start();
            lblDate.Text = DateTime.Now.ToLongDateString();
            lblTime.Text = DateTime.Now.ToLongTimeString();
        }

        private void other_Sceduling_Tool1_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            PrintSchedule f = new PrintSchedule();
            f.Show();
        }
    }
}
