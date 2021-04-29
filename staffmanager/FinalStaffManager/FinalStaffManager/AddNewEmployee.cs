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
    public partial class AddNewEmployee : UserControl
    {
        public AddNewEmployee()
        {
            InitializeComponent();
        }
        public static List<Panel> panelist = new List<Panel>();
        
        private void AddNewEmployee_Load(object sender, EventArgs e)
        {
            panelist.Add(pnlListOfEmployee);
            loadList();
        }

        public static void loadList()
        {
            int num = 1;
            int iteration = 0;
            List<Employee> listEmployee = EmployeeHelper.GetAllEmployees();
            int number = iteration + 1;
            if(listEmployee.Count == 0)
            {
                panelist[0].Controls.Clear();
            }
            else
            {
                panelist[0].Controls.Clear();
                foreach (var employee in listEmployee)
                {
                    var ucEmployees = new ucEmployees();
                    ucEmployees.Top = iteration * (ucEmployees.Height + 1);
                    ucEmployees.lblItem.Text = num.ToString();
                    ucEmployees.lblLastName.Text = employee.lastName;
                    ucEmployees.lblFirstName.Text = employee.firstName;
                    ucEmployees.lblMiddleName.Text = employee.middleName;
                    ucEmployees.lblID.Text = employee.empID.ToString();
                    ucEmployees.lblJobName.Text = employee.job.title;
                    if(employee.phoneNumber.Contains(','))
                    {
                        string[] phoneentries = employee.phoneNumber.Split(',');
                        {
                            if(phoneentries[1] == "")
                            {
                                ucEmployees.lblContact.Text = phoneentries[0];
                            }
                            else if (phoneentries[1] != "")
                            {
                                ucEmployees.lblContact.Text = phoneentries[0];
                            }
                        }
                    }
                    else
                    {
                        ucEmployees.lblContact.Text = employee.phoneNumber;
                    }
                    //ucEmployees.lblContact.Text = employee.phoneNumber;
                    ucEmployees.lblMunicipality.Text = employee.ZipCode.Municipality;
                    panelist[0].Controls.Add(ucEmployees);
                    iteration++;
                    num++;
                }
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }
    }
}
