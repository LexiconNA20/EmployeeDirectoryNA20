using System;

namespace EmployeeDirectoryNA20
{
    //Entry point of application
    class Program
    {
        static void Main(string[] args)
        {
            //Create a new instance of payroll
            Payroll payroll = new Payroll();

            //Calls Add method on payroll instance with parameters
            //Only for demo purpose to have some data
            AddSeedData(payroll);

            Console.WriteLine("Enter a new employee, Quit with Q");

            //loop until we press Q
            do
            {
                string name = Util.AskForString("Name: ");
                if (name == "Q") break;       //Break exits the loop
                int salary = Util.AskForInt("Salary: ");
                payroll.Add(name, salary);

            } while (true); //Endleess loop

            Employee[] employees = payroll.GetEmployees();

            //loop on all employees in payroll
            foreach (var employee in employees)
            {
                // Console.WriteLine($"Name: {employee.Name} Salary: {employee.Salary}");
                // string fname = employee?.Name;

                //Console.Writeline() method does a .ToString() on the Employee instance
                Console.WriteLine(employee);

                //string value = null;

                //value = value != null ? value : "no value";
                //value = value ?? "no value";


                //Three different ways...
                //1.
                if (employee.SalaryLevel.Equals(SalaryLevel.Senior))
                {
                    Console.WriteLine(DoSeniorWork());
                }
                if (employee.SalaryLevel.Equals(SalaryLevel.Junior))
                {
                    Console.WriteLine(DoJuniorWork());
                }

                //2.
                switch (employee.SalaryLevel)
                {
                    case SalaryLevel.Junior:
                        Console.WriteLine(DoJuniorWork());
                        break;
                    case SalaryLevel.Senior:
                        Console.WriteLine(DoSeniorWork());
                        break;
                }

                //3.
                Console.WriteLine(
                    employee.SalaryLevel.Equals(SalaryLevel.Junior) ?
                    DoJuniorWork() :
                    DoSeniorWork());

            }

            //Objekt instansierare
            // Employee person = new Employee() { Name = "Kalle", Salary = 2000 };

        }

        private static string DoJuniorWork()
        {
            return "Do junior work";
        }

        private static string DoSeniorWork()
        {
            return "Do senior work";
        }

        private static void AddSeedData(Payroll payroll)
        {
            payroll.Add("Kalle", 10000);
            payroll.Add("Nisse", 20000);
            payroll.Add("Anna", 25000);
            payroll.Add("Lisa", 14000);
        }
    }
}
