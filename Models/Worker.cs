using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18MarchTaskClassroom.Models
{
    internal class Worker : Person
    {
        public double salaryPerHour;
        public int workingHour;
        public Worker(string name, string surname, int age, double salary, int hour) : base(name, surname, age)
        {
            if (hour <= 240 && hour > 0)
            {
                workingHour = hour;
                salaryPerHour = salary;
            }
        }
        public double CalculateSalary()
        {
            if ((salaryPerHour * workingHour) >= 250 && age>=18)
            {
                return (double)(salaryPerHour * workingHour);
            }
            return 0;
        }
    }
}
