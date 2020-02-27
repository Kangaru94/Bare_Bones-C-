using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            //two variables, an int for the counter and a string for the if/else
            int counter = 0;
            string name = "Stephen";

            //basic WriteLine
            Console.WriteLine($"Hello, {name}!");
            Console.WriteLine(name.ToUpper());
            Console.WriteLine($"Your name has {name.Length} characters");

            //my if/else statement
            //outputs "YES" and "Is Stephen" if variable "name" == "Stephen"
            if (name == "Stephen")
            {
                Console.WriteLine("YES");
                Console.WriteLine("Is Stephen");
            }

            //else it outputs "No" and "Is not Stephen"
            else
            {
                Console.WriteLine("No");
                Console.WriteLine("Is not Stephen");
            }

            //first instance of a Do loop
            //shows it runs before the condition is met, as the counter isn't  increased yet
            do
            {
                Console.WriteLine("Do Loop Scoop Woop");
            } while (counter == 10);

            //the while loop simply counts to 10
            //doesn't run unless the condition is met
            while (counter <= 10)
            {
                Console.WriteLine(counter);
                counter++;
            }

            //Shows the Do loop will run again if the condition is met
            do
            {
                Console.WriteLine("Do Loop Scoop Woop");
            } while (counter == 10);

        }

    }
}
