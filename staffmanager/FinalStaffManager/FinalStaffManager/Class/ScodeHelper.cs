using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalStaffManager.Class
{
    public class ScodeHelper
    {
        public static void SaveScode(SCODE scode)
        {
            using (Connection db_conn = new Connection())
            {
                if (!db_conn.IsConnected) return;
                SqlParameter[] param = {  
                                           new SqlParameter("@code",            scode.scode),
                                           new SqlParameter("@description",           scode.desc),
                                           new SqlParameter("@firstIn",          scode.firstIn),
                                           new SqlParameter("@firstOut",              scode.firstOut),
                                           new SqlParameter("@secondIn",           scode.secondIn),
                                           new SqlParameter("@secondOut",               scode.secondOut),
                                       };
                db_conn.ExecuteNonQuery("SaveSCODE", param);
            }
        }

        public static List<SCODE> GetAllScodes()
        {
            List<SCODE> list = null;

            using (Connection dal = new Connection())
            {
                if (!dal.IsConnected) return null;
                var data = dal.ExecuteQuery("GetScode").Tables[0];

                list = new List<SCODE>();
                
                foreach (DataRow dr in data.AsEnumerable())
                {

                    SCODE code = new SCODE();
                    code.scode = dr.Field<string>("Scode_ID");
                    code.desc = dr.Field<string>("desc");
                    code.firstIn = dr.Field<string>("firstTimeIn");
                    code.firstOut = dr.Field<string>("firstTimeOut");
                    code.secondIn = dr.Field<string>("SecondTimeIn");
                    code.secondOut = dr.Field<string>("SecondTimeOut");

                    list.Add(code);
                }
            }
            return list;
        }

        public static List<SCODE> GetSelectedScode(SqlParameter[] p)
        {
            List<SCODE> list = null;

            using (Connection dal = new Connection())
            {
                if (!dal.IsConnected) return null;
                var data = dal.ExecuteQuery("getSelectedScode", p).Tables[0];

                list = new List<SCODE>();

                foreach (DataRow dr in data.AsEnumerable())
                {
                    SCODE code = new SCODE();
                    code.scode = dr.Field<string>("Scode_ID");
                    code.desc = dr.Field<string>("desc");
                    code.firstIn = dr.Field<string>("firstTimeIn");
                    code.firstOut = dr.Field<string>("firstTimeOut");
                    code.secondIn = dr.Field<string>("SecondTimeIn");
                    code.secondOut = dr.Field<string>("SecondTimeOut");
                    list.Add(code);
                }
            }
            return list;
        }

        public static void UpdateScode(SCODE scode)
        {
            using (Connection db_conn = new Connection())
            {
                if (!db_conn.IsConnected) return;
                SqlParameter[] param = {  
                                           new SqlParameter("@code",            scode.scode),
                                           new SqlParameter("@desc",           scode.desc),
                                           new SqlParameter("@firstIn",          scode.firstIn),
                                           new SqlParameter("@firstOut",              scode.firstOut),
                                           new SqlParameter("@secondIn",           scode.secondIn),
                                           new SqlParameter("@secondOut",               scode.secondOut),
                                       };
                db_conn.ExecuteNonQuery("UpdateScode", param);
            }
        }

        public static void DeleteScode(string scode)
        {
            using (Connection db_conn = new Connection())
            {
                if (!db_conn.IsConnected) return;
                SqlParameter[] param = {  
                                           new SqlParameter("@code",            scode),
                                       };
                db_conn.ExecuteNonQuery("DeleteScode", param);
            }
        }

    }
}
