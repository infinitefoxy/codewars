using System.Collections.Generic;
using System.Linq;

namespace SumSumTask
{
  using System;
  using System.Collections.Generic;
  
  public class TwoSum
  {
    public int SumOfTwoSumTargets(int[] numbers, int from, int to)
        {
            var set = new HashSet<int>();

            for (var i = 0; i < numbers.Length; i++)
            {
                for (var j = i + 1; j < numbers.Length; j++)
                {
                    var s = numbers[i] + numbers[j];
                    if (s >= from && s < to) set.Add(s);
                }
            }

            return set.Sum();
    }
  }
}