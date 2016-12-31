using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlFlowDemo
{
    class Program
    {
        static int CalculateControlDigit(long number)
        {
            int sum =
                number
                .GetDigitsFromLeastSignificant()
                .AddWeights(MultiplicativeFactors)
                .Sum();

            int result = sum % 11;
            if (result == 10)
                result = 1;

            return result;
        }

        private static IEnumerable<int> MultiplicativeFactors
        {
            get
            {
                while (true)
                {
                    yield return 1;
                    yield return 3;
                }
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine(CalculateControlDigit(21342182));

            Console.Write("Press any key to exit");
            Console.ReadKey();
        }
    }
}
