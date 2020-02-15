using System;

namespace exercise_93
{
  class Program
  {
    public static void Main(string[] args)
    {
      // DO NOT TOUCH THE OTHER FILE!
      // Do your code here!
      Account shadyBusinesses = new Account("Shady Businesses", 100.00);
      shadyBusinesses.Deposit(20.0);
      Console.WriteLine(shadyBusinesses.balance);
    }
  }
}



