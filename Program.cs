using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            //three variables, two ints for two counters and a string for the if/else
            int counter = 0;
            int finalsum = 0;
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
            //BEEP BEEP!
            do
            {
                Console.WriteLine("Do Loop Scoop Woop");
                Console.Beep();
            } while (counter == 10);

            //a for loop with a variable other than counter
            for (int iteration = 0; iteration < 5; iteration++)
             {
                Console.WriteLine("FOR");
             }

            // for/if loop that adds up all ints divisible by 3 between 0 and 50 and outputs sum
            for(int addup = 0; addup < 50; addup++) 
            {
                if (addup % 3 == 0)
                {
                    finalsum += addup;
                }
            }

            Console.WriteLine(finalsum);

            //format string, can be used a template. 0 and 1 are replaced by the values separated by comma
            //displays the range of a byte
            Console.WriteLine("{0} {1}", byte.MinValue, byte.MaxValue);

            //playing a bit with type converting to convert a string into an integer
            //also playing with exception handling
            try
            {
                string x = "x";
                int number = Convert.ToInt32(x);
                Console.WriteLine(number);
            }
            catch (Exception)
            {
                Console.WriteLine("MESSED UP");
            }

        }

    }
}
