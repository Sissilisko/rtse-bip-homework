using System;

namespace exercise_38
{
  class Program
  {
    public static void Main(string[] args)
    {
      // Write your code here:
      int negNmbr = 0;
      while (true)
      {
        Console.WriteLine("Give a number:");
        int giveNmbr = Convert.ToInt32(Console.ReadLine());
        if (giveNmbr == 0)
        {
          break;
        }
        if (giveNmbr < 0)
        {
          negNmbr++; 
        }
      }
      Console.WriteLine("Total amount of negative numbers: " + negNmbr);

    }
  }
}
