using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlFlowDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(CalculateControlDigit(21342182));

            Console.Write("Press any key to exit");
            Console.ReadKey();
        }

        static int CalculateControlDigit(long number)
        {
            int sum = 0;
            int factor = 1;

            do
            {
                int digit = (int)(number % 10);

                sum += factor * digit;
                factor = 4 - factor;

                number /= 10;
            }
            while (number > 0);

            int result = sum % 11;
            if (result == 10)
            {
                result = 1;
            }

            return result;
        }
    }
}
