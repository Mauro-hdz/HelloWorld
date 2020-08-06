using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {

            int count = 20;
            double num = 2.49;
            char character = 'L';
            string intro = "Hello user I am a C# program";
            Console.WriteLine(intro);
            Console.WriteLine($"count is: {count}.");
            Console.WriteLine(character + "is the first letter in loser.");
            Console.WriteLine($"The price of a bag of chips is {num}.");
        }
    }
}
