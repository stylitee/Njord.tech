using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalStaffManager.Class
{
    public class Schedule_PeriodHelper
    {
        public static void SaveSchedulePeriod(Schedule_Period s)
        {
            using (Connection db_conn = new Connection())
            {
                if (!db_conn.IsConnected) return;
                SqlParameter[] param = {  
                                           new SqlParameter("@begindate",               s.begindate),
                                           new SqlParameter("@enddate",                 s.enddate),
                                           new SqlParameter("@status",                  s.status),
                                           new SqlParameter("@num",                     s.numofscheed)
                                       };
                db_conn.ExecuteNonQuery("saveSchedulePeriod", param);
            }
        }

        public static void DeleteSchedulePeriod(Schedule_Period s)
        {
            using (Connection db_conn = new Connection())
            {
                if (!db_conn.IsConnected) return;
                SqlParameter[] param = {  
                                           new SqlParameter("@schedperiod",               s.scheduleperiod_id),
                                       };
                db_conn.ExecuteNonQuery("deleteSchedPeriod", param);
            }
        }

        public static void changeSchedulePeriodStatus(string status, int id)
        {
            using (Connection db_conn = new Connection())
            {
                if (!db_conn.IsConnected) return;
                SqlParameter[] param = {  
                                           new SqlParameter("@status",               status),
                                           new SqlParameter("@sched_id",          id)
                                       };
                db_conn.ExecuteNonQuery("changePeriodStatus", param);
            }
        }

        public static void SaveScheduleForADay(string scheduleperiod_id, string rcode, string date, string scode)
        {
            using (Connection db_conn = new Connection())
            {
                if (!db_conn.IsConnected) return;
                SqlParameter[] param = {  
                                           new SqlParameter("@rcode_id",                        rcode),
                                           new SqlParameter("@scode_id",                        scode),
                                           new SqlParameter("@schedulePeriod",                  scheduleperiod_id),
                                           new SqlParameter("@date",                            date),
                                       };
                db_conn.ExecuteNonQuery("saveRotationSchedule", param);
            }
        }

        public static List<Schedule_Period> getAllSchedulePeriod()
        {
            List<Schedule_Period> list = null;

            using (Connection dal = new Connection())
            {
                if (!dal.IsConnected) return null;
                var data = dal.ExecuteQuery("GetAllSchedulePeriod").Tables[0];

                list = new List<Schedule_Period>();

                foreach (DataRow dr in data.AsEnumerable())
                {

                    Schedule_Period s = new Schedule_Period();
                    s.scheduleperiod_id = dr.Field<int>("schedperiod_id");
                    s.begindate = dr.Field<string>("beginDate");
                    s.enddate = dr.Field<string>("endDate");
                    s.status = dr.Field<string>("Status");
                    s.numofscheed = dr.Field<int>("withSchedule");

                    list.Add(s);
                }
            }
            return list;
        }

        public static List<Schedule_Period> GetSelectedSchedulePeriod(SqlParameter[] p)
        {
            List<Schedule_Period> list = null;

            using (Connection dal = new Connection())
            {
                if (!dal.IsConnected) return null;
                var data = dal.ExecuteQuery("getSelectedSchedulePeriod", p).Tables[0];

                list = new List<Schedule_Period>();

                foreach (DataRow dr in data.AsEnumerable())
                {
                    Schedule_Period period = new Schedule_Period();
                    period.scheduleperiod_id = dr.Field<int>("schedperiod_id");
                    period.begindate = dr.Field<string>("beginDate");
                    period.enddate = dr.Field<string>("endDate");
                    period.status = dr.Field<string>("Status");
                    list.Add(period);
                }
            }
            return list;
        }

        public static void AddNumberOfSchedule(int num, int id)
        {
            using (Connection db_conn = new Connection())
            {
                if (!db_conn.IsConnected) return;
                SqlParameter[] param = {  
                                           new SqlParameter("@withSchedule",                    num),
                                           new SqlParameter("@schedperiod",                     id),
                                       };
                db_conn.ExecuteNonQuery("updateWithSchedule", param);
            }
        }

        
    }   
}
