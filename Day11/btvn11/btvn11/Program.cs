using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YieldKeywordApp
{
    class Program
    {
        static void Main(string[] args)
        {
            foreach (var item in PerformMathOperations(3, 2))
            {
                Console.WriteLine(item);
            }

        }

        public static IEnumerable<double> PerformMathOperations(int numberOne, int numberTwo)
        {
            yield return numberOne + numberTwo;
            yield return numberOne * numberTwo;
            yield return numberOne - numberTwo;
            yield return Math.Round(((double)numberOne / (double)numberTwo), 2);
        }
    }
}
