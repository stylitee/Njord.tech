
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalStaffManager.Class
{
    public class Job_InfoHelper
    {
        public static List<Job_Info> GetAllJobs()
        {
            List<Job_Info> list = null;

            using (Connection dal = new Connection())
            {
                if (!dal.IsConnected) return null;
                var data = dal.ExecuteQuery("GetJobList").Tables[0];

                list = new List<Job_Info>();

                foreach (DataRow dr in data.AsEnumerable())
                {
                    int job_id = dr.Field<int>("id");
                    string job_name = dr.Field<string>("title");

                    Job_Info job = new Job_Info() { jobID = job_id, title = job_name };
                    list.Add(job);
                }
            }
            return list;
        }
    }
}
