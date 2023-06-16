using System;
using System.Linq;

public class Kata
{
  public static int[] ArrayDiff(int[] a, int[] b)
  {
    // Your brilliant solution goes here
    // It's possible to pass random tests in about a second ;)
    

return a.Where(_=>!b.Contains(_)).ToArray();
  
    
  }
}