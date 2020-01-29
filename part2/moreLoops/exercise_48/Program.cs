using System;

namespace exercise_48
{
  class Program
  {
    public static void Main(string[] args)
    {

      int sum = 0;
      Console.WriteLine("Give numbers:");
      while (true)
      {
        int giveNmbr = Convert.ToInt32(Console.ReadLine());
        if (giveNmbr == -1)
        {
          break;
        }
        sum += giveNmbr;
      }
      Console.WriteLine("Thx! Bye!");
      Console.WriteLine("Sum: " + sum);
    }
  }
}
