using System;

namespace console_ascii_table
{
    class Program
    {
        static void Main(string[] args)
        {
            string userInput = String.Empty;
            int number = -1;

            while(true)
            {
                Console.Write("Enter a number(0-255) or 'table' to get the character or the entire table. 'stop' to break. ");

                userInput = Console.ReadLine();

                if(userInput == "stop") break;
                else if(userInput == "table")
                {
                    for(int i = 0; i <= 255; i++)
                    {       
                        char symbol = (char)i;  

                        Console.Write($"{i,-3}: {(char)i}  ");
                        if(i % 8 == 0 && i != 0) Console.WriteLine();
                    }          
                    Console.WriteLine();          
                    number = -1;
                }
                else if(!Int32.TryParse(userInput, out number)) continue;

                if(number != -1) Console.WriteLine($"Your number {number}, the correspondant character {(char)number}");
            }
        }
    }
}