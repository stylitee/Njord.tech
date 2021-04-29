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
    public partial class ListOfEmployeeRows : UserControl
    {
        public ListOfEmployeeRows()
        {
            InitializeComponent();
        }
        //ListofEmployeeForExport.import.Add(lblID.Text + ", " + lblLast.Text + ", " + lblMiddle.Text.Substring(0, 1));
        public static string names = "";
        public static int i = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            if(lblMiddle.Text == "")
            {
                names = lblID.Text + ", " + lblLast.Text + ", " + lblFirsst.Text + ", ";
            }
            else
            {
                names = lblID.Text + ", " + lblLast.Text + ", " + lblFirsst.Text + ", " + lblMiddle.Text.Substring(0, 1);
            }
            
            i++;
            ListofEmployeeForExport.lbl[0].Text = i.ToString();
        }
    }
}
