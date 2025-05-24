using System;
using System.Configuration;
using System.Data.SqlClient;

namespace FinServices_Dashboard.Logs
{
    public class APILogging
    {
        public static void Log(string request, string response)
        {
            string connStr = ConfigurationManager.ConnectionStrings["RechargeDB1"].ConnectionString;

            using (SqlConnection conn = new SqlConnection(connStr))
            {
                string query = @"INSERT INTO APILogs (RequestData, ResponseData, CreatedAt)
                                 VALUES (@req, @res, GETDATE())";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@req", request);
                cmd.Parameters.AddWithValue("@res", response);

                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }
    }
}
