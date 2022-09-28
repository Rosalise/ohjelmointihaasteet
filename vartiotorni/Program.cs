namespace haaste1
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Program
    {
        public static void Main(string[] args)
       {
            Console.WriteLine("Kirjoita x: ");
            int x = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Kirjoita y: ");
            int y = Int32.Parse(Console.ReadLine());

            if(x > 0)
            {
                if(y > 0)
                {
                    Console.WriteLine("The enemy is to the north east!");
                }
                else if(y == 0)
                {
                    Console.WriteLine("The enemy is to the east!");
                }
                else
                {
                    Console.WriteLine("The enemy is to the south east!");
                }
            }

            else if(x == 0)
            {
                if(y > 0)
                {
                    Console.WriteLine("The enemy is to the north!");
                }
                else if(y < 0)
                {
                    Console.WriteLine("The enemy is to the south!");
                }
                else
                {
                    Console.WriteLine("You are the enemy!");
                }
            }
            else if(x < 0)
            {
                if(y > 0)
                {
                    Console.WriteLine("The enemy is to the north west!");
                }
                else if(y == 0)
                {
                    Console.WriteLine("The enemy is to the west!");
                }
                else
                {
                    Console.WriteLine("The enemy is to the south west!");
                }
            }
        }
    } 
}