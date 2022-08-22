using System;
using System.Collections.Generic;
using System.Linq;

namespace LinqWalkthrough
{
    class Program
    {
        static void Main(string[] args)
        {

            var dataSourceInt = new List<int>() { 1, 22, 3, 304, 15, 9, 2 };

            var dataSourceString = new List<string>()
            {
                "Adam",
                "Igbudu",
                "Kunle",
                "Oladokun",
                "Okonkwo"
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
                               where num > 9 // use the where condition before applying your orderBy if needed as so
                              orderby num
                               select num).ToList();

            var methodSyntax = dataSourceInt.OrderBy(num => num).ToList();

            // for string
            var querySyntaxStr = (from name in dataSourceString
                                  orderby name
                                  select name).ToList();

            var methodSyntaxStr = dataSourceString.Where(name => name.Length > 6).OrderBy(name => name).ToList();

            // for the objects
            var querySyntaxObj = (from emp in dataSourceObject
                                  where(emp.Id > 1)
                                  orderby emp.Id
                                  select emp).ToList();
            // condition can be done on the varying properties as well as ordering done on the varying properties also depending on what you want both for the query and method syntax

            var methodSyntaxObj = dataSourceObject.OrderBy(emp => emp.Id).ToList();

            foreach (var item in querySyntax)
            {
                Console.WriteLine(item);
            }

            Console.ReadLine();
        }
    }
}
