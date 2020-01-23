using System;

namespace exercise_29
{
  class Program
  {
    public static void Main(string[] args)
    {
      // Write your code here:
      Console.WriteLine("Give the first number!");
      string frstNmbr = Console.ReadLine();
      int intFrst = Convert.ToInt32(frstNmbr);
      
      Console.WriteLine("Give the second number!");
      string scndNmbr = Console.ReadLine();
      int intScnd = Convert.ToInt32(scndNmbr);
      
      if (intFrst > intScnd)
      {
        Console.WriteLine("The larger number is " + intFrst + "!");
      }
      else if (intFrst < intScnd)
      {
        Console.WriteLine("The larger number is " + intScnd + "!");
      }
      else
      {
        Console.WriteLine("They are equal!");
      }


    }
  }
}
