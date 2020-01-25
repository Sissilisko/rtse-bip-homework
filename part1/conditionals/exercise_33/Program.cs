using System;

namespace exercise_33
{
  class Program
  {
    public static void Main(string[] args)
    {
      // Write your code here:
      Console.WriteLine("Give the first string:");
      string frstInput = Console.ReadLine();
      Console.WriteLine("Give the second string:");
      string scndInput = Console.ReadLine();
      if (frstInput == scndInput)
      {
        Console.WriteLine("Echo!");
      }
      else
      {
        Console.WriteLine("Nope!");
      }

    }
  }
}
