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
            IEnumerable<int> digits = GetDigitsFromLeastSignificant(number);
            IEnumerable<int> factors = GetMultiplicativeFactors();
            IEnumerable<int> weightedDigits = AddWeight(digits, factors);

            int sum = Sum(weightedDigits);

            int result = sum % 11;
            if (result == 10)
                result = 1;

            return result;
        }

        private static int Sum(IEnumerable<int> values)
        {
            int sum = 0;

            foreach (int value in values)
            {
                sum += value;
            }

            return sum;
        }

        private static IEnumerable<int> AddWeight(IEnumerable<int> values, IEnumerable<int> factors)
        {
            IEnumerator<int> factor = factors.GetEnumerator();

            List<int> weightedDigits = new List<int>();

            foreach (int value in values)
            {
                factor.MoveNext();
                weightedDigits.Add(factor.Current * value);
            }

            return weightedDigits;
        }

        private static IEnumerable<int> GetMultiplicativeFactors()
        {
            return new int[] { 1, 3, 1, 3, 1, 3, 1, 3, 1, 3, 1, 3, 1, 3, 1, 3, 1, 3 };
        }

        private static IEnumerable<int> GetDigitsFromLeastSignificant(long number)
        {
            List<int> digits = new List<int>();

            do
            {
                int digit = (int)(number % 10);
                digits.Add(digit);
                number /= 10;
            }
            while (number > 0);

            return digits;
        }

        static void Main(string[] args)
        {
            Console.WriteLine(CalculateControlDigit(21342182));

            Console.Write("Press any key to exit");
            Console.ReadKey();
        }
    }
}
