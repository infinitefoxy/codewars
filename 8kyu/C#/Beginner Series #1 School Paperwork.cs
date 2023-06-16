using System;
  public static class Paper
  {
    public static int Paperwork(int n, int m)
    {
      
     if (n < 0) n = 0;
     if (m < 0) m = 0;

      return n*m;
    }
  }