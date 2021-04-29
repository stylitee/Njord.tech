using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalStaffManager.Class
{
    public class EmployeeScheduleHelper
    {
        public static void SaveEmployeeSchedule(EmployeeSchedule c)
        {
            using (Connection db_conn = new Connection())
            {
                if (!db_conn.IsConnected) return;
                SqlParameter[] param = {  
                                           new SqlParameter("@rotation_id",               c.rotationID),
                                           new SqlParameter("@emp_id",                     c.emp_id),
                                       };
                db_conn.ExecuteNonQuery("saveEmployeeSched", param);
            }
        }

        public static List<EmployeeSchedule> GetEmployeeSCHED(SqlParameter[] p)
        {
            List<EmployeeSchedule> list = null;
            Job_Info job = new Job_Info();

            using (Connection dal = new Connection())
            {
                if (!dal.IsConnected) return null;
                var data = dal.ExecuteQuery("getScheduleForAWeek", p).Tables[0];

                list = new List<EmployeeSchedule>();

                foreach (DataRow dr in data.AsEnumerable())
                {

                    EmployeeSchedule employeesched = new EmployeeSchedule();
                    employeesched.rot_id = new RotationSchedule()
                    {
                        scode = dr.Field<string>("scode_id"),
                        date = dr.Field<string>("date")

                    };
                    

                    list.Add(employeesched);
                }
            }
            return list;
        }

        public static List<EmployeeSchedule> getEmployeeSchedule(SqlParameter[] p)
        {
            List<EmployeeSchedule> list = null;

            using (Connection dal = new Connection())
            {
                if (!dal.IsConnected) return null;
                var data = dal.ExecuteQuery("selectEmployeeSchedule", p).Tables[0];

                list = new List<EmployeeSchedule>();

                foreach (DataRow dr in data.AsEnumerable())
                {
                    EmployeeSchedule c = new EmployeeSchedule();
                    c.id = dr.Field<int>("employeesched_id");
                    c.emp_id = dr.Field<int>("rotation_id");
                    c.rotationID = dr.Field<int>("rotation_id");
                    list.Add(c);
                }
            }
            return list;
        }
        public static List<EmployeeSchedule> getEmployeeID(SqlParameter[] p)
        {
            List<EmployeeSchedule> list = null;

            using (Connection dal = new Connection())
            {
                if (!dal.IsConnected) return null;
                var data = dal.ExecuteQuery("getEmployeeid", p).Tables[0];

                list = new List<EmployeeSchedule>();

                foreach (DataRow dr in data.AsEnumerable())
                {
                    EmployeeSchedule c = new EmployeeSchedule();
                    c.emp_id = dr.Field<int>("emp_id");
                    list.Add(c);
                }
            }
            return list;
        }
    }
}
