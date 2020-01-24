using System;

namespace exercise_30
{
  class Program
  {
    public static void Main(string[] args)
    {
      // Write your code here:
      Console.WriteLine("Give your percent [0 - 100]:");
      string userPrcnt = Console.ReadLine();
      int intPrcnt = Convert.ToInt32(userPrcnt);

      if (intPrcnt > 0 && intPrcnt < 50)
      {
        Console.WriteLine("Fail");

      }
      else if (intPrcnt > 49 && intPrcnt < 60)
      {
        Console.WriteLine("Grade: 1");
      }
      else if (intPrcnt > 59 && intPrcnt < 70)
      {
        Console.WriteLine("Grade: 2");
      }
      else if (intPrcnt > 69 && intPrcnt < 80)
      {
        Console.WriteLine("Grade: 3");
      }
      else if (intPrcnt > 79 && intPrcnt < 90)
      {
        Console.WriteLine("Grade: 4");
      }
      else if (intPrcnt > 89 && intPrcnt <= 100)
      {
        Console.WriteLine("Grade: 5");
      }
      else if (intPrcnt > 100)
      {
        Console.WriteLine("Outstanding!");
      }
      else
      {
        Console.WriteLine("Impossible");
      }

    }
  }
}
