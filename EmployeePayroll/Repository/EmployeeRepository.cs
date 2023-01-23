using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeePayroll.Repository
{
    public class EmployeeRepository
    {
        SqlConnection connection = new SqlConnection(@"Data Source=DESKTOP-835JJ2N;Initial catalog=master;
                                  Integrated Security=true");
        public void CreateDatabase()
        {

            SqlCommand cmd = new SqlCommand("Create database EmpPayroll", connection);
            connection.Open();
            cmd.ExecuteNonQuery();
            Console.WriteLine("Database created successfully");
        }
    }
}
