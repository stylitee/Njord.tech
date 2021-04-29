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
using System.IO;

namespace FinalStaffManager
{
    public partial class ListofEmployeeForExport : UserControl
    {
        public ListofEmployeeForExport()
        {
            InitializeComponent();
        }
        public static List<string> import = new List<string>();
        public static List<Label> lbl = new List<Label>();
        public static List<FlowLayoutPanel> flp = new List<FlowLayoutPanel>();
        string name = "";
        private void ListofEmployeeForExport_Load(object sender, EventArgs e)
        {
            load();
            lbl.Add(lblCount);
            flp.Add(flpListOfEmployee);
        }

        public void load()
        {
            List<Employee> listEmployee = EmployeeHelper.GetAllEmployees();
            foreach (var ALL in listEmployee)
            {
                var l = new ListOfEmployeeRows();
                l.lblFirsst.Text = ALL.firstName;
                l.lblMiddle.Text = ALL.middleName;
                l.lblLast.Text = ALL.lastName;
                l.lblID.Text = ALL.empID.ToString();

                flpListOfEmployee.Controls.Add(l);
            }
        }

        public static void loadme()
        {
            flp[0].Controls.Clear();
            List<Employee> listEmployee = EmployeeHelper.GetAllEmployees();
            foreach (var ALL in listEmployee)
            {
                var l = new ListOfEmployeeRows();
                l.lblFirsst.Text = ALL.firstName;
                l.lblMiddle.Text = ALL.middleName;
                l.lblLast.Text = ALL.lastName;
                l.lblID.Text = ALL.empID.ToString();

                flp[0].Controls.Add(l);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(lblCount.Text != "0")
            {
                if (MessageBox.Show("Are you sure you want to Export selected employees?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    import.Add(name);
                    try
                    {
                        foreach (var c in import)
                        {
                            using (StreamWriter sw = File.CreateText(@"D:\employee.txt"))
                            {
                                sw.WriteLine(c);
                            }
                        }
                    }
                    catch (DirectoryNotFoundException)
                    {
                        MessageBox.Show("No flash drive found! Please insert a flash drive first before proceeding", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }

                    MessageBox.Show("Export Done!");
                    ListOfEmployeeRows.names = "";
                    ListOfEmployeeRows.i = 0;
                    name = "";
                    lblCount.Text = "0";
                }
                else
                {
                    return;
                }
            }
            else
            {
                MessageBox.Show("No employee selected!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            
            
        }

        private void lblCount_TextChanged(object sender, EventArgs e)
        {
            name = name + ListOfEmployeeRows.names + Environment.NewLine;
        }
    }
}
