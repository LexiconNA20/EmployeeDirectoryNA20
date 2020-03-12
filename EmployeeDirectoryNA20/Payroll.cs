using System.Collections.Generic;

namespace EmployeeDirectoryNA20
{
    public class Payroll
    {
        //Private collection of employee objects
        //Only accessable from inside this class
        private List<Employee> employees;

        //Construktor runs when a payroll is created ( new Payroll() )
        public Payroll()
        {
            //Initializes a new List
            employees = new List<Employee>();
           // {
           //     new Employee("nisse", 4000),
           //     new Employee(){ Name= "pelle" },
           // };
           //var arr = new[] { 1.0M , 2, 3, 4, 5 };
        }

        public void Add(string name, int salary)
        {
            //New instance of employee
            //Add emplyee to list
            employees.Add(new Employee(name, salary));
        }
        
        public Employee[] GetEmployees()
        {
            //Returns a copy of emplyee list
            return employees.ToArray();
        }
    }
}