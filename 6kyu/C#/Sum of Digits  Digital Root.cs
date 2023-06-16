public class Number
{
  public int DigitalRoot(long n)
  {
   while (n / 10 != 0)
            {
                uint sum = 0;
                int i = 10;
                int j = 1;

                while (n / j >= 1)
                {
                    sum += (uint)(n % i / j);

                    i *= 10;
                    j *= 10;
                }

                n = sum;
            }

            return (int)n;
        }
  
}