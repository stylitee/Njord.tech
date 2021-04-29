using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace FinalStaffManager.Class
{
    public class RcodeHelper
    {
        public static int flag = 0;
        public static void DeleteRcode(string rcode)
        {
            using (Connection db_conn = new Connection())
            {
                if (!db_conn.IsConnected) return;
                SqlParameter[] param = {  
                                           new SqlParameter("@rcode",                rcode)
                                       };
                db_conn.ExecuteNonQuery("deleteRcode", param);
            }
         }
        public static void SaveRcode(int flag, RCODE r)
        {
            if(flag == 5)
            {
                using (Connection db_conn = new Connection())
                {
                    if (!db_conn.IsConnected) return;
                    SqlParameter[] param = {  
                                           new SqlParameter("@rcode",               r.rcode),
                                           new SqlParameter("@desc",                r.desc),
                                           new SqlParameter("@scode1",              r.scode1),
                                           new SqlParameter("@scode2",              r.scode2),
                                           new SqlParameter("@scode3",              r.scode3),
                                           new SqlParameter("@scode4",              r.scode4),
                                           new SqlParameter("@scode5",              r.scode5),
                                       };
                    db_conn.ExecuteNonQuery("SaveRcode", param);
                }
            }
            else if(flag == 4)
            {
                using (Connection db_conn = new Connection())
                {
                    if (!db_conn.IsConnected) return;
                    SqlParameter[] param = {  
                                           new SqlParameter("@rcode",               r.rcode),
                                           new SqlParameter("@desc",                r.desc),
                                           new SqlParameter("@scode1",              r.scode1),
                                           new SqlParameter("@scode2",              r.scode2),
                                           new SqlParameter("@scode3",              r.scode3),
                                           new SqlParameter("@scode4",              r.scode4),
                                           new SqlParameter("@scode5",              DBNull.Value),
                                       };
                    db_conn.ExecuteNonQuery("SaveRcode", param);
                }
            }
            else if(flag == 3)
            {
                using (Connection db_conn = new Connection())
                {
                    if (!db_conn.IsConnected) return;
                    SqlParameter[] param = {  
                                           new SqlParameter("@rcode",               r.rcode),
                                           new SqlParameter("@desc",                r.desc),
                                           new SqlParameter("@scode1",              r.scode1),
                                           new SqlParameter("@scode2",              r.scode2),
                                           new SqlParameter("@scode3",              r.scode3),
                                           new SqlParameter("@scode4",              DBNull.Value),
                                           new SqlParameter("@scode5",              DBNull.Value),
                                       };
                    db_conn.ExecuteNonQuery("SaveRcode", param);
                }
            }

        }

        public static List<RCODE> GetAllRcodes()
        {
            List<RCODE> list = null;

            using (Connection dal = new Connection())
            {
                if (!dal.IsConnected) return null;
                var data = dal.ExecuteQuery("GetAllRcode").Tables[0];

                list = new List<RCODE>();

                foreach (DataRow dr in data.AsEnumerable())
                {
                    string result = "";
                    int i = 0;

                    RCODE code = new RCODE();
                    code.rcode = dr.Field<string>("Rcode_ID");
                    code.desc = dr.Field<string>("desc");
                    result = Regex.Match(code.desc,@"\d+").Value;
                    i = Convert.ToInt32(result);
                    if(i == 5)
                    {
                        code.scode1 = dr.Field<string>("scode1");
                        code.scode2 = dr.Field<string>("scode2");
                        code.scode3 = dr.Field<string>("scode3");
                        code.scode4 = dr.Field<string>("scode4");
                        code.scode5 = dr.Field<string>("scode5");
                        flag = 5;
                    }
                    else if(i == 4)
                    {
                        code.scode1 = dr.Field<string>("scode1");
                        code.scode2 = dr.Field<string>("scode2");
                        code.scode3 = dr.Field<string>("scode3");
                        code.scode4 = dr.Field<string>("scode4");
                        flag = 4;
                    }
                    else
                    {
                        code.scode1 = dr.Field<string>("scode1");
                        code.scode2 = dr.Field<string>("scode2");
                        code.scode3 = dr.Field<string>("scode3");
                        flag = 3;
                    }
                    
                    list.Add(code);
                }
            }
            return list;
        }

        public static List<RCODE> GetSpecificRcodes(SqlParameter[] p)
        {
            List<RCODE> list = null;

            using (Connection dal = new Connection())
            {
                if (!dal.IsConnected) return null;
                var data = dal.ExecuteQuery("getSpecifiRcode", p).Tables[0];

                list = new List<RCODE>();

                foreach (DataRow dr in data.AsEnumerable())
                {
                    string result = "";
                    int i = 0;

                    RCODE code = new RCODE();
                    code.rcode = dr.Field<string>("Rcode_ID");
                    code.desc = dr.Field<string>("desc");
                    result = Regex.Match(code.desc, @"\d+").Value;
                    i = Convert.ToInt32(result);
                    if (i == 5)
                    {
                        code.scode1 = dr.Field<string>("scode1");
                        code.scode2 = dr.Field<string>("scode2");
                        code.scode3 = dr.Field<string>("scode3");
                        code.scode4 = dr.Field<string>("scode4");
                        code.scode5 = dr.Field<string>("scode5");
                        flag = 5;
                    }
                    else if (i == 4)
                    {
                        code.scode1 = dr.Field<string>("scode1");
                        code.scode2 = dr.Field<string>("scode2");
                        code.scode3 = dr.Field<string>("scode3");
                        code.scode4 = dr.Field<string>("scode4");
                        flag = 4;
                    }
                    else
                    {
                        code.scode1 = dr.Field<string>("scode1");
                        code.scode2 = dr.Field<string>("scode2");
                        code.scode3 = dr.Field<string>("scode3");
                        flag = 3;
                    }

                    list.Add(code);
                }
            }
            return list;
        }

        public static void UpdateRcode(int flag, RCODE r)
        {
            if (flag == 5)
            {
                using (Connection db_conn = new Connection())
                {
                    if (!db_conn.IsConnected) return;
                    SqlParameter[] param = {  
                                           new SqlParameter("@rcodeId",               r.rcode),
                                           new SqlParameter("@desc",                r.desc),
                                           new SqlParameter("@scode1",              r.scode1),
                                           new SqlParameter("@scode2",              r.scode2),
                                           new SqlParameter("@scode3",              r.scode3),
                                           new SqlParameter("@scode4",              r.scode4),
                                           new SqlParameter("@scode5",              r.scode5),
                                           new SqlParameter("@flag",                flag),
                                       };
                    db_conn.ExecuteNonQuery("updateRcode", param);
                }
            }
            else if (flag == 4)
            {
                using (Connection db_conn = new Connection())
                {
                    if (!db_conn.IsConnected) return;
                    SqlParameter[] param = {  
                                           new SqlParameter("@rcodeId",               r.rcode),
                                           new SqlParameter("@desc",                r.desc),
                                           new SqlParameter("@scode1",              r.scode1),
                                           new SqlParameter("@scode2",              r.scode2),
                                           new SqlParameter("@scode3",              r.scode3),
                                           new SqlParameter("@scode4",              r.scode4),
                                           new SqlParameter("@flag",                flag),
                                       };
                    db_conn.ExecuteNonQuery("updateRcode", param);
                }
            }
            else if (flag == 3)
            {
                using (Connection db_conn = new Connection())
                {
                    if (!db_conn.IsConnected) return;
                    SqlParameter[] param = {  
                                           new SqlParameter("@rcodeId",             r.rcode),
                                           new SqlParameter("@desc",                r.desc),
                                           new SqlParameter("@scode1",              r.scode1),
                                           new SqlParameter("@scode2",              r.scode2),
                                           new SqlParameter("@scode3",              r.scode3),
                                           new SqlParameter("@flag",                flag),
                                       };
                    db_conn.ExecuteNonQuery("updateRcode", param);
                }
            }

        }
    }
}
