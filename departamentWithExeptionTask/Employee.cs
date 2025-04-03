using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace departamentWithExeptionTask
{
    class Employee : IPerson
    {
        static int _id;
        public int Id { get; }
        public string Name { get; set; }
        public byte Age { get; set; }
        public double Salary { get; set; }

        public Employee(string name, byte age, double salary)
        {
            _id++;
            Id = _id;
            Salary = salary;
            Name = name;
            Age = age;
        }
        public string ShowInfo()
        {
            return $"idsi {Id}, adi {Name}, yasi {Age}, maasi {Salary}";
        }
        public override string ToString()
        {
            return "Anar";
        }
    }
}
