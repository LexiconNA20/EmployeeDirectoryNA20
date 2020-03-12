using System;

namespace EmployeeDirectoryNA20
{
    class Program
    {
        static void Main(string[] args)
        {
            Payroll payroll = new Payroll();
            AddSeedData(payroll);

            Console.WriteLine("Enter a new employee, Quit with Q");

            do
            {
                string name = Util.AskForString("Name: ");
                if (name == "Q") break;
                int salary = Util.AskForInt("Salary: ");
                payroll.Add(name, salary);

            } while (true);

            Employee[] employees = payroll.GetEmployees();

            Console.WriteLine(employees[0].Name);
            employees[0] = null;

            Employee[] emp2 = payroll.GetEmployees();
            Console.WriteLine(emp2[0].Name);

            foreach (var employee in employees)
            {
               // Console.WriteLine($"Name: {employee.Name} Salary: {employee.Salary}");
                Console.WriteLine(employee);

                string fname = employee?.Name;

                //if(employee.Salary > 15000)
                //{
                //    Console.WriteLine(DoSeniorWork());
                //}
                //else
                //{
                //    Console.WriteLine(DoJuniorWork());
                //} 
                if(employee == null)
                {
                    //Bla bla ha
                }

                //string value = null;

                //value = value != null ? value : "no value";
                //value = value ?? "no value";

               
                
                if(employee.SalaryLevel.Equals(SalaryLevel.Senior))
                {
                    Console.WriteLine(DoSeniorWork());
                }
                if(employee.SalaryLevel.Equals(SalaryLevel.Junior))
                {
                    Console.WriteLine(DoJuniorWork());
                }

                switch (employee.SalaryLevel)
                {
                    case SalaryLevel.Junior:
                        Console.WriteLine(DoJuniorWork());
                        break;
                    case SalaryLevel.Senior:
                        Console.WriteLine(DoSeniorWork());
                        break;
                }

                Console.WriteLine(
                    employee.SalaryLevel.Equals(SalaryLevel.Junior) ?
                    DoJuniorWork() :
                    DoSeniorWork());


                    
            }


            //Employee Kalle = new Employee("Kalle", 100);
            //Employee Lisa = new Employee("Lisa", 200);

            //string name = Kalle.Name;
            //Kalle.Name = "Nisse";
            //string jobb = Kalle.Work(2);

            Employee person = new Employee() { Name = "Kalle", Salary = 2000 };


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
