using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class FizzBuzz
    {

        public static string GetResult(int number, Dictionary<int, string> divisorRules)
        {
            if (divisorRules == null) throw new ArgumentException("You have no rules. Must be nice...");

            foreach (var rule in divisorRules.OrderByDescending(x => x.Key))
            {
                if (number % rule.Key == 0)
                    return rule.Value;
            }

            return number.ToString();
        }

    }
}
