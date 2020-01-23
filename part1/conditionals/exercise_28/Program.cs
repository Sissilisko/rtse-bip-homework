using System;

namespace exercise_28
{
  class Program
  {
    public static void Main(string[] args)
    {
      // Write your code here:
      Console.WriteLine("How old are you?");
      string userAge = Console.ReadLine();
      int intAge = Convert.ToInt32(userAge);
      if (intAge < 18)
      {
        Console.WriteLine("You're under age!");
      }
      else
      {
        Console.WriteLine("You're an adult!");
      }

    }
  }
}
