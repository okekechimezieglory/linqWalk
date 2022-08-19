using System;
using System.Collections.Generic;
using System.Linq;

namespace LinqWalkthrough
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int>() { 1, 2, 3, 4, 5, 6 };

            List<Employee> employees = new List<Employee>()
            {
                new Employee() {Id=1, Name="John", Email= "john@gmail.com"},
                new Employee() {Id=2, Name="Bisi", Email= "bisi@gmail.com"},
                new Employee() {Id=3, Name="Mary", Email= "mary@gmail.com"},
                new Employee() {Id=4, Name="Gbenga", Email= "gbenga@gmail.com"}
            };

            var basicQuery = (from emp in employees
                             select emp).ToList();

            // basic method implementation

            var basicMethod = employees.ToList();

            // operations

            var basicPropQuery = (from emp in employees
                                  select emp.Id).ToList();

            var basicPropMethod = employees.Select(emp => emp.Id).ToList();

            //

            var selectQuery = (from emp in employees
                               select new Employee()
                               {
                                   Id = emp.Id,
                                   Email = emp.Email
                               }).ToList();

            foreach (var item in basicQuery)
            {
                Console.WriteLine($"Id = { item.Id}, Name= { item.Name}, Email is = + { item.Email}");
            }

            Console.ReadLine();
        }
    }
}
