using System;

namespace exercise_27
{
  class Program
  {
    public static void Main(string[] args)
    {
      // Write your code here:
      Console.WriteLine("Give a number:");
      string userNmbr = Console.ReadLine();
      int intNmbr = Convert.ToInt32(userNmbr);
      if (intNmbr > 0)
      {
        Console.WriteLine("It is positive");
      }
      else
      {
      Console.WriteLine("It is not positive");
      }

    }
  }
}
