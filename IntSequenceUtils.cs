using System.Collections.Generic;
using System.Linq;

namespace ControlFlowDemo
{
    static internal class IntSequenceUtils
    {
        public static IEnumerable<int> AddWeights(this IEnumerable<int> values, IEnumerable<int> factors)
        {
            return values.Zip(factors, (v, f) => v * f);
        }
    }
}
