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
    public partial class EmployeeFileManager : UserControl
    {
        public EmployeeFileManager()
        {
            InitializeComponent();
        }
        public static List<UserControl> myuser = new List<UserControl>();
        public static int flag = 0;
        private void EmployeeFileManager_Load_1(object sender, EventArgs e)
        {
            myuser.Add(updateEmployee1);
            addNewEmployee1.BringToFront();
        }
        AddEmployee wew = new AddEmployee();
        private void btnAddEmployee_Click(object sender, EventArgs e)
        {
            addEmployee1.BringToFront();
        }

        public void btnListEmployee_Click(object sender, EventArgs e)
        {
            addNewEmployee1.BringToFront();
        }
    }
}
