using System.Collections.Generic;

namespace ControlFlowDemo
{
    static internal class Int64Utils
    {
        public static IEnumerable<int> GetDigitsFromLeastSignificant(this long number)
        {
            do
            {
                yield return (int)(number % 10);
                number /= 10;
            }
            while (number > 0);
        }
    }
}
