using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Howdy Y'all!!");
            Console.ReadKey(); // What happens if you run the app without this line?

            Console.WriteLine("What is your name?");
            var guestName = Console.ReadLine();
            Console.WriteLine($"Hello, {guestName}.");
            Console.WriteLine("What is your favorite color?");
            var favColor = Console.ReadLine();

            var animals = new string[] { "Triceratops", "Gorilla", "Corgi", "Toucan" };

            Random rand = new Random();
            int index = rand.Next(animals.Length);

            Console.WriteLine($"Woud you like a {favColor} {animals[index]}?");

            foreach (var animal in animals)
            {
                if (animal.Length > 5)
                {
                    Console.WriteLine(animal);
                }
            }

            Console.WriteLine("Pick a Greeting: Southern, British, or Fish");
            var chosenGreeting = Console.ReadLine();
            switch (chosenGreeting)
            {
                case "British":
                    Console.WriteLine("Hello there, would ya like a cuppa?");
                    break;
                case "Fish":
                    Console.WriteLine("Silly human, Fish won't talk to you.");
                    break;
                default:
                    Console.WriteLine("Hey there, ya'll");
                    break;
            }

        }
    }
}
