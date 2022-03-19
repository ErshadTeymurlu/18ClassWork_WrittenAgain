using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18MarchTaskClassroom.Models
{
    internal class Person
    {
        public string name;
        public string surname;
        public int age;
        public Person(string name, string surname, int age)
        {
            this.name = name;
            this.surname = surname;
            this.age = age;
            Console.WriteLine($"Name - {name}, Surname - {surname}, Age - {age}");

        }
    }
}
