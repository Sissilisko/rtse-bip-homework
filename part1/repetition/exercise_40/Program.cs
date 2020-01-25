using System;

namespace exercise_40
{
  class Program
  {
    public static void Main(string[] args)
    {
      int sum = 0;
      int count = 0;

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
          count++;
        }
      }
      Console.WriteLine("Total sum of numbers: " + sum);
      Console.WriteLine("Total amount of numbers: " + count);
    }
  }
}
