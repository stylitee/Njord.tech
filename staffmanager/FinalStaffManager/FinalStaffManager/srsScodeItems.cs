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

namespace FinalStaffManager
{
    public partial class srsScodeItems : UserControl
    {
        public srsScodeItems()
        {
            InitializeComponent();
        }
        public static string scode;
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            scode = lblCodeName.Text;
            DialogResult result = MessageBox.Show("Are you sure you want to edit this Scode?", "Edit Mode", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                SRSScode.flowelist[0].Hide();
                SRSScode.panelist[0].Show();
                SRSScode.panelist[1].Hide();
                SRSScode.butonist[0].Text = "Update";
                SRSScode.butonist[1].Show();
            }
            else
            {


            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult result = MessageBox.Show("Are you sure you want this scode?", "Scode deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    SCODE.deleteEmployee(lblCodeName.Text);
                    SRSScode.flowelist[0].Controls.Clear();
                    SRSScode.loadScodeList();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("You cannot delete this because it is being used in an rcode, delete the rcode first to delete this scode");
            }

        }
    }
}
