using System;

namespace OCP
{
    class Program
    {
        static void Main(string[] args)
        {
            IEmployee employeeJohn = new PermenantEmployee(1,"John");
            IEmployee employeeJason = new TemporaryEmployee(2,"Js");
            Console.WriteLine($"{employeeJohn.Name} = Salary = {employeeJohn.CalculateBonus(12)}\n");
            Console.WriteLine($"{employeeJason.Name} = Salary = {employeeJason.CalculateBonus(12)}\n");
        }
    }
}
