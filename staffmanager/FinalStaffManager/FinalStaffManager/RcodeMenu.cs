using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FinalStaffManager.Forms;
using FinalStaffManager.Class;
using System.Text.RegularExpressions;
using System.Data.SqlClient;

namespace FinalStaffManager
{
    public partial class RcodeMenu : UserControl
    {
        public RcodeMenu()
        {
            InitializeComponent();
        }
        public static int flag = 0;
        public static List<TextBox> txt = new List<TextBox>();
        public static List<ComboBox> cmb = new List<ComboBox>();

        public static List<Panel> pnl = new List<Panel>();
        public static List<FlowLayoutPanel> flp = new List<FlowLayoutPanel>();
        public static List<Button> btn = new List<Button>();
        public static List<Label> lbl = new List<Label>();

        List<string> reload = new List<string>();
        public static string code, resultString , temp ;
        public static int isUpdate;
        public static List<string> scodes = new List<string>();
        private void RcodeMenu_Load(object sender, EventArgs e)
        {
            btnCancel.Hide();
            LoadScodes();
            loadRcodes();
            pnlRegistration.Hide();
            txt.Add(txtRcode);
            cmb.Add(cmbNumberOfEmployees);
            cmb.Add(cmbScodeList);
            pnl.Add(pnlHead);
            flp.Add(pnlListofRcode);
            btn.Add(btnSave);
            btn.Add(btnCancel);
            lbl.Add(lblStatus);
            pnl.Add(pnlRegistration);
            pnlHead.Show();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if(btnSave.Text == "ADD NEW RCODE")
            {
                DialogResult res = MessageBox.Show("Are you sure you want to add new Rcode?", "RCODE adding", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (res == DialogResult.Yes)
                {
                    pnlRegistration.Show();
                    pnlListofRcode.Hide();
                    pnlHead.Hide();
                    lblStatus.Text = "Rcode Registration";
                    btnSave.Text = "Add";
                    btnCancel.Show();
                }
                else
                {
                    return;
                }
            }
            else if(btnSave.Text == "Add")
            {
                isUpdate = 0;
                int i = 0;
                foreach(Control s in panelChoices.Controls)
                {
                    if(s  is UserControl)
                    {
                        i++;
                    }
                }
                if(i == Convert.ToInt32(resultString))
                {
                    foreach (ScodeChoices s in panelChoices.Controls)
                    {
                        scodes.Add(s.lblScode.Text);
                    }
                    code = txtRcode.Text;
                    flag = 1;
                    rCodeChecker rs = new rCodeChecker();
                    rs.Show();
                }
                else
                {
                    MessageBox.Show("Please add more scodes before proceeding");
                    return;
                }

            }
            else if(btnSave.Text == "Update")
            {
                isUpdate = 1;
                temp = Regex.Match(cmbNumberOfEmployees.Text, @"\d+").Value; 
                int i = 0;
                foreach (Control s in panelChoices.Controls)
                {
                    if (s is UserControl)
                    {
                        i++;
                    }
                }
                if (i == Convert.ToInt32(temp))
                {
                    foreach (ScodeChoices s in panelChoices.Controls)
                    {
                        scodes.Add(s.lblScode.Text);
                    }
                    code = txtRcode.Text;
                    flag = 2;
                    rCodeChecker rs = new rCodeChecker();
                    rs.Show();
                }
                else
                {
                    MessageBox.Show("Please add more scodes before proceeding");
                    return;
                }
            }
            
        }

        private void loadRcodes()
        {
            string result = "";
            int i = 1;
            List<RCODE> rcodelist = RcodeHelper.GetAllRcodes();
            foreach(var rcode in rcodelist)
            {
                result = Regex.Match(rcode.desc, @"\d+").Value;
                i = Convert.ToInt32(result);
                if (i == 5)
                {
                    var code = new RCODE_Display();
                    code.lblNumber.Text = i.ToString();
                    code.lblDesc.Text = rcode.desc;
                    code.lblRcode.Text = rcode.rcode;
                    code.pnlMax5.Show();
                    code.pnlMax4.Hide();
                    code.pnlMax3.Hide();
                    code.lblScode5_1.Text = rcode.scode1;
                    code.lblScode5_2.Text = rcode.scode2;
                    code.lblScode5_3.Text = rcode.scode3;
                    code.lblScode5_4.Text = rcode.scode4;
                    code.lblScode5_5.Text = rcode.scode5;
                    pnlListofRcode.Controls.Add(code);
                    i++;
                }
                else if (i == 4)
                {
                    var code = new RCODE_Display();
                    code.lblNumber.Text = i.ToString();
                    code.lblDesc.Text = rcode.desc;
                    code.lblRcode.Text = rcode.rcode;
                    code.pnlMax4.Show();
                    code.pnlMax5.Hide();
                    code.pnlMax3.Hide();
                    code.lblScode4_1.Text = rcode.scode1;
                    code.lblScode4_2.Text = rcode.scode2;
                    code.lblScode4_3.Text = rcode.scode3;
                    code.lblScode4_4.Text = rcode.scode4;
                    pnlListofRcode.Controls.Add(code);
                    i++;
                }
                else
                {
                    var code = new RCODE_Display();
                    code.lblNumber.Text = i.ToString();
                    code.lblRcode.Text = rcode.rcode;
                    code.lblDesc.Text = rcode.desc;
                    code.pnlMax3.Show();
                    code.pnlMax4.Hide();
                    code.pnlMax5.Hide();
                    code.lblScode3_1.Text = rcode.scode1;
                    code.lblScode3_2.Text = rcode.scode2;
                    code.lblScode3_3.Text = rcode.scode3;
                    pnlListofRcode.Controls.Add(code);
                    i++;
                }
            }
        }
        private void LoadScodes()
        {
            cmbScodeList.Items.Clear();
            List<SCODE> codelist = ScodeHelper.GetAllScodes();
            foreach (var code in codelist)
            {         
                    cmbScodeList.Items.Add(code.scode);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (cmbNumberOfEmployees.Text == "")
            {
                MessageBox.Show("Please choose the number of employees!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                resultString = Regex.Match(cmbNumberOfEmployees.Text, @"\d+").Value;
                int max = Convert.ToInt32(resultString);
                int i = 0;
                foreach (Control c in panelChoices.Controls)
                {
                    if (c is UserControl)
                    {
                        i++;
                    }
                }
                if (cmbScodeList.Text == "")
                {
                    return;
                }
                else
                {
                    if (i < max)
                    {
                        var scode = new ScodeChoices();
                        scode.lblScode.Text = cmbScodeList.Text;
                        panelChoices.Controls.Add(scode);
                        cmbScodeList.Items.Remove(cmbScodeList.SelectedItem);
                    }
                    else
                    {
                        DialogResult res = MessageBox.Show("You can only add up to " + resultString + ", Do you want to save this instead?", "Alert!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (res == DialogResult.Yes)
                        {
                            rCodeChecker rs = new rCodeChecker();
                            rs.Show();
                        }
                    }
                }
            }
        }

        private void panelChoices_ControlRemoved(object sender, ControlEventArgs e)
        {
            //
            List<string> trylang = new List<string>();
            foreach(string c in cmbScodeList.Items)
            {
                trylang.Add(c);
            }
            if(ScodeChoices.code != null)
            {
                trylang.Add(ScodeChoices.code);
                trylang.Sort();
                cmbScodeList.Items.Clear();
                foreach(var c in trylang)
                {
                    cmbScodeList.Items.Add(c);
                }
            }
            else
            {
                return;
            }
        }

        private void cmbNumberOfEmployees_TextChanged(object sender, EventArgs e)
        {
            //if(flag == 0)
            //{
                resultString = "";
                panelChoices.Controls.Clear();
                LoadScodes();
            //}
            //else
            //{
                
            //}
        }

        private void btnSave_TextChanged(object sender, EventArgs e)
        {
            flag = 1;
            string num = "";
            string temp = RCODE_Display.rcode;
            List<string> scodes = new List<string>();
            if(btnSave.Text == "Update")
            {
                SqlParameter[] rcode = { new SqlParameter("@rcode", RCODE_Display.rcode )};
                List<RCODE> codes = RcodeHelper.GetSpecificRcodes(rcode);
                foreach(var r in codes)
                {
                    txtRcode.Text = r.rcode;
                    cmbNumberOfEmployees.Text = r.desc;
                    num = Regex.Match(r.desc, @"\d+").Value;
                    if(Convert.ToInt32(num) == 5)
                    {
                        scodes.Add(r.scode1);
                        scodes.Add(r.scode2);
                        scodes.Add(r.scode3);
                        scodes.Add(r.scode4);
                        scodes.Add(r.scode5);
                    }
                    else if(Convert.ToInt32(num) == 4)
                    {
                        scodes.Add(r.scode1);
                        scodes.Add(r.scode2);
                        scodes.Add(r.scode3);
                        scodes.Add(r.scode4);
                    }
                    else if (Convert.ToInt32(num) == 3)
                    {
                        scodes.Add(r.scode1);
                        scodes.Add(r.scode2);
                        scodes.Add(r.scode3);
                    }
                }

                for(int i = 0; i < scodes.Count; i++)
                {
                    var c = new ScodeChoices();
                    c.lblScode.Text = scodes[i];
                    panelChoices.Controls.Add(c);
                }

                for (int i = 0; i < scodes.Count; i++)
                {
                    cmbScodeList.Items.Remove(scodes[i]);
                }

            }
            flag = 0;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            btnSave.Text = "ADD NEW RCODE";
            loadClear();
            pnlHead.Show();
            pnlRegistration.Hide();
            pnlListofRcode.Show();
            btnCancel.Hide();
        }
        
        private void loadClear()
        {
            txtRcode.Text = "";
            panelChoices.Controls.Clear();
        }

        public static void updateRcodes()
        {
            flp[0].Controls.Clear();
            cmb[1].Items.Clear();
            List<SCODE> codelist = ScodeHelper.GetAllScodes();
            foreach (var code in codelist)
            {
                cmb[1].Items.Add(code.scode);
            }
            string result = "";
            int i = 1;
            List<RCODE> rcodelist = RcodeHelper.GetAllRcodes();
            foreach (var rcode in rcodelist)
            {
                result = Regex.Match(rcode.desc, @"\d+").Value;
                i = Convert.ToInt32(result);
                if (i == 5)
                {
                    var code = new RCODE_Display();
                    code.lblNumber.Text = i.ToString();
                    code.lblDesc.Text = rcode.desc;
                    code.lblRcode.Text = rcode.rcode;
                    code.pnlMax5.Show();
                    code.pnlMax4.Hide();
                    code.pnlMax3.Hide();
                    code.lblScode5_1.Text = rcode.scode1;
                    code.lblScode5_2.Text = rcode.scode2;
                    code.lblScode5_3.Text = rcode.scode3;
                    code.lblScode5_4.Text = rcode.scode4;
                    code.lblScode5_5.Text = rcode.scode5;
                    flp[0].Controls.Add(code);
                    i++;
                }
                else if (i == 4)
                {
                    var code = new RCODE_Display();
                    code.lblNumber.Text = i.ToString();
                    code.lblDesc.Text = rcode.desc;
                    code.lblRcode.Text = rcode.rcode;
                    code.pnlMax4.Show();
                    code.pnlMax5.Hide();
                    code.pnlMax3.Hide();
                    code.lblScode4_1.Text = rcode.scode1;
                    code.lblScode4_2.Text = rcode.scode2;
                    code.lblScode4_3.Text = rcode.scode3;
                    code.lblScode4_4.Text = rcode.scode4;
                    flp[0].Controls.Add(code);
                    i++;
                }
                else
                {
                    var code = new RCODE_Display();
                    code.lblNumber.Text = i.ToString();
                    code.lblRcode.Text = rcode.rcode;
                    code.lblDesc.Text = rcode.desc;
                    code.pnlMax3.Show();
                    code.pnlMax4.Hide();
                    code.pnlMax5.Hide();
                    code.lblScode3_1.Text = rcode.scode1;
                    code.lblScode3_2.Text = rcode.scode2;
                    code.lblScode3_3.Text = rcode.scode3;
                    flp[0].Controls.Add(code);
                    i++;
                }
            }
        }
    }
}
