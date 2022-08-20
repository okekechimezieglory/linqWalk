using System;
using System.Collections.Generic;
using System.Linq;

namespace LinqWalkthrough
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> strList = new List<string>() { "Okeke", "Chimezie", "Glory", "OghneKaro", "Chimex"};

            var methodResult = strList.SelectMany(str => str).ToList();

            // query syntax implementation
            var queryResult = (from record in strList
                               from character in record
                               select character).ToList();  // there is no SelectMany implementation for the query syntax, 
            //now, what I did is to do a kind of nesting, i.e record is a string in strList which is a list and character
            // is a char in character that is a string

            Console.ReadLine();
        }
    }
}
