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

namespace FinalStaffManager
{
    public partial class Other_Sceduling_Tool : UserControl
    {
        public Other_Sceduling_Tool()
        {
            InitializeComponent();
        }

        private void Other_Sceduling_Tool_Load(object sender, EventArgs e)
        {
            otherSchedulingTool1.Show();
            listofEmployeeForExport1.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            //StreamWriter sw = File.CreateText(@"F:\EMPLOYEE.txt");

            otherSchedulingTool1.Show();
            listofEmployeeForExport1.Hide();
            //sw.WriteLine("");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            otherSchedulingTool1.Hide();
            listofEmployeeForExport1.Show();
        }
    }
}
