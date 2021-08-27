using Dapper;
using FormsUpload.DTO;
using FormsUpload.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;

namespace FormsUpload.Repository
{
    public class EmployeeRepository
    {
        private string DatabaseConnection => 
            ConfigurationManager.ConnectionStrings["DataContextUpload"].ConnectionString;

        public IEnumerable<EmployeeDto> GetAllEmployees()
        {
            using(var connection = new SqlConnection(DatabaseConnection))
            {
                return connection.Query<EmployeeDto>("usp_EmployeeList");
            }
        }

        public void SaveEmployee(Employee employee)
        {
            throw new NotImplementedException();
        }

        public void RemoveEmployee(int employeeId)
        {
            using(var connection = new SqlConnection(DatabaseConnection))
            {
                connection.Execute("usp_RemoveEmployee", new { employeeId = employeeId });
            }
        }
    }
}
