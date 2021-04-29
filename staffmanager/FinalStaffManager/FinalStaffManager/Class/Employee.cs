using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalStaffManager.Class
{
    public class Employee
    {
        public int empID { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string middleName { get; set; }
        public string fullname { get; set; }
        public string gender { get; set; }
        public string birthdate { get; set; }
        public string employeePic { get; set; }
        public string digitalSignature { get; set; }
        public Job_Info job { get; set; }
        // contact info
        public string address { get; set; }
        public ZipCode ZipCode { get; set; }
        public string emailaddress { get; set; }
        public string phoneNumber { get; set; }
        public string HomePhone { get; set; }
        public List<string> phonenum = new List<string>();
        public List<string> homephone = new List<string>();
        //payroll
        public string UMID { get; set; }
        public string TIN { get; set; }
        public string BankAccountNumber { get; set; }
        public string taxExempStatus { get; set; }
        public string DCR { get; set; }
        public string overtimeRate { get; set; }


        public static void SaveEmployee(TextBox fname, TextBox mname, TextBox lname, ComboBox gender, DateTimePicker bday,
                                        ComboBox job, ComboBox zipcode, TextBox barangay, TextBox EmailAddress, string phonenumbers,
                                        string homephone, string UMID, string TIN, string BankAccountNumber, ComboBox TaxExemption,
                                        TextBox dcr, TextBox ovtr, string employeeImage, string digitalSignature)
        {
            try
            {
                var myjob = Job_InfoHelper.GetAllJobs();
                var mycode = ZipcodeHelper.GetAllJobs();
                int jobid = myjob[job.SelectedIndex].jobID;
                string ZIPCODE = mycode[zipcode.SelectedIndex].Zipcode;
                string birthday = bday.Value.ToString("MM/dd/yyyy");

                Employee employee = new Employee();
                employee.firstName = fname.Text;
                employee.middleName = mname.Text;
                employee.lastName = lname.Text;
                employee.gender = gender.Text;
                employee.birthdate = birthday;     // <-------------------------------------------- datetimeformat
                employee.employeePic = employeeImage;
                employee.digitalSignature = digitalSignature;
                employee.address = barangay.Text;
                employee.emailaddress = EmailAddress.Text;
                employee.phoneNumber = phonenumbers;
                employee.HomePhone = homephone;
                employee.UMID = UMID;
                employee.TIN = TIN;
                employee.BankAccountNumber = BankAccountNumber;
                employee.taxExempStatus = TaxExemption.Text;
                employee.DCR = dcr.Text;
                employee.overtimeRate = ovtr.Text;

                EmployeeHelper.SaveEmployee(employee, jobid, ZIPCODE);
                MessageBox.Show("Employee saved succesfully!", "Succesful saving!",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            catch (Exception)
            {
                MessageBox.Show("You need to fill all the fields before you proceed with the saving", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            
            
        }
        public static void updateEmployee(TextBox fname, TextBox mname, TextBox lname, ComboBox gender, DateTimePicker bday,
                                        ComboBox job, ComboBox zipcode, TextBox barangay, TextBox EmailAddress, string phonenumbers,
                                        string homephone, string UMID, string TIN, string BankAccountNumber, ComboBox TaxExemption,
                                        TextBox dcr, TextBox ovtr, string employeeImage, string digitalSignature,int empID)
        {
            try
            {
                var myjob = Job_InfoHelper.GetAllJobs();
                var mycode = ZipcodeHelper.GetAllJobs();
                int jobid = myjob[job.SelectedIndex].jobID;
                string ZIPCODE = mycode[zipcode.SelectedIndex].Zipcode;
                string birthday = bday.Value.ToString("MM/dd/yyyy");

                Employee employee = new Employee();
                employee.firstName = fname.Text;
                employee.middleName = mname.Text;
                employee.lastName = lname.Text;
                if(gender.Text == "Male")
                {
                    employee.gender = "M";
                }
                else
                {
                    employee.gender = "F";
                }
                employee.birthdate = birthday;
                employee.employeePic = employeeImage;
                employee.digitalSignature = digitalSignature;
                employee.address = barangay.Text;
                employee.emailaddress = EmailAddress.Text;
                employee.phoneNumber = phonenumbers;
                employee.UMID = UMID;
                employee.TIN = TIN;
                employee.BankAccountNumber = BankAccountNumber;
                employee.taxExempStatus = TaxExemption.Text;
                employee.DCR = dcr.Text;
                employee.overtimeRate = ovtr.Text;

                EmployeeHelper.UpdateEmployee(employee, jobid, empID, ZIPCODE, homephone);

                //EmployeeHelper.SaveEmployee(employee, jobid, ZIPCODE);
            }
            catch (ArgumentOutOfRangeException)
            {
                MessageBox.Show("Some Fields are empty, please provide all the empty fields before saving!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        //
        public static void browseEmployeeSignature(PictureBox pcSignature)
        {
            OpenFileDialog openImage = new OpenFileDialog();
            openImage.InitialDirectory = "C:/Picture/";
            openImage.Filter = "png files (*.png)|*.png|jpg files (*.jpg)|*.jpg|All files(*.*)|*.*";
            openImage.Title = "Select Product Image";
            openImage.FilterIndex = 2;
            if (openImage.ShowDialog() == DialogResult.OK)
            {
                pcSignature.Image = Image.FromFile(openImage.FileName);
                pcSignature.SizeMode = PictureBoxSizeMode.StretchImage;
                pcSignature.BorderStyle = BorderStyle.Fixed3D;
            }
        }
    }
}
