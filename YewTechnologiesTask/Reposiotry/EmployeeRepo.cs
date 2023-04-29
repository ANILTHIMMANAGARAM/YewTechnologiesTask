using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using YewTechnologiesTask.Irepository;
using YewTechnologiesTask.Models;

namespace YewTechnologiesTask.Reposiotry
{
    public class EmployeeRepo : IEmployeeRepo
    {
        SqlConnection connection = new SqlConnection("Server=DESKTOP-Q6JK9C0\\SQLEXPRESS02;Database=YewtechnologyTask;Trusted_Connection=true");

        public bool DeleteEmployeeData(int id)
        {
            SqlCommand command = new SqlCommand("DeleteEmployeeData", connection);
            command.Parameters.AddWithValue("Id", id);
            connection.Open();
            command.CommandType = System.Data.CommandType.StoredProcedure;
            command.ExecuteNonQuery();
            connection.Close();
            return true;
        }

        public Employee GetemployeeDAtaById(int id)
        {
            Employee employee = new Employee();

            SqlCommand command = new SqlCommand("GetEmployeeDataById", connection);

            command.Parameters.AddWithValue("Id", id);
            connection.Open();
            command.CommandType = System.Data.CommandType.StoredProcedure;
            SqlDataReader sqlData = command.ExecuteReader();
            while (sqlData.Read())
            {

                employee.EmpId= Convert.ToInt32(sqlData["EmpId"]);
                employee.LastName = Convert.ToString(sqlData["LastName"]);
                employee.FirstName = Convert.ToString(sqlData["FirstName"]);
                employee.DOB= Convert.ToDateTime(sqlData["DOB"]);
                employee.Email= Convert.ToString(sqlData["Email"]);
                employee.Mobile = Convert.ToInt64(sqlData["Mobile"]);

                employee.Department= Convert.ToString(sqlData["Department"]);
                employee.Designation= Convert.ToString(sqlData["Designation"]);
                employee.Salary = Convert.ToInt64(sqlData["Salary"]);

            }
            sqlData.Close();
            connection.Close();
            return employee;
        }

        public List<Employee> GetEmployeeDetiles()
        {
            SqlCommand command = new SqlCommand("GetEmployeeData", connection);
            List<Employee> employeeslist = new List<Employee>();
            connection.Open();
            command.CommandType = System.Data.CommandType.StoredProcedure;
            SqlDataReader sqlData = command.ExecuteReader();
            while (sqlData.Read())
            {
                Employee employee = new Employee();

                employee.EmpId = Convert.ToInt32(sqlData["EmpId"]);
                employee.LastName = Convert.ToString(sqlData["LastName"]);
                employee.FirstName = Convert.ToString(sqlData["FirstName"]);
                employee.DOB = Convert.ToDateTime(sqlData["DOB"]);
                employee.Email = Convert.ToString(sqlData["Email"]);
                employee.Mobile = Convert.ToInt64(sqlData["Mobile"]);

                employee.Department = Convert.ToString(sqlData["Department"]);
                employee.Designation = Convert.ToString(sqlData["Designation"]);
                employee.Salary = Convert.ToInt64(sqlData["Salary"]);
                employeeslist.Add(employee);

            }
            sqlData.Close();
            connection.Close();
            return employeeslist;
        }

        public bool InsertemployeeData(Employee employee)
        {
            SqlCommand command = new SqlCommand("InsertEmployeeData", connection);
            command.Parameters.AddWithValue("LastName", employee.LastName);

            command.Parameters.AddWithValue("FirstName", employee.FirstName);

            command.Parameters.AddWithValue("DOB", employee.DOB);
            command.Parameters.AddWithValue("Email", employee.Email);
            command.Parameters.AddWithValue("Mobile", employee.Mobile);
            command.Parameters.AddWithValue("Department", employee.Department);
            command.Parameters.AddWithValue("Designation", employee.Designation);
            command.Parameters.AddWithValue("Salary", employee.Salary);

            connection.Open();
            command.CommandType = System.Data.CommandType.StoredProcedure;
            command.ExecuteNonQuery();
            connection.Close();
            return true;
        }

        public bool UpdateEmployeeData(Employee employee)
        {
            SqlCommand command = new SqlCommand("UpdateEmployeeData", connection);
            command.Parameters.AddWithValue("EmpId", employee.EmpId);

            command.Parameters.AddWithValue("LastName", employee.LastName);

            command.Parameters.AddWithValue("FirstName", employee.FirstName);

            command.Parameters.AddWithValue("DOB", employee.DOB);
            command.Parameters.AddWithValue("Email", employee.Email);
            command.Parameters.AddWithValue("Mobile", employee.Mobile);
            command.Parameters.AddWithValue("Department", employee.Department);
            command.Parameters.AddWithValue("Designation", employee.Designation);
            command.Parameters.AddWithValue("Salary", employee.Salary);

            connection.Open();
            command.CommandType = System.Data.CommandType.StoredProcedure;
            command.ExecuteNonQuery();
            connection.Close();
            return true;
        }
    }
}
