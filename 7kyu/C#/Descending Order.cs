using System;
using System.Linq;
public static class Kata
{
  public static int DescendingOrder(int num)
  {
    // Bust a move right here
    
    
    
    return int.Parse(string.Concat(num.ToString().OrderByDescending(x => x)));
  }
}