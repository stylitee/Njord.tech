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
    public partial class RCODE_Display : UserControl
    {
        public RCODE_Display()
        {
            InitializeComponent();
        }
        public static string rcode;
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            DialogResult dia = MessageBox.Show("Are you sure you want to update " + lblRcode.Text + "?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(dia == DialogResult.Yes)
            {
                rcode = lblRcode.Text;
                RcodeMenu.lbl[0].Text = "Update";
                RcodeMenu.pnl[0].Hide();
                RcodeMenu.flp[0].Hide();
                RcodeMenu.pnl[1].Show();
                RcodeMenu.btn[0].Show();
                RcodeMenu.btn[0].Text = "Update";
                RcodeMenu.btn[1].Show();
                RcodeMenu.btn[1].Text = "Cancel";
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if(MessageBox.Show("Are you sure you want to delete this RCODE","Any changes you canno revert the changes that you make",MessageBoxButtons.YesNo,MessageBoxIcon.Question)== DialogResult.Yes)
                {
                    RcodeHelper.DeleteRcode(lblRcode.Text);
                    RcodeMenu.updateRcodes();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("You cant delete this RCODE because it is already being used in an schedule period", "Deletion Fail", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
