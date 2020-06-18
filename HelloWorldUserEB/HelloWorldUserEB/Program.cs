using System;

namespace HelloWorldUserEB
{
    public class Program
    {
        public static ConsoleKey keyPressed;

        public static void Main()
        {
            Console.WriteLine("Hello World!");
            while (keyPressed != ConsoleKey.Enter)
            {
                Console.WriteLine("\nPress The Enter Key To Exit Program...");
                keyPressed = Console.ReadKey().Key;
            }
        }
    }
}
