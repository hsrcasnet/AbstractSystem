using System.Collections.Generic;
using System.IO;
using AbstractSystem.Model;
using Newtonsoft.Json;

namespace AbstractSystem.Data
{
    public class EmployeeRepository
    {
        private static readonly string path = @".\Employees.json";

        public EmployeeRepository()
        {
        }

        public IEnumerable<Employee> GetAllEmployees()
        {
            var json = File.ReadAllText(path);
            var employees = JsonConvert.DeserializeObject<IEnumerable<Employee>>(json);
            return employees;
        }

        //private static void Save(IEnumerable<Employee> employees)
        //{
        //    var json = JsonConvert.SerializeObject(employees);
        //    File.WriteAllText(path, json);
        //}
    }
}