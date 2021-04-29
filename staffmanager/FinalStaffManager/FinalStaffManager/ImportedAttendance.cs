using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;

namespace FinalStaffManager
{
    public partial class ImportedAttendance : UserControl, IComparable<ImportedAttendance>
    {
        public ImportedAttendance()
        {
            InitializeComponent();
        }
        string[] textboxContent = new String[2];
        public int CompareTo(ImportedAttendance other)
        {
            if (DateTime.ParseExact(this.lblDate.Text, "MM/dd/yyyy", CultureInfo.InvariantCulture) > DateTime.ParseExact(other.lblDate.Text, "MM/dd/yyyy", CultureInfo.InvariantCulture))
            {
                return 1;
            }
            else if (DateTime.ParseExact(this.lblDate.Text, "MM/dd/yyyy", CultureInfo.InvariantCulture) < DateTime.ParseExact(other.lblDate.Text, "MM/dd/yyyy", CultureInfo.InvariantCulture))
            {
                return -1;
            }
            else
                return 0;

        }
        private void txt1stam_MouseClick(object sender, MouseEventArgs e)
        {
            if(txt1stam.Text == "")
            {
                return;
            }
            else
            {
                
                if (textboxContent[0] == null && txt1stam.BackColor == Color.White)
                {
                    textboxContent[0] = txt1stam.Text;
                    txt1stam.BackColor = Color.Yellow;
                }
                else if (textboxContent[1] == null && txt1stam.BackColor == Color.White)
                {
                    textboxContent[1] = txt1stam.Text;
                    txt1stam.BackColor = Color.Blue;
                }
                else if (textboxContent[0] != null && txt1stam.BackColor == Color.Yellow)
                {
                    textboxContent[0] = null;
                    txt1stam.BackColor = Color.White;
                }
                else if (textboxContent[1] != null && txt1stam.BackColor == Color.Blue)
                {
                    textboxContent[1] = null;
                    txt1stam.BackColor = Color.White;
                }
            }
        }

        private void txt2ndam_MouseClick(object sender, MouseEventArgs e)
        {
            if(txt2ndam.Text == "")
            {
                return;
            }
            else
            {
                if (textboxContent[0] == null && txt2ndam.BackColor == Color.White)
                {
                    textboxContent[0] = txt2ndam.Text;
                    txt2ndam.BackColor = Color.Yellow;
                }
                else if (textboxContent[1] == null && txt2ndam.BackColor == Color.White)
                {
                    textboxContent[1] = txt2ndam.Text;
                    txt2ndam.BackColor = Color.Blue;
                }
                else if (textboxContent[0] != null && txt2ndam.BackColor == Color.Yellow)
                {
                    textboxContent[0] = null;
                    txt2ndam.BackColor = Color.White;
                }
                else if (textboxContent[1] != null && txt2ndam.BackColor == Color.Blue)
                {
                    textboxContent[1] = null;
                    txt2ndam.BackColor = Color.White;
                }
            }
        }

        private void txt1stpm_MouseClick(object sender, MouseEventArgs e)
        {
            if(txt1stpm.Text == "")
            {
                return;
            }
            else
            {
                if (textboxContent[0] == null && txt1stpm.BackColor == Color.White)
                {
                    textboxContent[0] = txt1stpm.Text;
                    txt1stpm.BackColor = Color.Yellow;
                }
                else if (textboxContent[1] == null && txt1stpm.BackColor == Color.White)
                {
                    textboxContent[1] = txt1stpm.Text;
                    txt1stpm.BackColor = Color.Blue;
                }
                else if (textboxContent[0] != null && txt1stpm.BackColor == Color.Yellow)
                {
                    textboxContent[0] = null;
                    txt1stpm.BackColor = Color.White;
                }
                else if (textboxContent[1] != null && txt1stpm.BackColor == Color.Blue)
                {
                    textboxContent[1] = null;
                    txt1stpm.BackColor = Color.White;
                }
            }
        }

        private void txt2ndpm_MouseClick(object sender, MouseEventArgs e)
        {
            if(txt2ndpm.Text == "")
            {
                return;
            }
            else
            {
                if (textboxContent[0] == null && txt2ndpm.BackColor == Color.White)
                {
                    textboxContent[0] = txt2ndpm.Text;
                    txt2ndpm.BackColor = Color.Yellow;
                }
                else if (textboxContent[1] == null && txt2ndpm.BackColor == Color.White)
                {
                    textboxContent[1] = txt2ndpm.Text;
                    txt2ndpm.BackColor = Color.Blue;
                }
                else if (textboxContent[0] != null && txt2ndpm.BackColor == Color.Yellow)
                {
                    textboxContent[0] = null;
                    txt2ndpm.BackColor = Color.White;
                }
                else if (textboxContent[1] != null && txt2ndpm.BackColor == Color.Blue)
                {
                    textboxContent[1] = null;
                    txt2ndpm.BackColor = Color.White;
                }
            }
        }

        private void txt1stovertime_MouseClick(object sender, MouseEventArgs e)
        {
            if (txt1stovertime.Text == "")
            {
                return;
            }
            else
            {
                if (textboxContent[0] == null && txt1stovertime.BackColor == Color.White)
                {
                    textboxContent[0] = txt1stovertime.Text;
                    txt1stovertime.BackColor = Color.Yellow;
                }
                else if (textboxContent[1] == null && txt1stovertime.BackColor == Color.White)
                {
                    textboxContent[1] = txt1stovertime.Text;
                    txt1stovertime.BackColor = Color.Blue;
                }
                else if (textboxContent[0] != null && txt1stovertime.BackColor == Color.Yellow)
                {
                    textboxContent[0] = null;
                    txt1stovertime.BackColor = Color.White;
                }
                else if (textboxContent[1] != null && txt1stovertime.BackColor == Color.Blue)
                {
                    textboxContent[1] = null;
                    txt1stovertime.BackColor = Color.White;
                }
            }  
        }

        private void txt2ndovertime_MouseClick(object sender, MouseEventArgs e)
        {
            if(txt2ndovertime.Text == "")
            {
                return;
            }
            else
            {
                if (textboxContent[0] == null && txt2ndovertime.BackColor == Color.White)
                {
                    textboxContent[0] = txt2ndovertime.Text;
                    txt2ndovertime.BackColor = Color.Yellow;
                }
                else if (textboxContent[1] == null && txt2ndovertime.BackColor == Color.White)
                {
                    textboxContent[1] = txt2ndovertime.Text;
                    txt2ndovertime.BackColor = Color.Blue;
                }
                else if (textboxContent[0] != null && txt2ndovertime.BackColor == Color.Yellow)
                {
                    textboxContent[0] = null;
                    txt2ndovertime.BackColor = Color.White;
                }
                else if (textboxContent[1] != null && txt2ndovertime.BackColor == Color.Blue)
                {
                    textboxContent[1] = null;
                    txt2ndovertime.BackColor = Color.White;
                }
            }
        }

        private void btnSwap_Click(object sender, EventArgs e)
        {
            foreach (Control c in this.Controls)
            {
                if (c.BackColor == Color.Yellow && c.Text != "--------------")
                {
                    c.Text = textboxContent[1];
                    c.BackColor = Color.White;
                }
                else if(c.BackColor == Color.Blue && c.Text != "--------------")
                {
                    c.Text = textboxContent[0];
                    c.BackColor = Color.White;
                }
                else if (c.BackColor == Color.Yellow && c.Text == "--------------")
                {
                    c.BackColor = Color.White;
                }
                else if (c.BackColor == Color.Blue && c.Text == "--------------")
                {
                    c.BackColor = Color.White;
                }
            }
            textboxContent[0] = null;
            textboxContent[1] = null;
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            foreach (Control c in this.Controls)
            {
                if (c.BackColor == Color.Yellow && c.Text != "--------------")
                {
                    c.Text = "";
                    c.BackColor = Color.White;
                    
                }
                else if (c.BackColor == Color.Blue && c.Text != "--------------")
                {
                    c.Text = "";
                    c.BackColor = Color.White;
                }
                else if (c.BackColor == Color.Yellow && c.Text == "--------------")
                {
                    c.BackColor = Color.White;
                }
                else if (c.BackColor == Color.Blue && c.Text == "--------------")
                {
                    c.BackColor = Color.White;
                }
            }
            textboxContent[0] = null;
            textboxContent[1] = null;
        }
        private void txt1stam_TextChanged_1(object sender, EventArgs e)
        {
            if(txt1stam.Text == "")
            {
                txt1stam.ReadOnly = false;
            }
            else
            {
                return;
            }
        }

        private void txt2ndam_TextChanged(object sender, EventArgs e)
        {
            if (txt2ndam.Text == "")
            {
                txt2ndam.ReadOnly = false;
            }
            else
            {
                return;
            }
        }

        private void txt1stpm_TextChanged(object sender, EventArgs e)
        {
            if (txt1stpm.Text == "")
            {
                txt1stpm.ReadOnly = false;
            }
            else
            {
                return;
            }
        }

        private void txt2ndpm_TextChanged(object sender, EventArgs e)
        {
            if (txt2ndpm.Text == "")
            {
                txt2ndpm.ReadOnly = false;
            }
            else
            {
                return;
            }
        }

        private void txt1stovertime_TextChanged(object sender, EventArgs e)
        {
            if (txt1stovertime.Text == "")
            {
                txt1stovertime.ReadOnly = false;
            }
            else
            {
                return;
            }
        }

        private void txt2ndovertime_TextChanged(object sender, EventArgs e)
        {
            if (txt2ndovertime.Text == "")
            {
                txt2ndovertime.ReadOnly = false;
            }
            else
            {
                return;
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            foreach (Control c in this.Controls)
            {
                if (c.BackColor == Color.Yellow && c.Text == "--------------")
                {
                    c.BackColor = Color.White;
                }
                else if (c.BackColor == Color.Blue && c.Text == "--------------")
                {
                    c.BackColor = Color.White;
                }
                else if (c.BackColor == Color.Yellow && c.Text != "--------------")
                {
                    c.BackColor = Color.White;
                }
                else if (c.BackColor == Color.Blue && c.Text != "--------------")
                {
                    c.BackColor = Color.White;
                }
            }
            textboxContent[0] = null;
            textboxContent[1] = null;
        }
    }
}
