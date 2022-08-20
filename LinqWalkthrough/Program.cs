using System;
using System.Collections.Generic;
using System.Linq;

namespace LinqWalkthrough
{
    class Program
    {
        static void Main(string[] args)
        {
            //List<string> strList = new List<string>() { "Okeke", "Chimezie", "Glory", "OgheneKaro", "Chimex"};

            //var methodResult = strList.SelectMany(str => str).ToList();

            //// query syntax implementation
            //var queryResult = (from record in strList
            //                   from character in record
            //                   select character).ToList();  // there is no SelectMany implementation for the query syntax, 
            //now, what I did is to do a kind of nesting, i.e record is a string in strList which is a list and character
            // is a char in character that is a string


            var dataSource = new List<Employee>()
            {
                new Employee(){Id=1, Name="Johnson", Email="johnson@gmail.com", Programming=new List<string> (){"C#", "Python", "Java"}},
                 new Employee(){Id=2, Name="Serena", Email="serena@gmail.com", Programming=new List<string> (){"C++", "Python", "Php"}},
                  new Employee(){Id=3, Name="Emeka", Email="emeka@gmail.com", Programming=new List<string> (){"C", "Swift", "Xamarin"}}
            };

            var methodSyntax = dataSource.SelectMany(emp => emp.Programming).ToList();

            foreach (var item in methodSyntax)
            {
                Console.WriteLine($"Programming = { item}");
            }


            // query syntax
            var querySyntax = (from emp in dataSource
                               from skills in emp.Programming
                               select skills).ToList();

            foreach (var item in querySyntax)
            {
                Console.WriteLine($"Programming = { item}");
            }

            Console.ReadLine();
        }
    }
}
