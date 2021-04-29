using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalStaffManager
{
    public partial class StaffRotationSchedulerMenu : UserControl
    {
        public StaffRotationSchedulerMenu()
        {
            InitializeComponent();
        }

        private void btnScodeMenu_Click(object sender, EventArgs e)
        {
            srsScode1.Show();
            rcodeMenu1.Hide();
            schedulePeriodMenu1.Hide();
        }

        private void btnRcodeMenu_Click(object sender, EventArgs e)
        {
            srsScode1.Hide();
            rcodeMenu1.Show();
            schedulePeriodMenu1.Hide();
        }

        private void StaffRotationSchedulerMenu_Load(object sender, EventArgs e)
        {
            srsScode1.BringToFront();
        }

        private void btnSchedPeriod_Click(object sender, EventArgs e)
        {
            schedulePeriodMenu1.Show();
            srsScode1.Hide();
            rcodeMenu1.Hide();
        }

        private void schedulePeriodMenu1_Load(object sender, EventArgs e)
        {

        }

        private void btnOthers_Click(object sender, EventArgs e)
        {

        }
    }
}
