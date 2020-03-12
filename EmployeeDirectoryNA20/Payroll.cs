using System.Collections.Generic;

namespace EmployeeDirectoryNA20
{
    public class Payroll
    {
        private List<Employee> employees;
        public Payroll()
        {
            employees = new List<Employee>();
           // {
           //     new Employee("nisse", 4000),
           //     new Employee(){ Name= "pelle" },
           // };
           //var arr = new[] { 1.0M , 2, 3, 4, 5 };
        }

        public void Add(string name, int salary)
        {
            employees.Add(new Employee(name, salary));
        }
        
        public Employee[] GetEmployees()
        {
            return employees.ToArray();
        }
    }
}