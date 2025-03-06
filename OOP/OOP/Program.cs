using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    class Program
    {
        static void Main(string[] args)
        {
            //update lần 3
            Console.WriteLine("Nguyen Phuoc Ky - 22115053122224");
            Employee employee1 = new PartTimeEmployee(45000, "Ky", 7);
            Console.WriteLine($"Name: {employee1.GetName()}");
            Console.WriteLine($"Salary per day: {employee1.CalculateSalary()}");

            Employee employee2 = new FullTimeImployee("Linh", 65000);
            Console.WriteLine($"Name: {employee2.GetName()}");
            Console.WriteLine($"Salary per day: {employee2.CalculateSalary()}");

            Console.ReadKey();
        }
    }
}
