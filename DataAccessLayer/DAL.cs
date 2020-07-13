using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using Models;


namespace DataAccessLayer
{
    public class DAL
    {
        string connString = ConfigurationManager.ConnectionStrings["StepUpleadConn"].ToString();

        public bool SaveEmployeeDetails(Employee emp)
        {
            SqlConnection conn = new SqlConnection(connString);
            bool isSaved = false;
            int result = 0;
            try
            {
                SqlCommand cmd = new SqlCommand("Save_Employee_Details", conn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@first_name", emp.first_name);
                cmd.Parameters.AddWithValue("@last_name", emp.last_name);
                cmd.Parameters.AddWithValue("@email", emp.email);
                cmd.Parameters.AddWithValue("@company_name", emp.company_name);
                cmd.Parameters.AddWithValue("@company_size", emp.company_size);
                cmd.Parameters.AddWithValue("@job_role", emp.job_role);
                cmd.Parameters.AddWithValue("@job_dept", emp.job_dept);
                cmd.Parameters.AddWithValue("@phone", emp.phone);
                cmd.Parameters.AddWithValue("@country", emp.country);
                cmd.Parameters.AddWithValue("@ip_address", emp.ip_address);
                cmd.Parameters.AddWithValue("@browser_details", emp.browser_details);
                cmd.Parameters.AddWithValue("@url_link", emp.url_link);
                cmd.Parameters.AddWithValue("@os_info", emp.os_info);

                
                if (conn.State != ConnectionState.Open)
                {
                    conn.Open();
                }

                result = cmd.ExecuteNonQuery();

                if (result > 0)
                {
                    isSaved = true;
                }

                return isSaved;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
