using System;

namespace exercise_44
{
  class Program
  {
    public static void Main(string[] args)
    {

      int frstInt = Convert.ToInt32(Console.ReadLine());
      int scndInt = Convert.ToInt32(Console.ReadLine());
      if (frstInt > scndInt)
      {
        Console.WriteLine(frstInt + " is greater than " + scndInt + ".");
      }
      else if (frstInt < scndInt)
      {
        Console.WriteLine(frstInt + " is less than " + scndInt + ".");
      }
      else
      {
        Console.WriteLine(frstInt + " is equal to " + scndInt + ".");
      }

    }
  }
}
