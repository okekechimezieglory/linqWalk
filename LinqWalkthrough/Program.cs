using System;
using System.Collections.Generic;
using System.Linq;

namespace LinqWalkthrough
{
    class Program
    {
        static void Main(string[] args)
        {
            var dataSource =  new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            var dataSourceString = new List<string>() { "Harry", "Khris", "Urchkid", "Chimex", "Uche", "Emeka", "Ebuka", "Ebube", "Happy", "Rachael" };

            var querySyntax = (from numb in dataSource
                         where numb <= 4 || numb > 9   
                         select numb).ToList();
            //  you can change the operators to your prefered choice based on what you want as output, i.e using <, >, <=, >=, ||, &&, etc

            var methodSyntax = dataSource.Where(number => number > 5).ToList();

            var querySyntaxStr = (from nameStr in dataSourceString
                                 where nameStr.Length == 5
                                 select nameStr).ToList();

            var methodSyntaxStr = dataSourceString.Where(strN => strN.Length > 5).ToList();

            //foreach (var item in querySyntax)
            //{
            //    Console.WriteLine(item);
            //}

            var dataSourceComplex = new List<Employee>()
            {
                new Employee() {Id = 1, Name="chimex", Email = "chimex@gmail.com", Programming=

                new List<Techs>
                {
                    new Techs() {Technology = "C#"},
                    new Techs() {Technology = "VB"},
                    new Techs() {Technology = "C++"},
                    new Techs() {Technology = "SQL"}
                }},
                new Employee() {Id = 2, Name="Glory", Email = "glory@gmail.com", Programming=

                new List<Techs>
                {
                    new Techs() {Technology = "PHP"},
                    new Techs() {Technology = "LARAVEL"},
                    new Techs() {Technology = "JAVA"},
                    new Techs() {Technology = "RUBY"}
                }},

                new Employee() {Id = 3, Name="karo", Email = "karo@gmail.com", Programming=

                new List<Techs>
                {
                    new Techs() {Technology = "FORTRAN"},
                    new Techs() {Technology = "NODEJS"},
                    new Techs() {Technology = "PYTHON"},
                    new Techs() {Technology = "XAMARIN"}
                }},
                new Employee() {Id = 4, Name = "Calistus", Email = "calistus@gmail.com", Programming= new List<Techs>()},
                new Employee() {Id = 4, Name = "Neymar", Email = "neymar@gmail.com", Programming= new List<Techs>()},
            };

            var querySyntaxComplex = (from emp in dataSourceComplex
                                      where emp.Programming.Count == 0
                                      select emp).ToList();

            var methodSyntaxComplex = dataSourceComplex.Where(emp => emp.Programming.Count == 0).ToList();

            Console.ReadLine();
        }
    }
}
