using DBApp.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DBApp.Repositories
{
    public class EmployeeRepository
    {
        // Get ALL employees 
        public static DataTable GetAllEmployees(SqlConnection conn)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "SELECT * FROM Employee";
            cmd.Connection = conn;

            SqlDataReader reader = cmd.ExecuteReader();
            DataTable employeeDT = new DataTable();
            employeeDT.Load(reader);
            return employeeDT;
        }
        
        // Get employee by ID
        public static Employee GetEmployeeByID(SqlConnection conn,  int employeeID)
        {
            try
            {
                SqlCommand selectCommand = new SqlCommand();
                selectCommand.Connection = conn;
                selectCommand.CommandText = "SELECT * FROM Employee WHERE EmployeeID = @EmployeeID";
                selectCommand.Parameters.AddWithValue("EmployeeID", employeeID); 

                SqlDataReader reader = selectCommand.ExecuteReader();
                if (!reader.Read())
                    throw new Exception("Zaposleni ne postoji!"); 

                Employee employee = new Employee();
                employee.EmployeeID = reader.GetInt32(0); 
                employee.Name = reader.GetString(1);    
                employee.Surname = reader.GetString(2);
                employee.Salary = reader.GetDecimal(3);
                employee.Birthday = reader.GetDateTime(4);  

                reader.Close();
                return employee;
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        // Insert employee 
        public static bool InsertEmployee(Employee emp, SqlConnection conn)
        {
            try
            {
                SqlCommand insertCommand = new SqlCommand();
                insertCommand.Connection = conn;

                insertCommand.CommandText = "INSERT INTO Employee(Name, Surname, Salary, Birthday)" +
                                            "VALUES (@Name, @Surname, @Salary, @Birthday)";
                insertCommand.Parameters.AddWithValue("Name", emp.Name);
                insertCommand.Parameters.AddWithValue("Surname", emp.Surname);
                insertCommand.Parameters.AddWithValue("Salary", emp.Salary);
                insertCommand.Parameters.AddWithValue("Birthday", emp.Birthday);

                int affectedRows = insertCommand.ExecuteNonQuery();
                return affectedRows > 0;
            }
            catch (Exception ex)
            {
                return false;
            }
            
        }

        // Update employee 
        public static bool UpdateEmployee(Employee emp, SqlConnection conn)
        {
            try
            {
                SqlCommand updateCommand = new SqlCommand();
                updateCommand.Connection = conn;
                updateCommand.CommandText = "UPDATE Employee " +
                                            "SET Name = @Name, " +
                                            "Surname = @Surname, " +
                                            "Salary = @Salary, " +
                                            "Birthday = @Birthday " +
                                            "WHERE EmployeeID = @EmployeeID";
                updateCommand.Parameters.AddWithValue("Name", emp.Name);
                updateCommand.Parameters.AddWithValue("Surname", emp.Surname);
                updateCommand.Parameters.AddWithValue("Salary", emp.Salary);
                updateCommand.Parameters.AddWithValue("Birthday", emp.Birthday);
                updateCommand.Parameters.AddWithValue("EmployeeID", emp.EmployeeID); 

                int affectedRows = updateCommand.ExecuteNonQuery();
                return affectedRows > 0;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        // Delete employee 
        public static bool DeleteEmployee(int employeeID, SqlConnection conn)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = "DELETE FROM Employee WHERE EmployeeID = @EmployeeID";
                cmd.Parameters.AddWithValue("EmployeeID", employeeID); 
                int affectedRows = cmd.ExecuteNonQuery();
                return affectedRows > 0;
            }
            catch 
            {
                return false;
            }
        }
    
        // Search employees 
        public static DataTable SearchEmployees(string searchText, 
                                                decimal salaryFrom, 
                                                decimal salaryTo, 
                                                SqlConnection conn)
        {
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.Connection = conn;

            // Kreiranje upita 
            if (salaryFrom == -1 && salaryTo == -1 && string.IsNullOrEmpty(searchText)) 
            {
                sqlCommand.CommandText = "SELECT * FROM Employee"; 
            }
            else
            {
                string commandText = "SELECT * FROM Employee WHERE ";
                if (!string.IsNullOrEmpty(searchText))
                {
                    commandText = commandText + "Name LIKE @SearchText " +
                                                "OR Surname LIKE @SearchText AND ";
                    sqlCommand.Parameters.AddWithValue("SearchText", "%" + searchText + "%"); 
                }

                if (salaryFrom != -1)
                {
                    commandText = commandText + "Salary > @SalaryFrom AND ";
                    sqlCommand.Parameters.AddWithValue("SalaryFrom", salaryFrom); 
                }

                if (salaryTo != -1)
                {
                    commandText = commandText + "Salary < @SalaryTo AND ";
                    sqlCommand.Parameters.AddWithValue("SalaryTo", salaryTo); 
                }

                sqlCommand.CommandText = commandText.Substring(0, commandText.Length - 4);
            }

            SqlDataReader reader = sqlCommand.ExecuteReader();
            DataTable employeeDT = new DataTable();
            employeeDT.Load(reader);
            return employeeDT;
        }
    }
}
