using System;

namespace exercise_26
{
  class Program
  {
    public static void Main(string[] args)
    {
      // Write your code here:
      Console.WriteLine("Give your age:");
      string userAge = Console.ReadLine();
      int intAge  = Convert.ToInt32(userAge);
      if (intAge <1900)
      {
        Console.WriteLine("You're old");
      }

    }
  }
}
