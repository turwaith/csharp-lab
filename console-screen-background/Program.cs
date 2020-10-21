using System;
using System.Threading;
//using System.Timers;

namespace console_screen_background
{
    class Program
    {
        static void Main(string[] args)
        {            
            ConsoleColor originalForeground = Console.ForegroundColor;
            ConsoleColor originalBackground = Console.BackgroundColor;
            Random rndNb = new Random();
            ConsoleKeyInfo cki;
            char charToDisplay = '*'; 
            int speed = 500;

            for(int i = 0; i < args.Length; i++)
            {
                switch (i)
                {
                    case 0:  
                        charToDisplay = args[0][0];
                    break;
                    case 1:                        
                        int.TryParse(args[1], out speed);
                        if(speed == 0) speed = 500;                        
                    break;
                }                                 
            }


            Console.Clear();
            Console.CursorVisible = false;
            
            do{
                while(Console.KeyAvailable == false)
                {
                    int consoleHeight = Console.WindowHeight,
                        consoleWidth = Console.WindowWidth;

                    Console.SetCursorPosition(rndNb.Next(0, consoleWidth), rndNb.Next(0, consoleHeight));
                    Console.ForegroundColor = (ConsoleColor) rndNb.Next(0,16);
                    Console.Write(charToDisplay);
                    Thread.Sleep(speed);
                } 

                cki = Console.ReadKey(true);
            }while(cki.Key != ConsoleKey.Enter);

            Console.Clear();
            Console.BackgroundColor = originalBackground;
            Console.ForegroundColor = originalForeground;
            Console.CursorVisible = true;
            /*Timer screenTimer = new Timer();
            ConsoleColor originalForeground = Console.ForegroundColor;
            ConsoleColor originalBackground = Console.BackgroundColor;
            
            screenTimer.Interval = 500;
            screenTimer.Elapsed += OnTimedEvent;
            screenTimer.AutoReset = true;
            screenTimer.Enabled =  true;

            Console.CursorVisible = false;
            Console.Clear();           

            Console.ReadLine();
            screenTimer.Stop();

            Console.Clear();
            Console.BackgroundColor = originalBackground;
            Console.ForegroundColor = originalForeground;
            Console.CursorVisible = true;    
            */     
        }

        /*public static void OnTimedEvent(Object source, System.Timers.ElapsedEventArgs e)
        {
            int consoleHeight = Console.WindowHeight,
                consoleWidth = Console.WindowWidth;
            Random rndNb = new Random();
            //char[] squareChar = {'▄','▀'};
            ConsoleColor ori = Console.ForegroundColor;
            
            Console.SetCursorPosition(rndNb.Next(0, consoleWidth), rndNb.Next(0, consoleHeight));
            //if(Console.ForegroundColor != ori) Console.BackgroundColor = ori;
            //Console.BackgroundColor = (ConsoleColor) rndNb.Next(0,16);
            Console.ForegroundColor = (ConsoleColor) rndNb.Next(0,16);
            //Console.Write(squareChar[rndNb.Next(0,2)]);
            Console.Write("*");
        }
        */
    }
}
