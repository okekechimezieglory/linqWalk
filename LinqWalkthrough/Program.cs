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
                new Employee() {Id=1, Name="John"},
                new Employee() {Id=2, Name="Bisi"}
            };

            IEnumerable<Employee> query = from emp in employees
                                          where emp.Id == 1
                                          select emp;

            // IQuerable implementation
            IQueryable<Employee> query1 = employees.AsQueryable().Where(x => x.Id == 1);

            foreach (var q in query1)
            {
                Console.WriteLine("Id = " + q.Id + " and name = " + q.Name);
            }
            //IEnumerable<int> querySyntax = from obj in list 
            //                               where obj > 2 
            //                               select obj;
            Console.WriteLine("Hello World!");
            //Console.WriteLine(querySyntax);
        }

        class Employee
        {
            public int Id { get; set; }
            public string Name { get; set; }
        }
    }
}
