using System;

namespace exercise_48
{
  class Program
  {
    public static void Main(string[] args)
    {

      Console.WriteLine("Give numbers:");
      int sum = 0;
      int count = 0;
      int even = 0;
      int odd = 0;
      while (true)
      {
        int giveNmbr = Convert.ToInt32(Console.ReadLine());
        if (giveNmbr == -1)
        {
          break;
        }
        sum += giveNmbr;
        count++;
        if ((giveNmbr % 2) == 0)
        {
          even++;
        }
        else
        {
          odd++;
        }  
      }
      Console.WriteLine("Thx! Bye!");
      Console.WriteLine("Sum: " + sum);
      Console.WriteLine("Numbers: " + count);
      Console.WriteLine("Average: " + (double)sum / count);
      Console.WriteLine("Even: " + even);
      Console.WriteLine("Odd: " + odd);
      
    }
  }
}
