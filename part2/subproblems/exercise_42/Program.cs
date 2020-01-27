using System;

namespace exercise_42
{
  class Program
  {
    public static void Main(string[] args)
    {

      int frstInput = Convert.ToInt32(Console.ReadLine());
      int scndInput = Convert.ToInt32(Console.ReadLine());

      double squareRoot = Math.Sqrt(frstInput + scndInput);
      Console.WriteLine(squareRoot);
    
    }
  }
}
