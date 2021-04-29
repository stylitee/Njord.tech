using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalStaffManager.Forms
{
    public partial class PrintSchedule : Form
    {
        public PrintSchedule()
        {
            InitializeComponent();
        }
        Bitmap bmp;
        private void printWeeklySched_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(bmp, 0, 0);
        }

        private void PrintSchedule_Load(object sender, EventArgs e)
        {
            btnPrint.Show();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            
            Graphics g = this.CreateGraphics();
            bmp = new Bitmap(this.Size.Width, this.Size.Height, g);
            Graphics mg = Graphics.FromImage(bmp);
            mg.CopyFromScreen(this.Location.X, this.Location.Y, 100, 50, this.Size);
            printPreviewDialog1.ShowDialog();
        }

        public void loadData()
        {
            if(schedulePeriodMenu.schedstatus != "Close")
            {

            }
        }

        private void printPreviewDialog1_Load(object sender, EventArgs e)
        {

        }
    }
}
