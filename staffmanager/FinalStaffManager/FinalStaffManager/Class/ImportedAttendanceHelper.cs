using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalStaffManager.Class
{
    public class ImportedAttendanceHelper
    {
        public static int flag = 0;
        public static List<string> scodes = new List<string>();
        public static void SaveImportedAttendance(AllImportedAttendance attendance, int empid)
        {
            using (Connection db_conn = new Connection())
            {
                if (!db_conn.IsConnected) return;
                SqlParameter[] param = {  
                                           new SqlParameter("@empid",               empid),
                                           new SqlParameter("@date",                attendance.date),
                                           new SqlParameter("@1stshiftIn",          attendance.firstShiftIn),
                                           new SqlParameter("@1stshiftOut",         attendance.firstShiftOut),
                                           new SqlParameter("@2ndshiftIn",          attendance.secondShiftIn),
                                           new SqlParameter("@2ndshiftOut",         attendance.secondShiftOut),
                                           new SqlParameter("@overtimeIn",          attendance.overtimeIn),
                                           new SqlParameter("@overtimeOut",         attendance.overtimeOut),
                                       };
                db_conn.ExecuteNonQuery("SaveImportedAttendance", param);
            }
        }

        public static void SaveActualAttendance(AllImportedAttendance attendance, int empid)
        {
            using (Connection db_conn = new Connection())
            {
                if (!db_conn.IsConnected) return;
                SqlParameter[] param = {  
                                           new SqlParameter("@empid",               empid),
                                           new SqlParameter("@date",                attendance.date),
                                           new SqlParameter("@1stshiftIn",          attendance.firstShiftIn),
                                           new SqlParameter("@1stshiftOut",         attendance.firstShiftOut),
                                           new SqlParameter("@2ndshiftIn",          attendance.secondShiftIn),
                                           new SqlParameter("@2ndshiftOut",         attendance.secondShiftOut),
                                           new SqlParameter("@overtimeIn",          attendance.overtimeIn),
                                           new SqlParameter("@overtimeOut",         attendance.overtimeOut),
                                       };
                db_conn.ExecuteNonQuery("SaveActualAttendance", param);
            }
        }

        public static List<AllImportedAttendance> checkDatesForData(SqlParameter[] p)
        {
            List<AllImportedAttendance> list = null;

            using (Connection dal = new Connection())
            {
                if (!dal.IsConnected) return null;
                var data = dal.ExecuteQuery("checkforData", p).Tables[0];

                list = new List<AllImportedAttendance>();

                foreach (DataRow dr in data.AsEnumerable())
                {

                    AllImportedAttendance attendance = new AllImportedAttendance();
                    attendance.id = dr.Field<int>("id");
                    attendance.empid = new Employee { empID = dr.Field<int>("employeeid") };
                    attendance.firstShiftIn = dr.Field<string>("firstshiftIn");
                    attendance.firstShiftOut = dr.Field<string>("firstshiftOut");
                    attendance.secondShiftIn = dr.Field<string>("secondshiftIn");
                    attendance.secondShiftOut = dr.Field<string>("secondshiftOut");
                    attendance.overtimeIn = dr.Field<string>("overtimeIn");
                    attendance.overtimeOut = dr.Field<string>("overtimeOut");
                    attendance.date = dr.Field<string>("date");

                    list.Add(attendance);
                    flag++;
                }
            }
            return list;
        }

        public static List<AllImportedAttendance> checkforDatainCorrected(SqlParameter[] p)
        {
            List<AllImportedAttendance> list = null;

            using (Connection dal = new Connection())
            {
                if (!dal.IsConnected) return null;
                var data = dal.ExecuteQuery("checkforDataCorrected", p).Tables[0];

                list = new List<AllImportedAttendance>();

                foreach (DataRow dr in data.AsEnumerable())
                {

                    AllImportedAttendance attendance = new AllImportedAttendance();
                    attendance.id = dr.Field<int>("id");
                    attendance.empid = new Employee { empID = dr.Field<int>("employeeid") };
                    attendance.firstShiftIn = dr.Field<string>("firstshiftIn");
                    attendance.firstShiftOut = dr.Field<string>("firstshiftOut");
                    attendance.secondShiftIn = dr.Field<string>("secondshiftIn");
                    attendance.secondShiftOut = dr.Field<string>("secondshiftOut");
                    attendance.overtimeIn = dr.Field<string>("overtimeIn");
                    attendance.overtimeOut = dr.Field<string>("overtimeOut");
                    attendance.date = dr.Field<string>("date");

                    list.Add(attendance);
                    flag++;
                }
            }
            return list;
        }

        public static List<string> selectRcodeAndScode(SqlParameter[] p)
        {

            List<string> list = null;

            using (Connection dal = new Connection())
            {
                if (!dal.IsConnected) return null;
                var data = dal.ExecuteQuery("getRcodeandScode", p).Tables[0];

                list = new List<string>();

                foreach (DataRow dr in data.AsEnumerable())
                {
                    scodes.Add(dr.Field<string>("scode_id"));
                }
            }
            return list;
        }
    }
}
