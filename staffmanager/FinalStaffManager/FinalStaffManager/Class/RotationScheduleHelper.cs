using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalStaffManager.Class
{
    public class RotationScheduleHelper
    {
        
        public static List<RotationSchedule> getRcodeinSchedulerPeriod(SqlParameter[] p)
        {
            List<RotationSchedule> list = null;

            using (Connection dal = new Connection())
            {
                if (!dal.IsConnected) return null;
                var data = dal.ExecuteQuery("getRcodeInRotationSchedule", p).Tables[0];

                list = new List<RotationSchedule>();

                foreach (DataRow dr in data.AsEnumerable())
                {
                    RotationSchedule s = new RotationSchedule();
                    s.rcode = dr.Field<string>("rcode_id");
                    s.scode = dr.Field<string>("scode_id");
                    list.Add(s);
                }
            }
            return list;
        }

        

        //public static List<RotationSchedule> getScodeinSchedulerPeriod(SqlParameter[] p)
        //{
        //    List<RotationSchedule> list = null;

        //    using (Connection dal = new Connection())
        //    {
        //        if (!dal.IsConnected) return null;
        //        var data = dal.ExecuteQuery("getRcodeInRotationSchedule", p).Tables[0];

        //        list = new List<RotationSchedule>();

        //        foreach (DataRow dr in data.AsEnumerable())
        //        {
        //            RotationSchedule s = new RotationSchedule();
        //            s.rcode = dr.Field<string>("rcode_id");

        //            list.Add(s);
        //        }
        //    }
        //    return list;
        //}

        public static List<RotationSchedule> getAllRotationSchedule()
        {
            List<RotationSchedule> list = null;

            using (Connection dal = new Connection())
            {
                if (!dal.IsConnected) return null;
                var data = dal.ExecuteQuery("[getAllRotationSched]").Tables[0];

                list = new List<RotationSchedule>();

                foreach (DataRow dr in data.AsEnumerable())
                {
                    RotationSchedule s = new RotationSchedule();
                    s.rotationId        = dr.Field<int>("rotation_id");
                    s.rcode             = dr.Field<string>("rcode_id");
                    s.scode             = dr.Field<string>("scode_id");
                    s.schedulePeriodId  = dr.Field<int>("schedperiod_id");
                    s.date              = dr.Field<string>("date");

                    list.Add(s);
                }
            }
            return list;
        }

        public static int getRotationID(SqlParameter[] p)
        {
            int id = 0;
            List<RotationSchedule> list = null;

            using (Connection dal = new Connection())
            {
                if (!dal.IsConnected) return 0;
                var data = dal.ExecuteQuery("getRotationID", p).Tables[0];

                list = new List<RotationSchedule>();

                foreach (DataRow dr in data.AsEnumerable())
                {
                    id = dr.Field<int>("rotation_id");
                }
            }
            return id;
        }

        public static List<RotationSchedule> getRotationIDValidaition(SqlParameter[] p)
        {
            int id = 0;
            List<RotationSchedule> list = null;

            using (Connection dal = new Connection())
            {
                if (!dal.IsConnected) return null;
                var data = dal.ExecuteQuery("getRotationIDValidation", p).Tables[0];

                list = new List<RotationSchedule>();

                foreach (DataRow dr in data.AsEnumerable())
                {
                    RotationSchedule r = new RotationSchedule();
                    r.rotationId = dr.Field<int>("rotation_id");

                    list.Add(r);
                }
            }
            return list;
        }

        public static List<RotationSchedule> getRotationDates(SqlParameter[] p)
        {
            List<RotationSchedule> list = null;

            using (Connection dal = new Connection())
            {
                if (!dal.IsConnected) return null;
                var data = dal.ExecuteQuery("rotationDates", p).Tables[0];

                list = new List<RotationSchedule>();

                foreach (DataRow dr in data.AsEnumerable())
                {
                    RotationSchedule s = new RotationSchedule();
                    s.date = dr.Field<string>("date");
                    list.Add(s);
                }
            }
            return list;
        }

        
    }
}
