using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using FinalStaffManager.Forms;
using FinalStaffManager.Class;

namespace FinalStaffManager
{
    public partial class ucEmployees : UserControl
    {
        public ucEmployees()
        {
            InitializeComponent();
        }
        public static string ID;
        private void btnAction_Click(object sender, EventArgs e)
        {

            ID = lblID.Text;
            DialogResult result = MessageBox.Show("Are you sure you want to edit this Employee?", "Edit Mode", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(result == DialogResult.Yes)
            {
                //find the other control in the parent
                foreach(Control c in UpdateEmployee.panel[0].Controls)
                {
                    if(c.Text == "")
                    {
                        c.Text = ".";
                    }
                }
                UpdateEmployee.user[0].BringToFront();
            }
            else
            {
                

            }
        }

        private void lblItem_Click(object sender, EventArgs e)
        {

        }

        private void ucEmployees_Load(object sender, EventArgs e)
        {
           // employeeMenuStripCRUD1.SendToBack();
            lblID.Hide();
        }

        private void lblFirstName_Click(object sender, EventArgs e)
        {

        }

        private void lblMiddleName_Click(object sender, EventArgs e)
        {

        }

        private void lblLastName_Click(object sender, EventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to delete this employee?", "Delete Employee", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                try
                {
                    EmployeeHelper.DeleteEmployee(Convert.ToInt32(lblID.Text));
                    MessageBox.Show("Employee succesfully deleted", "Deletion succesful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    AddNewEmployee.loadList();
                    ListofEmployeeForExport.loadme();
                }
                catch (Exception)
                {
                    MessageBox.Show("You cant delete this employee unless there is no schedule for this employee", "Fail!", MessageBoxButtons.OK,MessageBoxIcon.Stop);
                }
            }
            else
            {
                return;
            }
        }

        private void center_align(object sender, EventArgs e)
        {

        }
    }
}
