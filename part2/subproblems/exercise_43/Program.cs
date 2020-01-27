using System;

namespace exercise_43
{
  class Program
  {
    public static void Main(string[] args)
    {
      int userInt = Convert.ToInt32(Console.ReadLine());
      if (userInt < 0)
      {
        Console.WriteLine(userInt * -1);
      }
      else
      {
        Console.WriteLine(userInt);
      }
      
    }
  }
}
