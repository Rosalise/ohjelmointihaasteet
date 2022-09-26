namespace haaste1
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Program
    {
        public static void Main(string[] args)
       {
            Console.WriteLine("Kuinka monta kalaa karhut ovat kalastaneet?");
            int amount = Int32.Parse(Console.ReadLine());
            int karhu = amount / 4;
            int kissa = amount % 4;

            Console.WriteLine("Kukin karhu saa " + karhu + ".");
            Console.WriteLine($"Kissa saa {kissa}");

            if(kissa > karhu)
            {
                Console.WriteLine($"Kissa saa enemmän kalaa, kun kalaa on {amount}.");
            }
        }
    } 
}