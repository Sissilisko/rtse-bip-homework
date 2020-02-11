using System;
using System.Collections.Generic;

namespace exercise_92
{
    class Program
    {
        public static void Main(string[] args)
        {
          int oldest = 2020;
          int length = 0;
          string name = "";
          int age = 0;
          int lngthName = 0;



          while (true)
          {
          string usrInput = Console.ReadLine();
          if (usrInput == "")
          {
            break;
          }

          string[] parts = usrInput.Split(",");

          if (Convert.ToInt32(parts[1]) < oldest)
           {
            oldest = Convert.ToInt32(parts[1]);
            }

            string word = parts[0];
            length = word.Length;

          if (length > lngthName)
            {
              lngthName = length;
              name = parts[0];
            }
          }
          age = 2020 - oldest;
          Console.WriteLine("Longest name: " + name);
          Console.WriteLine("Highest age: " + age);
        }
    }
}



