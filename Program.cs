using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "Stephen";
            Console.WriteLine($"Hello, {name}!");
            Console.WriteLine(name.ToUpper());
            Console.WriteLine($"Your name has {name.Length} characters");        
        }
    }
}
