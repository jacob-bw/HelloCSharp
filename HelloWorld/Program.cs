using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Howdy Y'all!!");
            //Console.ReadKey(); // What happens if you run the app without this line?
            Console.WriteLine("How would you like to be greeted? Please choose between 'Southern', 'Yenta', and 'Wookie'...");

            var selectedDialect = Console.ReadLine();

            switch (selectedDialect)
            {
                case "Southern":
                    Console.WriteLine("Howdy y'all...");
                    Console.ReadLine();
                    break;
                case "Yenta":
                    Console.WriteLine("So good to see you. I was worried since you never call...");
                    Console.ReadLine();
                    break;
                case "Wookie":
                    Console.WriteLine("grrrooawrrrrll. arf arf");
                    Console.ReadLine();
                    break;
                default:
                    Console.WriteLine("Howdy Y'all");
                    Console.ReadLine();
                    break;
            }

            var animals = new string[] { "Triceratops", "Gorilla", "Corgi", "Toucan" };

            foreach (var animal in animals)
            {
            var vowels = new string[] { "a", "e", "i", "o", "u" };

                Console.WriteLine(animal);
                Console.ReadLine();
            }
            // read word
            // compare word syllables 

            // if word > 2 syllables
            //if (true)
            //{
            //    // print the word
            //}
                

        }
    }
}
