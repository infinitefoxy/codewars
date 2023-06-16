using System;
using System.Linq;

public static class Kata
{
    public static int GetVowelCount(string str)
    {
        int vowelCount = 0;

        for (int i = 0; i < str.Length; i++)
          {
          if ( str[i].Equals('a') || str[i].Equals('e') || str[i].Equals('i')
              || str[i].Equals('o') || str[i].Equals('u') )
            {
              vowelCount++;
              
            }
          
        }

        return vowelCount;
    }
}