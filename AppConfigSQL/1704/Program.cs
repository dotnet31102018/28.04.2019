using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1704
{
    class Program
    {
        static void Main(string[] args)
        {

            // Add reference to: System.Configuration!

            //Command and Data Reader
            using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["sqlGlobalDBConnection"].ConnectionString))
            {
                SqlCommand cmd = new SqlCommand("SELECT_STUDENTS_ID", conn);
                cmd.Parameters.Add(new SqlParameter("@id", 2));

                cmd.Connection.Open();
                cmd.CommandType = CommandType.StoredProcedure;

                SqlDataReader reader = cmd.ExecuteReader(CommandBehavior.Default);

                while (reader.Read() == true)
                {
                    Console.WriteLine($" {reader["ID"]} {reader["NAME"]} {reader["COUNTRY_ID"]}");
                }

                cmd.Connection.Close();
            }
        }
    }
}
