using System;
using System.Collections.Generic;
using System.Linq;

namespace LinqWalkthrough
{
    class Program
    {
        static void Main(string[] args)
        {

            var dataSource = new List<Object>() { "Harry", "Khris", "Urchkid", 1, 2, 3, 4, 5};

            var methodSyntax = dataSource.OfType<string>().ToList();
            var methodSyntax2 = dataSource.OfType<string>().Where(x => x.Length == 5).ToList();

            var querySyntax = (from x in dataSource
                               where x is int
                               select x).ToList();

            Console.ReadLine();
        }
    }
}
