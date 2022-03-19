using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _18MarchTaskClassroom.Models;

namespace _18MarchTaskClassroom
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double salaryPerHour = 0;
            int workingHour = 0;
            Console.Write("Name: ");
            string name = Console.ReadLine();
            Console.Write("Surname: ");
            string surname = Console.ReadLine();
            Console.Write("Age: ");
            int age = Convert.ToInt32(Console.ReadLine());
            if (age >= 18 && age > 0) 
            {
               Console.Write("Amount of the money given per hour: ");
               salaryPerHour = Convert.ToDouble(Console.ReadLine());
               Console.Write("Total work hours in a month: ");
               workingHour = Convert.ToInt32(Console.ReadLine());
            }
            Worker wk1 = new Worker(name,surname,age,salaryPerHour, workingHour);
            if (age >= 18 && age > 0)  Console.Write("Total Salary In A Month: " + wk1.CalculateSalary() + " AZN");
            else if (age < 18 && age > 0)  Console.Write("In order to work you should be older than 18.");
            Console.ReadLine();
        }
    }
}
