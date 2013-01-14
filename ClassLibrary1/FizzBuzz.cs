using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

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

		public static void Run (int start, int end, Dictionary<int, string> divisorRules, Action<string> callback)
		{
			if (start > end) {
				throw new ArgumentException("Starting number must be less than or equal to the ending number.");
			}

			for (int i = start; i < end; i++) {
				foreach (var rule in divisorRules) {
					if (i % rule.Key == 0) {
						callback(String.Intern(rule.Value));
						continue;
					}
				}

				callback(i.ToString ());
			}
		}
    }
}
