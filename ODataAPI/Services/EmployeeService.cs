using System.Collections.Generic;
using System.Linq;
using ODataAPI.Models;

namespace ODataAPI.Services
{
    public class EmployeeService
    {
        public List<Employee> CreateData()
        {
            List<Employee> employees = new();

            employees.Add(new Employee 
            { 
                Id = 1, 
                Name = "Jay", 
                Role = "Developer", 
                City = "Los Angeles", 
                Pincode = 12 
            });
            employees.Add(new Employee 
            { 
                Id = 2, 
                Name = "Cinthya", 
                Role = "Developer", 
                City = "New York", 
                Pincode = 11 
            });
            employees.Add(new Employee 
            { 
                Id = 3, 
                Name = "Luis", 
                Role = "Developer", 
                City = "Las Vegas", 
                Pincode = 10 
            });
            employees.Add(new Employee 
            { 
                Id = 4, 
                Name = "Sonya", 
                Role = "Quality Assurance", 
                City = "Toronto", 
                Pincode = 122 
            });
            employees.Add(new Employee 
            { 
                Id = 5, 
                Name = "Joe", 
                Role = "Montblack", 
                City = "Tampa Bay", 
                Pincode = 1232 
            });

            return employees;
        }

        public List<Employee> GetEmployees() => CreateData().ToList();
    }
}