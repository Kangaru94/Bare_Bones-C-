using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            int counter = 0;
            string name = "Stephen";
            Console.WriteLine($"Hello, {name}!");
            Console.WriteLine(name.ToUpper());
            Console.WriteLine($"Your name has {name.Length} characters");

            if (name == "Stephen")
            {
                Console.WriteLine("YES");
                Console.WriteLine("Is Stephen");
            }

            else
            {
                Console.WriteLine("No");
                Console.WriteLine("Is not Stephen");
            }
 
            while (counter <= 10)
            {
                Console.WriteLine(counter);
                counter++;
            }

        }

    }
}
