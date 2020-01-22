using System;

namespace exercise_18
{
  class Program
  {
    public static void Main(string[] args)
    {

      // Write your code here:
      Console.WriteLine("Give the first number!");
      string frstNmbr = Console.ReadLine();
      int frst = Convert.ToInt32(frstNmbr);
      
      Console.WriteLine("Give the second number!");
      string scndNmbr = Console.ReadLine();
      int scnd = Convert.ToInt32(scndNmbr);

      Console.WriteLine("Give the third number!");
      string thrdNmbr = Console.ReadLine();
      int thrd = Convert.ToInt32(thrdNmbr);

      Console.WriteLine("The sum is " + (frst + scnd + thrd));


      
    }
  }
}
