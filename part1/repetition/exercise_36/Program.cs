using System;

namespace exercise_36
{
  class Program
  {
    public static void Main(string[] args)
    {
      // Write your code here:
      while (true)
      {
        Console.WriteLine("Give a number:");
        string giveNmbr = Console.ReadLine();
        int nmbr = Convert.ToInt32(giveNmbr);
        if (nmbr == 0)
        {
          break;
        }
        else if (nmbr > 0)
        {
          Console.WriteLine(nmbr * nmbr);
        }
        else
        {
            Console.WriteLine("That is negative");
        }
      }

    }
  }
}
