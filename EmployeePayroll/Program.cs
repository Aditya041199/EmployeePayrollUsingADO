using EmployeePayroll.Repository;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace EmplyoyeePayroll
{
    public class Program
    {
        static void Main(string[] args)
        {
            EmployeeRepository employee = new EmployeeRepository();
            employee.CreateDatabase();
        }
    }
}
