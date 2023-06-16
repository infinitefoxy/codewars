using System;

namespace Solution
{
  public class TwiceAsOldSolution
  {
    public static int TwiceAsOld(int dadYears, int sonYears)
    {
      // Add you code here.
      
      // const twiceAsOld = (dadYearsOld, sonYearsOld) => 
      //Math.abs((dadYearsOld - sonYearsOld) - sonYearsOld);
      
      return Math.Abs((dadYears-sonYears)-sonYears);
      
    }
  }
}