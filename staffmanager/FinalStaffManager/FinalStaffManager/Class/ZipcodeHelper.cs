using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalStaffManager.Class
{
    public class ZipcodeHelper
    {
        public static List<ZipCode> GetAllJobs()
        {
            List<ZipCode> list = null;

            using (Connection dal = new Connection())
            {
                if (!dal.IsConnected) return null;
                var data = dal.ExecuteQuery("GetAllZipCodes").Tables[0];

                list = new List<ZipCode>();

                foreach (DataRow dr in data.AsEnumerable())
                {
                    string zipcode = dr.Field<string>("code");
                    string municipality = dr.Field<string>("municipality");

                    ZipCode job = new ZipCode() { Zipcode = zipcode, Municipality = municipality };
                    list.Add(job);
                }
            }
            return list;
        }
       
        public static List<ZipCode> SearchMunicipality(SqlParameter[] p)
        {
            List<ZipCode> list = null;
            using (Connection dal = new Connection())
            {
                if (!dal.IsConnected) return null;
                var data = dal.ExecuteQuery("GetSpecificZipcode", p).Tables[0];
                
                list = new List<ZipCode>();

                foreach (DataRow dr in data.AsEnumerable())
                {

                    string muni = dr.Field<string>("municipality");
                    ZipCode zip = new ZipCode()
                    {
                        Municipality = muni
                    };
                    
                    list.Add(zip);
                }
            }
            return list;
        }
    }
}
