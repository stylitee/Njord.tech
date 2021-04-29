using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalStaffManager
{
    public partial class ScodeChoices : UserControl
    {
        public ScodeChoices()
        {
            InitializeComponent();
        }
        public static string code;
        private void btnRemove_Click(object sender, EventArgs e)
        {
            code = lblScode.Text;
            this.Parent.Controls.Remove(this);
        }
    }
}
