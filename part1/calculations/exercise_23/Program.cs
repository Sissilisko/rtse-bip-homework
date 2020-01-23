using System;

namespace exercise_23
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

      Console.WriteLine(frst + " + " + scnd + " = " + (frst + scnd));
      Console.WriteLine(frst + " - " + scnd + " = " + (frst - scnd));
      Console.WriteLine(frst + " * " + scnd + " = " + (frst * scnd));
      Console.WriteLine(frst + " / " + scnd + " = " + ((double)frst / scnd));
      
    }
  }
}
