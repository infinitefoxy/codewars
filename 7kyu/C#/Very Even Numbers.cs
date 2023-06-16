public class Kata
{
  public static bool IsVeryEvenNumber(int number)
  {
      return (--number % 9 + 1) % 2 == 0;
  }
}