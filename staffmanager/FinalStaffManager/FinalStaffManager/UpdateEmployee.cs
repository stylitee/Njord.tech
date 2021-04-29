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
using System.Data.SqlClient;
using System.Globalization;

namespace FinalStaffManager
{
    public partial class UpdateEmployee : UserControl
    {
        public UpdateEmployee()
        {
            InitializeComponent();
        }
        public static List<Panel> panel = new List<Panel>();
        public static List<UserControl> user = new List<UserControl>();
        List<ZipCode> listzipcode = null;
        List<Employee> listEmployee = null;
        string image = "", signature = "";
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string phonenumber = "", homephone = "", UMID = "", TIN = "", BankAccountNumber = "";
            DialogResult dia = MessageBox.Show("Are you sure you want to Update Mr. " + txtLastName.Text + "?", "Update Employee",
                                               MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            foreach (EmployeeContactNumbers c in pnlEmployeeNum.Controls)
            {
                int tag = Convert.ToInt32(c.btnRemove.Tag);
                if (tag == 1)
                {
                    phonenumber = phonenumber + c.lblNumber.Text + ",";
                }
                else if (tag == 2)
                {
                    homephone = homephone + c.lblNumber.Text + ",";
                }
            }

            if (dia == DialogResult.Yes)
            {
                int empid = Convert.ToInt32(ucEmployees.ID);
                image = getImageEmployee();
                signature = getSignature();
                UMID = txtUmid1.Text + txtUmid2.Text + txttxtUmid3.Text;
                TIN = txtTin1.Text + txtTin2.Text + txtTin3.Text;
                BankAccountNumber = txtBank1.Text + txtBank2.Text + txtBank3.Text;
                //try
                //{
                    //updating
                    Employee.updateEmployee(txtFirstname, txtMiddleName, txtLastName, cmbGender, dtpBirthdate, cmbJobAssignment, cmbZipcode,
                        txtBarangay, txtEmailAddress, phonenumber, homephone, UMID, TIN, BankAccountNumber, cmbTaxExemptionStatus,
                          txtDailyContractRate, txtOverTimeRate, image, signature, empid);
                    AddNewEmployee.loadList();
                    ListofEmployeeForExport.loadme();
                    MessageBox.Show("Update saved succesfully!", "Succesful updating!");
                    clearFields();
                    this.SendToBack();
                //}
                //catch (Exception)
                //{
                //    MessageBox.Show("Employee update failed", "Error!");
                //    this.SendToBack();
                //}
                lblIndicator.Text = "";
                pnlEmployeeNum.Controls.Clear();
            }
        }

        private void clearFields()
        {
            txtZipcode.Text = "";
            txtFirstname.Text = "";
            txtMiddleName.Text = "";
            txtLastName.Text = "";
            cmbGender.ResetText();
            dtpBirthdate.Value = DateTime.Now;
            cmbJobAssignment.ResetText();
            cmbZipcode.ResetText();
            txtBarangay.Text = "";
            txtEmailAddress.Text = "";
            txtNumber.Text = "";
            txtUmid1.Text = "";
            txtUmid2.Text = "";
            txttxtUmid3.Text = "";
            txtTin1.Text = "";
            txtTin2.Text = "";
            txtTin3.Text = "";
            txtBank1.Text = "";
            txtBank2.Text = "";
            txtBank3.Text = "";
            cmbBanks.ResetText();
            cmbTaxExemptionStatus.ResetText();
            cmbNumberType.ResetText();
            txtDailyContractRate.Text = "";
            txtOverTimeRate.Text = "";
            pcEmployeeImage.Image = null;
            pcDigitalSignature.Image = null;
            foreach (EmployeeContactNumbers c in pnlEmployeeNum.Controls)
            {
                c.Controls.Remove(this);
            }
        }

        private void UpdateEmployee_Load(object sender, EventArgs e)
        {
            panel.Add(panel1);
            user.Add(this);
            getJobList();
            getZipCodeList();
        }

        private void lblIndicator_TextChanged(object sender, EventArgs e)
        {
            int i = Convert.ToInt32(ucEmployees.ID);
            fillFieldsForUpdate(i);
        }

        private void fillFieldsForUpdate(int empid)
        {
            SqlParameter[] p = { new SqlParameter("@emp_id", empid) };
            listEmployee = EmployeeHelper.GetAllEmployeesUpdate(p);
            int i = 1;
            var myjob = Job_InfoHelper.GetAllJobs();

            foreach (var field in listEmployee)
            {
                string jobName = myjob[field.job.jobID].title;
                txtFirstname.Text = field.firstName;
                txtMiddleName.Text = field.middleName;
                txtLastName.Text = field.lastName;
                if (field.gender == "F")
                {
                    cmbGender.Text = "Female";
                }
                else
                {
                    cmbGender.Text = "Male";
                }
                dtpBirthdate.Value = DateTime.ParseExact(field.birthdate, "MM/dd/yyyy", CultureInfo.InvariantCulture);
                cmbJobAssignment.Text = jobName;
                cmbTaxExemptionStatus.Text = field.taxExempStatus;

                //alternatiev is available just incase this doesnt work
                System.Text.RegularExpressions.Regex re = new System.Text.RegularExpressions.Regex("^(.+?)(.{1,2}?)?(.{1,2})$");
                System.Text.RegularExpressions.Match m = re.Match(field.UMID);
                this.txtUmid1.Text = m.Groups[3].Value;
                this.txtUmid2.Text = m.Groups[2].Value;
                this.txttxtUmid3.Text = m.Groups[1].Value;

                System.Text.RegularExpressions.Regex rfe = new System.Text.RegularExpressions.Regex("^(.+?)(.{1,2}?)?(.{1,2})$");
                System.Text.RegularExpressions.Match me = rfe.Match(field.TIN);

                this.txtTin1.Text = me.Groups[3].Value;
                this.txtTin2.Text = me.Groups[2].Value;
                this.txtTin3.Text = me.Groups[1].Value;

                System.Text.RegularExpressions.Regex rge = new System.Text.RegularExpressions.Regex("^(.+?)(.{1,2}?)?(.{1,2})$");
                System.Text.RegularExpressions.Match mem = rge.Match(field.BankAccountNumber);

                this.txtBank1.Text = mem.Groups[3].Value;
                this.txtBank2.Text = mem.Groups[2].Value;
                this.txtBank3.Text = mem.Groups[1].Value;
                //alternative is available just incase this doesnt work

                txtDailyContractRate.Text = field.DCR;
                txtOverTimeRate.Text = field.overtimeRate;

                cmbZipcode.Text = field.ZipCode.Zipcode;
                txtBarangay.Text = field.address;
                txtEmailAddress.Text = field.emailaddress;
                string[] phoneentries = field.phoneNumber.Split(',');
                foreach (var phone in phoneentries)
                {
                    if(phone != "")
                    {
                        var number = new EmployeeContactNumbers();
                        number.lblItem.Text = i.ToString();
                        number.lblNumber.Text = phone;
                        number.btnRemove.Tag = 1;
                        number.pcIcon.Image = FinalStaffManager.Properties.Resources.smartphone_call;
                        i++;
                        pnlEmployeeNum.Controls.Add(number);
                    }
                    else
                    {
                        continue;
                    }
                }
                string[] homephoneentries = field.HomePhone.Split(',');

                foreach (var homephone in homephoneentries)
                {
                    if(homephone != "")
                    {
                        var number = new EmployeeContactNumbers();
                        number.lblItem.Text = i.ToString();
                        number.lblNumber.Text = homephone;
                        number.btnRemove.Tag = 1;
                        number.pcIcon.Image = FinalStaffManager.Properties.Resources.call_answer;
                        i++;
                        pnlEmployeeNum.Controls.Add(number);
                    }
                    else
                    {
                        continue;
                    }
                    
                }
                pcEmployeeImage.Image = Base64ToImage(field.employeePic);
                pcDigitalSignature.Image = Base64ToImage(field.digitalSignature);
            }
        }
        private string getImageEmployee()
        {
            string team_image = null;
            Employee employee = new Employee();
            try
            {
                byte[] by = null;

                MemoryStream ms = new MemoryStream();
                by = ms.GetBuffer();
                ms.Close();
            }
            catch (Exception) { }
            return team_image = ImageToBase64(pcEmployeeImage.Image, System.Drawing.Imaging.ImageFormat.Jpeg);
        }

        public Image Base64ToImage(string base64String)
        {
            try
            {
                byte[] imageBytes = Convert.FromBase64String(base64String);
                MemoryStream ms = new MemoryStream(imageBytes, 0,
                  imageBytes.Length);

                // Convert byte[] to Image
                ms.Write(imageBytes, 0, imageBytes.Length);
                Image image = Image.FromStream(ms);
                return image;
            }
            catch (ArgumentException)
            {
                return Properties.Resources.noimagefound;
            }

        }

        private string getSignature()
        {
            string team_image = null;
            Employee employee = new Employee();
            try
            {
                byte[] by = null;

                MemoryStream ms = new MemoryStream();
                by = ms.GetBuffer();
                ms.Close();
            }
            catch (Exception) { }

            return team_image = ImageToBase64(pcDigitalSignature.Image, System.Drawing.Imaging.ImageFormat.Jpeg);
        }

        public string ImageToBase64(Image image,
        System.Drawing.Imaging.ImageFormat format)
        {
            using (MemoryStream ms = new MemoryStream())
            {
                byte[] imageBytes;
                string base64String = "";
                try
                {
                    if (image != null)
                    {
                        // Convert Image to byte[]
                        image.Save(ms, format);
                        imageBytes = ms.ToArray();
                        // Convert byte[] to Base64 String
                        base64String = Convert.ToBase64String(imageBytes);
                    }
                }
                catch (Exception) { }

                return base64String;
            }
        }

        private void pcEmployeeImage_Click(object sender, EventArgs e)
        {
            browseEmployeeImage();
        }

        private void browseEmployeeImage()
        {
            OpenFileDialog openImage = new OpenFileDialog();
            openImage.InitialDirectory = "C:/Picture/";
            openImage.Filter = "png files (*.png)|*.png|jpg files (*.jpg)|*.jpg|All files(*.*)|*.*";
            openImage.Title = "Select Product Image";
            openImage.FilterIndex = 2;
            if (openImage.ShowDialog() == DialogResult.OK)
            {
                pcEmployeeImage.Image = Image.FromFile(openImage.FileName);
                pcEmployeeImage.SizeMode = PictureBoxSizeMode.StretchImage;
                pcEmployeeImage.BorderStyle = BorderStyle.Fixed3D;
            }
        }

        private void getJobList()
        {
            var jobList = Job_InfoHelper.GetAllJobs();

            for (int i = 0; i < jobList.Count; i++)
            {
                cmbJobAssignment.Items.Add(jobList[i].title);
            }
        }

        private void getZipCodeList()
        {
            var codeList = ZipcodeHelper.GetAllJobs();

            for (int i = 0; i < codeList.Count; i++)
            {
                cmbZipcode.Items.Add(codeList[i].Zipcode);
            }
        }

        private void btnUploadSignature_Click(object sender, EventArgs e)
        {
            Employee.browseEmployeeSignature(pcDigitalSignature);
        }

        private void cmbZipcode_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string searchzipcode = cmbZipcode.Text;
                SqlParameter[] p = { new SqlParameter("@code", searchzipcode) };

                listzipcode = ZipcodeHelper.SearchMunicipality(p);
                foreach (var municipality in listzipcode)
                {

                    txtZipcode.Text = municipality.Municipality;
                }
            }
            catch (Exception)
            {
                return;
            }
        }

        private void txtUmid1_TextChanged(object sender, EventArgs e)
        {
            if (txtUmid2.Text.Length >= 7)
            {
                txttxtUmid3.Focus();
            }
        }

        private void txtUmid2_TextChanged(object sender, EventArgs e)
        {
            if (txtUmid2.Text.Length >= 7)
            {
                txttxtUmid3.Focus();
            }
        }

        private void txtTin1_TextChanged(object sender, EventArgs e)
        {
            if (txtTin1.Text.Length >= 2)
            {
                txtTin2.Focus();
            }
        }

        private void txtTin2_TextChanged(object sender, EventArgs e)
        {
            if (txtTin2.Text.Length >= 2)
            {
                txtTin3.Focus();
            }
        }

        private void txtBank1_TextChanged(object sender, EventArgs e)
        {
            if (cmbBanks.Text == "BDO")
            {
                if (txtBank1.Text.Length >= 3)
                {
                    txtBank2.Focus();
                }
            }
            else if (cmbBanks.Text == "MetroBank")
            {
                if (txtBank1.Text.Length >= 3)
                {
                    txtBank2.Focus();
                }
            }
            else if (cmbBanks.Text == "BPI")
            {
                if (txtBank1.Text.Length >= 3)
                {
                    txtBank2.Focus();
                }
            }
            else if (cmbBanks.Text == "PNB")
            {
                if (txtBank1.Text.Length >= 3)
                {
                    txtBank2.Focus();
                }
            }
            else if (cmbBanks.Text == "LandBank")
            {
                if (txtBank1.Text.Length >= 3)
                {
                    txtBank2.Focus();
                }
            }
            else if (cmbBanks.Text == "UnionBank")
            {
                if (txtBank1.Text.Length >= 3)
                {
                    txtBank2.Focus();
                }
            }
            else if(cmbBanks.Text == "ChinaBank")
            {
                if (txtBank1.Text.Length >= 3)
                {
                    txtBank2.Focus();
                }
            }
            else
            {
                txtBank1.MaxLength = 4;
                if (txtBank1.Text.Length >= 4)
                {
                    txtBank2.Focus();
                }
            }
        }

        private void txtBank2_TextChanged(object sender, EventArgs e)
        {
            if (cmbBanks.Text == "BDO")
            {
                if (txtBank2.Text.Length >= 4)
                {
                    txtBank3.Focus();
                }
            }
            else if (cmbBanks.Text == "MetroBank")
            {
                if (txtBank2.Text.Length >= 7)
                {
                    txtBank3.Focus();
                }
            }
            else if (cmbBanks.Text == "BPI")
            {
                if (txtBank2.Text.Length >= 6)
                {
                    txtBank3.Focus();
                }
            }
            else if (cmbBanks.Text == "PNB")
            {
                if (txtBank2.Text.Length >= 9)
                {
                    txtBank3.Focus();
                }
            }
            else if (cmbBanks.Text == "LandBank")
            {
                if (txtBank2.Text.Length >= 9)
                {
                    txtBank3.Focus();
                }
            }
            else if (cmbBanks.Text == "UnionBank")
            {
                if (txtBank2.Text.Length >= 6)
                {
                    txtBank3.Focus();
                }
            }
            else if (cmbBanks.Text == "ChinaBank")
            {
                if (txtBank2.Text.Length >= 6)
                {
                    txtBank2.Focus();
                }
            }
            else
            {
                txtBank2.MaxLength = 8;
                if (txtBank2.Text.Length >= 8)
                {
                    txtBank3.Focus();
                }
            }
        }

        private void txtBank3_TextChanged(object sender, EventArgs e)
        {
            if (cmbBanks.Text == "BDO")
            {
                txtBank3.MaxLength = 3;
            }
            else if (cmbBanks.Text == "MetroBank")
            {
                txtBank3.MaxLength = 3;
            }
            else if (cmbBanks.Text == "BPI")
            {
                txtBank3.MaxLength = 3;
            }
            else if (cmbBanks.Text == "PNB")
            {
                txtBank3.MaxLength = 4;
            }
            else if (cmbBanks.Text == "LandBank")
            {
                txtBank3.MaxLength = 4;
            }
            else if (cmbBanks.Text == "UnionBank")
            {
                txtBank3.MaxLength = 3;
            }
            else if (cmbBanks.Text == "ChinaBank")
            {
                txtBank3.MaxLength = 3;
            }
            else
            {
                txtBank3.MaxLength = 4;
            }
        }

        private void cmbZipcode_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
            (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void cmbNumberType_TextChanged(object sender, EventArgs e)
        {
            if (cmbNumberType.Text == "Phone number")
            {
                txtNumber.MaxLength = 11;
            }
            else
            {
                txtNumber.MaxLength = 7;
            }
            txtNumber.Text = "";
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            int i = 1;
            if (cmbNumberType.Text == "Phone number")
            {
                if (txtNumber.Text == "")
                {
                    MessageBox.Show("Phone number cannot be empty", "Phone number error!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                else
                {
                    var number = new EmployeeContactNumbers();
                    number.lblItem.Text = i.ToString();
                    number.lblNumber.Text = txtNumber.Text;
                    number.btnRemove.Tag = 1;
                    number.pcIcon.Image = FinalStaffManager.Properties.Resources.smartphone_call;
                    i++;
                    pnlEmployeeNum.Controls.Add(number);
                }


            }
            else if (cmbNumberType.Text == "Homephone number")
            {
                if (txtNumber.Text == "")
                {
                    MessageBox.Show("Homephone number cannot be empty", "Homephone number error!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                else
                {
                    var number = new EmployeeContactNumbers();
                    number.lblItem.Text = i.ToString();
                    number.lblNumber.Text = txtNumber.Text;
                    number.btnRemove.Tag = 2;
                    number.pcIcon.Image = FinalStaffManager.Properties.Resources.call_answer;
                    i++;
                    pnlEmployeeNum.Controls.Add(number);
                }
            }
            txtNumber.Text = "";
        }
    }
}
