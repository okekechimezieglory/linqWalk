using System;
using System.Collections.Generic;
using System.Linq;

namespace LinqWalkthrough
{
    class Program
    {
        static void Main(string[] args)
        {

            var dataSourceInt = new List<int>() { 5, 12, 13, 1, 7, 53, 304, 15, 100, 9, 2 };

            var dataSourceString = new List<string>()
            {
                "Smith",
                "Mitchel",
                "Collins",
                "Johnson",
                "Abel", 
                "Evans",
                "Thomas"
            };

            var dataSourceObject = new List<Employee>()
            {
                new Employee()
                {
                     Id = 3,
                Name = "John",
                Email = "john@gmail.com"
                },

            new Employee(){
                Id = 2,
                Name = "Peter",
                Email = "peter@gmail.com"
            },

            new Employee(){
                Id = 1,
                Name = "Paul",
                Email = "paul@gmail.com"
            } };

            var querySyntax = (from num in dataSourceInt
                               orderby num descending
                               select num).ToList();

            var methodSyntax = dataSourceInt.OrderByDescending(num => num).ToList();

            // for the string datasource

            var querySyntaxStr = (from name in dataSourceString
                                  orderby name descending
                                  select name).ToList();

            var methodSyntaxStr = dataSourceString.OrderByDescending(name => name).Where(name => name.Length > 4).ToList();

            // for the object

            var querySyntaxObj = (from emp in dataSourceObject
                              orderby emp.Id descending
                              select emp).ToList();

            var methodSyntaxObj = dataSourceObject.OrderByDescending(emp => emp.Id).ToList();

            foreach (var item in querySyntax)
            {
                Console.WriteLine(item);
            }

            Console.ReadLine();
        }
    }
}
