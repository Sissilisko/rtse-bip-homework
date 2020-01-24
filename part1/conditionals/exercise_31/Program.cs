using System;

namespace exercise_31
{
  class Program
  {
    public static void Main(string[] args)
    {
      // Write your code here:
      Console.WriteLine("Give a number:");
      string usrNmbr = Console.ReadLine();
      int intNmbr = Convert.ToInt32(usrNmbr);

      if (intNmbr % 2 == 0)
      {
        Console.WriteLine("It is even.");
      }
      else
      {
        Console.WriteLine("It is odd.");
      }

    }
  }
}
