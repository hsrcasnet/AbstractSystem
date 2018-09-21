using System;
using System.Linq;
using AbstractSystem.Data;

namespace AbstractSystem
{
    public class BusinessManager
    {
        private readonly EmployeeRepository employeeRepository;

        public BusinessManager()
        {
            this.employeeRepository = new EmployeeRepository();
        }

        public decimal GetSalaryPaidYtd()
        {
            var employees = this.employeeRepository.GetAllEmployees();

            var salarySum = employees
                .Where(e => e.IsRetired == false)
                .Sum(e => CalculateSalaryYtd(e.MonthlySalary));

            return salarySum;
        }

        private static decimal CalculateSalaryYtd(decimal monthlySalary)
        {
            var monthOfYear = DateTime.Now.Month;
            var salaryYtd = monthlySalary * monthOfYear;
            return salaryYtd;
        }
    }
}
