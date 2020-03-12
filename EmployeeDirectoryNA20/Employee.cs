using System;

namespace EmployeeDirectoryNA20
{
    public class Employee
    {

        //public string Name;

        //Publikt fält ( Use property! )
        public int Salary;

        //Property
        //prop shortcut
        public string Name { get; set; }

        //Property only get
        public SalaryLevel SalaryLevel
        {
            get
            {
                if (Salary < 15000)
                {
                    return SalaryLevel.Junior;
                }
                else
                {
                    return SalaryLevel.Senior;
                }
            }
        }

        //Same as above
        // public SalaryLevel SalaryLevel => Salary < 15000 ? 
        //SalaryLevel.Junior : 
        //SalaryLevel.Senior;

        //propfull shortcut
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

        //Default constructor
        //public Employee()
        //{

        //}

        //Constructor requires name and salary, removes the empty constructor
        //ctor shortcut
        public Employee(string name, int salary)
        {
            Name = name;
            Salary = salary;
        }

        //This method runs when you call ToString() on a employee instance
        public override string ToString()
        {
            return $"Name: {Name} Salary: {Salary}";
        }
    }
}