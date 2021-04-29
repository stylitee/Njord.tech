using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalStaffManager.Class
{
    public class EmployeeOFFHelper
    {
        public static int emmployee_ID = 0; 
        public static void saveEmployeeOf(int id, string schedid, string date)
        {
            using (Connection db_conn = new Connection())
            {
                if (!db_conn.IsConnected) return;
                SqlParameter[] param = {  
                                           new SqlParameter("@empid",               id),
                                           new SqlParameter("@schedperiodID",       schedid),
                                           new SqlParameter("@date",                date),
                                       };
                db_conn.ExecuteNonQuery("setEmployeeOff", param);
            }
        }

        public static List<EmployeeOFF> getEmployeeID(SqlParameter[] p)
        {
            List<EmployeeOFF> list = null;

            using (Connection dal = new Connection())
            {
                if (!dal.IsConnected) return null;
                var data = dal.ExecuteQuery("selectEmployeeDayOff", p).Tables[0];

                list = new List<EmployeeOFF>();

                foreach (DataRow dr in data.AsEnumerable())
                {
                    emmployee_ID = dr.Field<int>("emp_id");
                }
            }
            return list;
        }
    }
}
