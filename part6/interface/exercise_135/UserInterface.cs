using System;
using System.Collections.Generic;
namespace exercise_135
{
    public class UserInterface
    {
        public JokeManager joke;
        public UserInterface(JokeManager joke)
        {
            this.joke = joke;
        }
        public void Start()
        {
            List<string> jokes = new List<string>();
            Console.WriteLine("What a joke!");
            while (true)
            {
                Console.WriteLine("Commands:");
                Console.WriteLine("1 - add a joke");
                Console.WriteLine("2 - draw a joke");
                Console.WriteLine("3 - list jokes");
                Console.WriteLine("X - stop");

                string command = Console.ReadLine();
            if (command == "1")
            {
                Console.WriteLine("Write a joke to be added:");
                string joke = Console.ReadLine();
                jokes.Add(joke);
            }
            else if (command == "2")
            {
                Console.WriteLine("Drwaing a joke.");
                if (jokes.Count == 0)
                {
                    Console.WriteLine("Jokes are in shoert supply.");
                }
                else
                {
                    Random draw = new Random();
                    int index = draw.Next(0, jokes.Count);
                    Console.WriteLine(jokes[index]);
                }
            }
            else if (command == "3")
            {
                Console.WriteLine("Printing the jokes.");
                foreach (string joke in jokes)
                {
                    Console.WriteLine(joke);
                }
            }
            else
            {
                break;
            }
            }
        }
    }
}