using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace departamentWithExeptionTask
{
    class Employee : IPerson
    {
        int _id;
        public int Id { get; }
        public string Name { get; set; }
        public byte Age { get; set; }
        public double Salary { get; set; }

        public Employee()
        {
            _id++;
            Id = _id;
        }
        public Employee(string name, byte age, double salary)
        {
            Salary = salary;
            Name = name;
            Age = age;
            
        }
        string IPerson.ShowInfo()
        {
            return $"idsi {Id}, adi {Name}, yasi {Age}, maasi {Salary}";
        }
        public override string ToString()
        {
            return "Anar";
        }
    }
}
