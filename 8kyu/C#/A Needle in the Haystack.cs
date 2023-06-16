using System;
public class Kata
{
  public static string FindNeedle(object[] haystack)
  {
  //Code goes here!

    return string.Format("found the needle at position {0}", Array.IndexOf(haystack, "needle"));
  }
}