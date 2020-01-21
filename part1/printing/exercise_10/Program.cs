using System;

namespace exercise_10
{
    class Program
    {
        public static void Main(string[] args)
        {
            // Write your code here:
            Console.WriteLine("I will tell a story, but I need some information.");
            Console.WriteLine("Give a name for main character:");

            string chrName = Console.ReadLine();

            Console.WriteLine("Give the character a profession:");

            string chrPrf= Console.ReadLine();

            Console.WriteLine("Here is the story:\n" + 
            "Once upon a time there was a " + chrPrf + " called " + chrName + "\n" + 
            "On her way to work, " + chrName + " often pondered what being " + chrPrf + " meant to them.\n" + 
            "When you work as a " + chrPrf + " you meet interesting people.\n" + 
            chrName + " enjoys their work as " + chrPrf + ", The end.");


        }
    }
}
