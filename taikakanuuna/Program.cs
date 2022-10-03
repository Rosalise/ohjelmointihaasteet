namespace haaste6
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Program
    {
        public static void Main(string[] args)
        {

            for(int i = 1; i <= 100; i++)
            {
                // Joka 3. Tuli ja joka 5 Sähkö
                if(i % 3 == 0 && i % 5 != 0)
                    {
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine($"{i}: Fire");
                    }
                else if (i % 3 != 0 && i % 5 == 0) 
                    {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine($"{i}: Electric");
                    }
                else if (i % 3 == 0 && i % 5 == 0)
                    {
                        Console.ForegroundColor = ConsoleColor.DarkBlue;
                        Console.WriteLine($"{i}: Electric and Fire");
                    }

                else {
                    Console.ForegroundColor = ConsoleColor.Gray;
                    Console.WriteLine($"{i}: Normal");
                }
            }
        }

    }
}

