using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
 
namespace CC2
{
    class Pgm1
    {
        public static SqlConnection con;
        public static SqlCommand cmd;
        

        static void Main(string[] args)
        {
            Console.WriteLine("enter employee name");
            string name = Console.ReadLine();
            Console.WriteLine("enter employee salary");
            decimal sal = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("enter employeeType");
            char emptype = Convert.ToChar(Console.ReadLine());

            con = new SqlConnection("data source=ICS-LT-CT2RQ73\\SQLEXPRESS; initial catalog=employeeManagement;" +
                "user id=sa;password=123456789;");
            con.Open();
            cmd = new SqlCommand("InsertEmp_Details", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@empname", name);
            cmd.Parameters.AddWithValue("empsal", sal);
            cmd.Parameters.AddWithValue("@emptype", emptype);

            int Total_rows = cmd.ExecuteNonQuery();
            Console.WriteLine($"Inserted the rows effected successfully.");
            Console.Read();
        }
    }
}
