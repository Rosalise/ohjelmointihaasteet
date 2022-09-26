namespace haaste2
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Program
    {
        public static void Main(string[] args)
       {
           Console.WriteLine("Montako maatilaa on Teidän hallussanne?"); // maatila on 1 piste
           int maatila = Int32.Parse(Console.ReadLine());

           Console.WriteLine("Montako herttuakuntaa on Teidän hallussanne?"); // maatila on 3 piste
           int herttuakunta = Int32.Parse(Console.ReadLine());

           Console.WriteLine("Montako maakuntaa on Teidän hallussanne?"); // maatila on 6 piste
           int maakunta = Int32.Parse(Console.ReadLine());

           int pisteet = (maatila * 1) + (herttuakunta * 3) + (maakunta * 6);

           Console.WriteLine($"Teillä on yleensä {pisteet} pistettä.");
        }
    } 
}