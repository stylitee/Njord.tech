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
    public partial class OtherSchedulingPeriodRow : UserControl
    {
        public OtherSchedulingPeriodRow()
        {
            InitializeComponent();
        }
        public static List<Label> lbl = new List<Label>();
        private void OtherSchedulingPeriodRow_Load(object sender, EventArgs e)
        {
            lbl.Add(lblScodeDay1);
            lbl.Add(lblScodeDay2);
            lbl.Add(lblScodeDay3);
            lbl.Add(lblScodeDay4);
            lbl.Add(lblScodeDay5);
            lbl.Add(lblScodeDay6);
            lbl.Add(lblScodeDay7);
        }
    }
}
