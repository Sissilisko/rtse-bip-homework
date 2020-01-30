using System;

namespace exercise_52
{
  class Program
  {
    public static void Main(String[] args)
    {
      // Call your method here:
      PrintFromNumberToOne(6);

    }

    // Write your method here:
    public static void PrintFromNumberToOne(int nmbr)
    {
      while (nmbr > 0)
      {
        Console.WriteLine(nmbr);
        nmbr--;
      }
    }

  }
}
