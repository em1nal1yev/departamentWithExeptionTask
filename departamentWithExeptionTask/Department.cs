using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace departamentWithExeptionTask
{
    class Department
    {
        public Department(string name, int employeeLimit)
        {
            Name = name;
            EmployeeLimit = employeeLimit;
        }
        public Employee this[int index]
        {
            get { return employees[index]; }
            set { employees[index] = value; }
        }
        public string Name { get; set; }
        public int EmployeeLimit { get; set; }
        Employee[] employees = new Employee[0];
        public void AddEmployee(Employee emp)
        {
            try
            {
                Array.Resize(ref employees, employees.Length + 1);
                employees[^1] = emp;
            }
            catch (Exception e)
            {

                Console.WriteLine(e.Message);
            }
            
        }
    }
}
