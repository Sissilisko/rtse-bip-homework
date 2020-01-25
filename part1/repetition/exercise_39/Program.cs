using System;

namespace exercise_39
{
  class Program
  {
    public static void Main(string[] args)
    {
      // Write your code here:
      int sum = 0;
      while (true)
      {
        Console.WriteLine("Give a number:");
        int giveNmbr = Convert.ToInt32(Console.ReadLine());
        if (giveNmbr == 0)
        {
          break;
        }
        else
        {
          sum = sum + giveNmbr;
        }
      }
      Console.WriteLine("Total sum of numbers: " + sum);
    }
  }
}
