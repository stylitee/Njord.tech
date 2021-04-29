using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalStaffManager.Class
{
    public class SCODE
    {
        public string scode { get; set; }
        public string desc { get; set; }
        public string firstIn { get; set; }
        public string firstOut { get; set; }
        public string secondIn { get; set; }
        public string secondOut { get; set; }

        public static void SaveScode(TextBox code, TextBox desc, TextBox firstIn, TextBox firstOut,
                                      TextBox secondIn, TextBox secondOut)
        {
            SCODE scodes = new SCODE();
            scodes.scode = code.Text;
            scodes.desc = desc.Text;
            scodes.firstIn = firstIn.Text;
            scodes.firstOut = firstOut.Text;
            scodes.secondIn = secondIn.Text;
            scodes.secondOut = secondOut.Text;
            try
            {
                ScodeHelper.SaveScode(scodes);
                MessageBox.Show("Scode succesfully saved!", "SCODE Saving", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception)
            {
                MessageBox.Show("Cannot save SCODE due to same SCODE found in the database");
            }
        }

        public static void Update(TextBox code, TextBox desc, TextBox firstIn, TextBox firstOut,
                                      TextBox secondIn, TextBox secondOut)
        {
            SCODE scodes = new SCODE();
            scodes.scode = code.Text;
            scodes.desc = desc.Text;
            scodes.firstIn = firstIn.Text;
            scodes.firstOut = firstOut.Text;
            scodes.secondIn = secondIn.Text;
            scodes.secondOut = secondOut.Text;

            ScodeHelper.UpdateScode(scodes);
            MessageBox.Show("Scode succesfully updated!", "SCODE Saving", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public static void deleteEmployee(string code)
        {
            ScodeHelper.DeleteScode(code);
            MessageBox.Show("Scode deleted succesfully!", "SCODE deletetion", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
