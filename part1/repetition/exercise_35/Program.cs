using System;

namespace exercise_35
{
  class Program
  {
    public static void Main(string[] args)
    {
      // Write your code here:
      while(true)
      {
        Console.WriteLine("Give a number:");
        string giveNmbr = Console.ReadLine();
        int nmbr = Convert.ToInt32(giveNmbr);
        if (nmbr == 42)
        {
          break;
        }
      }

    }
  }
}
