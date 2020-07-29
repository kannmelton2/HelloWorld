using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Howdy Y'all!!");
            Console.ReadKey(); // What happens if you run the app without this line?

            var animals = new string[] { "Triceratops", "Gorilla", "Corgi", "Toucan" };

            foreach (var animal in animals)
            {
                if (animal.Length > 5)
                {
                    Console.WriteLine(animal);
                }
            }

            var greetings = new string[] { "Hey there, ya'll", "Hello there, would ya like a cuppa?", "Silly, fish don't talk to humans." };

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
