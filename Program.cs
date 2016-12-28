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
            int pos = 1;

            do
            {
                int digit = (int)(number % 10);

                if (pos % 2 == 0)
                {
                    sum += 3 * digit;
                }
                else
                {
                    sum += digit;
                }

                number /= 10;
                pos++;
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
