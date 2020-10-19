using System;

namespace console_screen_background
{
    class Program
    {
        static void Main(string[] args)
        {
            int consoleHeight = Console.WindowHeight,
                consoleWidth = Console.WindowWidth;
            Random rdnNb = new Random();

            Console.SetCursorPosition(consoleWidth-10, consoleHeight-10);
            Console.WriteLine($"Height: {consoleHeight} | Width: {consoleWidth}");

            Console.SetCursorPosition(rdnNb.Next(0, consoleHeight-1), rdnNb.Next(0, consoleWidth));
            Console.ForegroundColor = (ConsoleColor) rdnNb.Next(0,15);
            Console.Write('█');
        }
    }
}
