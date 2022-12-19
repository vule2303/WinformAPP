using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab7
{
    internal class Person
    {
        string Name;
        int Age;
        double Salary;

        public Person(string name = "", int age = 0 , double salary = 0)
        {
            Name = name;
            Age = age;
            Salary = salary;
        }
        public string name { get => Name; set => Name = value; }
        public int age { get => Age; set => Age = value; }
        public double salary { get => Salary; set => Salary = value; }
    }
}
