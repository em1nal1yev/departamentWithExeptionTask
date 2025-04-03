namespace departamentWithExeptionTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee emp = new Employee("Emin", 20, 3);
            string a = emp.ShowInfo();
            Console.WriteLine(a);
            Employee emp2 = new Employee("Eminn", 22, 2);
            string b = emp2.ShowInfo();
            Console.WriteLine(b);
            Department dep = new Department("IT", 3);
            dep.AddEmployee(emp);
            dep.AddEmployee(emp2);
        }
    }
}
