using System;

namespace EmployeeDirectoryNA20
{
    public class Employee
    {
        public Employee()
        {

        }
       // public string Name;
        public int Salary;
        public string Name { get; set; }

        public SalaryLevel SalaryLevel 
        {
            get
            {
                if(Salary < 15000)
                {
                    return SalaryLevel.Junior;
                }
                else
                {
                    return SalaryLevel.Senior;
                }
            }
        }

        //public string Work(int houers)
        //{
        //    return "Working";
        //}

        //private string name;

        //public string Name
        //{
        //    get { return name; }
        //    set { name = value; }
        //}

        //public void SetName(string name)
        //{
        //    this.name = name;
        //}

        //public string GetName()
        //{
        //    return name;
        //}


        //public Employee()
        //{

        //}
        public Employee(string name, int salary)
        {
            Name = name;
            Salary = salary;
        }

        public override string ToString()
        {
            return $"Name: {Name} Salary: {Salary}";
        }
    }
}