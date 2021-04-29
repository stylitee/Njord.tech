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

namespace FinalStaffManager
{
    public partial class AddEmployee : UserControl
    {
        public AddEmployee()
        {
            InitializeComponent();
        }
        int i = 1;
        string image, signature;

        List<ZipCode> listzipcode = null;
        List<Employee> listEmployee = null;
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (cmbNumberType.Text == "Phone number")
            {
                if(txtNumber.Text == "")
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

        private void btnSave_Click(object sender, EventArgs e)
        {
                string phonenumber = "", homephone = "", UMID = "", TIN = "", BankAccountNumber = "";
                DialogResult dia = MessageBox.Show("Are you sure you want to save Mr. " + txtLastName.Text + "?", "Save Employee",
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
                    image = getImageEmployee();
                    signature = getSignature();
                    UMID = txtUmid1.Text + txtUmid2.Text + txttxtUmid3.Text;
                    TIN = txtTin1.Text + txtTin2.Text + txtTin3.Text;
                    BankAccountNumber = txtBank1.Text + txtBank2.Text + txtBank3.Text;
                    //try
                    //{
                        Employee.SaveEmployee(txtFirstname, txtMiddleName, txtLastName, cmbGender, dtpBirthdate, cmbJobAssignment, cmbZipcode,
                            txtBarangay, txtEmailAddress, phonenumber, homephone, UMID, TIN, BankAccountNumber, cmbTaxExemptionStatus,
                              txtDailyContractRate, txtOverTimeRate, image, signature);
                        pnlEmployeeNum.Controls.Clear();
                        i = 1;
                        AddNewEmployee.loadList();
                        ListofEmployeeForExport.loadme();
                        clearFields();
                    //}
                    //catch (Exception)
                    //{
                    //    MessageBox.Show("Employee saving failed", "Error!");
                    //}
                }
                else
                {
                    return;
                }        
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
            foreach(EmployeeContactNumbers c in pnlEmployeeNum.Controls)
            {
                c.Controls.Remove(this);
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

            for(int i = 0; i< codeList.Count; i++)
            {
                cmbZipcode.Items.Add(codeList[i].Zipcode);
            }
        }

        private void AddEmployee_Load(object sender, EventArgs e)
        {
            getJobList();
            getZipCodeList();
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
                foreach(var municipality in listzipcode)
                {

                    txtZipcode.Text = municipality.Municipality;
                }
            }
            catch (Exception)
            {
                return;
            }
        }
        // <<<<<<<<<<<---------------------------------------------
        private void txtUmid1_TextChanged(object sender, EventArgs e)
        {
            if(txtUmid1.Text.Length >= 2)
            {
                txtUmid2.Focus();
            }
        }

        private void txtUmid2_TextChanged(object sender, EventArgs e)
        {
            if(txtUmid2.Text.Length >=7)
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

        private void textBox3_TextChanged(object sender, EventArgs e)
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
            else
            {
                if (txtBank1.Text.Length >= 3)
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
            else
            {
                if (txtBank2.Text.Length >= 6)
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
            else
            {
                txtBank3.MaxLength = 3;
            }
        }

        private void numeric(object sender, KeyPressEventArgs e)
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
            if(cmbNumberType.Text == "Phone number")
            {
                txtNumber.MaxLength = 11;
            }
            else
            {
                txtNumber.MaxLength = 7;
            }
            txtNumber.Text = "";
        }

        private void lblMode_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
