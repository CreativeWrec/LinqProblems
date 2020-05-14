using System;
using System.Collections.Generic;
using System.Linq;

namespace LINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            //List<string> words = new List<string>() { "the", "bike", "this", "it", "tenth", "mathematics" };

            //linq query syntax
            //var results = words.Where(w => w.Contains("th"));
            //foreach (var word in results)
            //{
            //    Console.WriteLine(results);
            //}

            //List<string> names = new List<string>() { "mike", "brad", "nevin", "zack", "mike" };

            //foreach (var name in names)
            //{
            //    console.writeline(name);
            //}

            //List<string> distinct = names.distinct().tolist();

            //foreach (var name in distinct)
            //{
            //    Console.WriteLine(name);
            //}

            var classGrades = new List<string>()
            {
                "80,100,92,89,65",
                "93,81,78,84,69",
                "73,88,83,99,64",
                "98,100,66,74,55"

            };

            var average = classGrades.Average();
        }
    }
}
