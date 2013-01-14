using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary1;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {

            var rules = getRules();


//            for (int i = 1; i < 100; i++)
//            {
//                Console.Out.WriteLine(FizzBuzz.GetResult(i, rules));
//            }

			FizzBuzz.Run(1, 1000000000, rules, (result) => Console.Out.WriteLine (result));
        }

        private static Dictionary<int, string> getRules()
        {
            var rules = new Dictionary<int, string>();
            rules.Add(3, "Fizz");
            rules.Add(5, "Buzz");
            rules.Add(15, "FizzBuzz");
            return rules;
        }
    }
}
