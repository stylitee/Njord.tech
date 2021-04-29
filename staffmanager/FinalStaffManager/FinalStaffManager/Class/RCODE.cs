using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalStaffManager.Class
{
    public class RCODE
    {
        public string rcode { get; set; }
        public string desc { get; set; }
        public string scode1 { get; set; }
        public string scode2 { get; set; }
        public string scode3 { get; set; }
        public string scode4 { get; set; }
        public string scode5 { get; set; }

        public static void saveRcode(string rcode, string desc, string scode1, string scode2, string scode3, string scode4, string scode5, int flag)
        {
            //try
            //{
                RCODE r = new RCODE();
                if (flag == 5)
                {
                    r.rcode = rcode;
                    r.desc = desc;
                    r.scode1 = scode1;
                    r.scode2 = scode2;
                    r.scode3 = scode3;
                    r.scode4 = scode4;
                    r.scode5 = scode5;
                    RcodeHelper.SaveRcode(flag, r);
                }
                else if (flag == 4)
                {
                    r.rcode = rcode;
                    r.desc = desc;
                    r.scode1 = scode1;
                    r.scode2 = scode2;
                    r.scode3 = scode3;
                    r.scode4 = scode4;
                    RcodeHelper.SaveRcode(flag, r);
                }
                else if (flag == 3)
                {
                    r.rcode = rcode;
                    r.desc = desc;
                    r.scode1 = scode1;
                    r.scode2 = scode2;
                    r.scode3 = scode3;
                    RcodeHelper.SaveRcode(flag, r);
                }
                MessageBox.Show("Rcode saved succesfully", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //}
            //catch (Exception)
            //{
            //    MessageBox.Show("Saving fail, some fields is missing", "Saving Fail", MessageBoxButtons.OK, MessageBoxIcon.Information); ;
            //}
            
        }

        public static void UpdateRcode(string rcode, string desc, string scode1, string scode2, string scode3, string scode4, string scode5, int flag)
        {
            try
            {
                RCODE r = new RCODE();
                if (flag == 5)
                {
                    r.rcode = rcode;
                    r.desc = desc;
                    r.scode1 = scode1;
                    r.scode2 = scode2;
                    r.scode3 = scode3;
                    r.scode4 = scode4;
                    r.scode5 = scode5;
                    RcodeHelper.UpdateRcode(flag, r);
                }
                else if (flag == 4)
                {
                    r.rcode = rcode;
                    r.desc = desc;
                    r.scode1 = scode1;
                    r.scode2 = scode2;
                    r.scode3 = scode3;
                    r.scode4 = scode4;
                    RcodeHelper.UpdateRcode(flag, r);
                }
                else if (flag == 3)
                {
                    r.rcode = rcode;
                    r.desc = desc;
                    r.scode1 = scode1;
                    r.scode2 = scode2;
                    r.scode3 = scode3;
                    RcodeHelper.UpdateRcode(flag, r);
                }
                MessageBox.Show("Rcode update succesfully", "Update", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception)
            {
                throw;
                //MessageBox.Show("Rcode update failed", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }
    }
}
