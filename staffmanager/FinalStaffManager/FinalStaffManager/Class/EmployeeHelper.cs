using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalStaffManager.Class
{
    public class EmployeeHelper
    {
        public static string middlename;

        public static string getSpecificEmployee(SqlParameter []p)
        {
            List<Employee> list = null;
            Job_Info job = new Job_Info();

            using (Connection dal = new Connection())
            {
                if (!dal.IsConnected) return null;
                var data = dal.ExecuteQuery("getSpecificEmployee",p).Tables[0];

                list = new List<Employee>();

                foreach (DataRow dr in data.AsEnumerable())
                {
                    string fullname, fname, lname, mname;
                    lname = dr.Field<string>("lastname");
                    fname = dr.Field<string>("firstname");
                    mname = dr.Field<string>("middlename");

                    fullname = fname + " " + lname;
                    return fullname;
                }
            }
            return "";
        }
        public static List<Employee> GetAllEmployees()
        {
            List<Employee> list = null;
            Job_Info job = new Job_Info();

            using (Connection dal = new Connection())
            {
                if (!dal.IsConnected) return null;
                var data = dal.ExecuteQuery("GetEmployeeList").Tables[0];

                list = new List<Employee>();

                foreach (DataRow dr in data.AsEnumerable())
                {
                    string fullname = "";
                    Employee employee = new Employee();
                    employee.empID = dr.Field<int>("id");
                    employee.lastName = dr.Field<string>("lastname");
                    employee.firstName = dr.Field<string>("firstname");
                    employee.middleName = dr.Field<string>("middlename");
                    employee.gender = dr.Field<string>("gender");
                    employee.birthdate = dr.Field<string>("birthdate");
                    employee.employeePic = dr.Field<string>("photo");
                    employee.digitalSignature = dr.Field<string>("signature");
                    employee.job = new Job_Info() { title = dr.Field<string>("title") };
                    if(employee.middleName == "")
                    {
                        fullname = employee.lastName + ", " + employee.firstName;
                    }
                    else
                    {
                        fullname = employee.lastName + ", " + employee.firstName + ", " + employee.middleName.Substring(0, 1);
                    }
                    middlename = employee.middleName;
                    employee.fullname = fullname;
                    employee.address = dr.Field<string>("address");
                    employee.ZipCode = new ZipCode() { Zipcode = dr.Field<string>("code"), Municipality = dr.Field<string>("municipality") };
                    employee.emailaddress = dr.Field<string>("email_address");
                    employee.UMID = dr.Field<string>("UMID");
                    employee.TIN = dr.Field<string>("TIN");
                    employee.BankAccountNumber = dr.Field<string>("BankAccountNumber");
                    employee.taxExempStatus = dr.Field<string>("TaxExemptionStatus");
                    employee.DCR = dr.Field<string>("DailyContractRate"); //dcr in double, should be string
                    employee.overtimeRate = dr.Field<string>("OverTime");
                    employee.phoneNumber = dr.Field<string>("phone_no");
                    employee.HomePhone = dr.Field<string>("homephone");
                    if (employee.phoneNumber == null || employee.phoneNumber == "")
                    {
                        employee.phonenum.Add("N/A");
                    }
                    else if (employee.phoneNumber.Contains(','))
                    {
                        string[] myphone = employee.phoneNumber.Split(',');
                        for (int i = 0; i < myphone.Count(); i++)
                        {
                            employee.phonenum.Add(myphone[i]);
                        }

                    }

                    if (employee.HomePhone == "" || employee.HomePhone == null)
                    {
                        employee.homephone.Add("N/A");
                        
                    }
                    else if (employee.HomePhone.Contains(','))
                    {
                        string[] myhomephone = employee.HomePhone.Split(',');
                        for (int i = 0; i < myhomephone.Count(); i++)
                        {
                            employee.homephone.Add(myhomephone[i]);
                        }
                    }
                    
                    list.Add(employee);
                }
            }
            return list;
        }

        public static void SaveEmployee(Employee employee, int job_id, string zipcode)
        {
            using (Connection db_conn = new Connection())
            {
                if (!db_conn.IsConnected) return;
                SqlParameter[] param = {  
                                           new SqlParameter("@lastname",            employee.lastName),
                                           new SqlParameter("@firstname",           employee.firstName),
                                           new SqlParameter("@middlename",          employee.middleName),
                                           new SqlParameter("@gender",              employee.gender),
                                           new SqlParameter("@birthdate",           employee.birthdate),
                                           new SqlParameter("@photo",               employee.employeePic),
                                           new SqlParameter("@signature",           employee.digitalSignature),
                                           new SqlParameter("@jobid",               job_id),
                                           new SqlParameter("@address",              employee.address),
                                           new SqlParameter("@zip_code",            zipcode),
                                           new SqlParameter("@email_address",       employee.emailaddress),
                                           new SqlParameter("@UMID",                employee.UMID),
                                           new SqlParameter("@TIN",                 employee.TIN),
                                           new SqlParameter("@BankAccountNumber",   employee.BankAccountNumber),
                                           new SqlParameter("@TaxExemptionStatus",  employee.taxExempStatus),
                                           new SqlParameter("@DailyContractRate",   employee.DCR),
                                           new SqlParameter("@OverTime",            employee.overtimeRate),
                                           new SqlParameter("@phone_no",            employee.phoneNumber),
                                           new SqlParameter("@homephone",           employee.HomePhone),
                                       };
                db_conn.ExecuteNonQuery("SaveEmployee", param);
            }
        }

        public static List<Employee> GetAllEmployeesUpdate(SqlParameter[] p)
        {
            List<Employee> list = null;
            Job_Info job = new Job_Info();

            using (Connection dal = new Connection())
            {
                if (!dal.IsConnected) return null;
                var data = dal.ExecuteQuery("getSelectedEmployeeDetails",p).Tables[0];

                list = new List<Employee>();

                foreach (DataRow dr in data.AsEnumerable())
                {

                    Employee employee = new Employee();
                    employee.empID = dr.Field<int>("id");
                    employee.lastName = dr.Field<string>("lastname");
                    employee.firstName = dr.Field<string>("firstname");
                    employee.middleName = dr.Field<string>("middlename");
                    employee.gender = dr.Field<string>("gender");
                    employee.birthdate = dr.Field<string>("birthdate");
                    employee.employeePic = dr.Field<string>("photo");
                    employee.digitalSignature = dr.Field<string>("signature");
                    employee.job = new Job_Info() { title = dr.Field<string>("title") };
                    string fullname = employee.lastName + ", " + employee.firstName + ", " + employee.middleName.Substring(0, 1);
                    middlename = employee.middleName;
                    employee.fullname = fullname;
                    employee.address = dr.Field<string>("address");
                    employee.ZipCode = new ZipCode() { Zipcode = dr.Field<string>("code"), Municipality = dr.Field<string>("municipality") };
                    employee.emailaddress = dr.Field<string>("email_address");
                    employee.UMID = dr.Field<string>("UMID");
                    employee.TIN = dr.Field<string>("TIN");
                    employee.BankAccountNumber = dr.Field<string>("BankAccountNumber");
                    employee.taxExempStatus = dr.Field<string>("TaxExemptionStatus");
                    employee.DCR = dr.Field<string>("DailyContractRate"); //dcr in double, should be string
                    employee.overtimeRate = dr.Field<string>("OverTime");
                    employee.phoneNumber = dr.Field<string>("phone_no");
                    employee.HomePhone = dr.Field<string>("homephone");
                    if (employee.phoneNumber == null || employee.phoneNumber == "")
                    {
                        employee.phonenum.Add("N/A");
                    }
                    else if (employee.phoneNumber.Contains(','))
                    {
                        string[] myphone = employee.phoneNumber.Split(',');
                        for (int i = 0; i < myphone.Count(); i++)
                        {
                            employee.phonenum.Add(myphone[i]);
                        }

                    }

                    if (employee.HomePhone == "" || employee.HomePhone == null)
                    {
                        employee.homephone.Add("N/A");

                    }
                    else if (employee.HomePhone.Contains(','))
                    {
                        string[] myhomephone = employee.HomePhone.Split(',');
                        for (int i = 0; i < myhomephone.Count(); i++)
                        {
                            employee.homephone.Add(myhomephone[i]);
                        }
                    }

                    list.Add(employee);
                }
            }
            return list;
        }

        public static void DeleteEmployee(int empid)
        {
            using (Connection db_conn = new Connection())
            {
                if (!db_conn.IsConnected) return;
                SqlParameter[] param = {  
                                           new SqlParameter("@id",       empid)
                                       };
                db_conn.ExecuteNonQuery("DeleteEmployee", param);
            }
        }

        public static void UpdateEmployee(Employee employee, int jobid, int empid, string zipcode, string homephone)
        {
            using (Connection db_conn = new Connection())
            {
                if (!db_conn.IsConnected) return;
                SqlParameter[] param = {  
                                           new SqlParameter("@lastname",            employee.lastName),
                                           new SqlParameter("@firstname",           employee.firstName),
                                           new SqlParameter("@middlename",          employee.middleName),
                                           new SqlParameter("@gender",              employee.gender),
                                           new SqlParameter("@birthdate",           employee.birthdate),
                                           new SqlParameter("@photo",               employee.employeePic),
                                           new SqlParameter("@signature",           employee.digitalSignature),
                                           new SqlParameter("@jobid",               jobid),
                                           new SqlParameter("@address",             employee.address),
                                           new SqlParameter("@zip_code",            zipcode),
                                           new SqlParameter("@email_address",       employee.emailaddress),
                                           new SqlParameter("@UMID",                employee.UMID),
                                           new SqlParameter("@TIN",                 employee.TIN),
                                           new SqlParameter("@BankAccountNumber",   employee.BankAccountNumber),
                                           new SqlParameter("@TaxExemptionStatus",  employee.taxExempStatus),
                                           new SqlParameter("@DailyContractRate",   employee.DCR),
                                           new SqlParameter("@OverTime",            employee.overtimeRate),
                                           new SqlParameter("@phone_no",            employee.phoneNumber),
                                           new SqlParameter("@homephone",           homephone),
                                           new SqlParameter("@empid",               empid)

                                       };
                db_conn.ExecuteNonQuery("updateEmployee", param);
            }
        }

        public static List<Employee> getOffEmployee(SqlParameter[] p)
        {
            List<Employee> list = null;

            using (Connection dal = new Connection())
            {
                if (!dal.IsConnected) return null;
                var data = dal.ExecuteQuery("getSpecificEmployee", p).Tables[0];

                list = new List<Employee>();

                foreach (DataRow dr in data.AsEnumerable())
                {
                    Employee emp = new Employee();
                    emp.lastName = dr.Field<string>("lastname");
                    emp.firstName = dr.Field<string>("firstname");
                    emp.middleName = dr.Field<string>("middlename");
                    emp.fullname = emp.firstName + " " + emp.lastName;
                    list.Add(emp);
                }
            }
            return list;
        }
    }
}
