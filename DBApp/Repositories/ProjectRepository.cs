using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBApp.Repositories
{
    public class ProjectRepository
    {
        public static DataTable GetAllProjects(SqlConnection conn)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "SELECT * FROM Project";
            cmd.Connection = conn;

            SqlDataReader reader = cmd.ExecuteReader();
            DataTable employeeDT = new DataTable();
            employeeDT.Load(reader);
            return employeeDT;
        }
    }
}
