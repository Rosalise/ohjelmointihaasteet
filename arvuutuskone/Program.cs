namespace haaste5
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Program
    {
        public static void Main(string[] args)
        {
         Console.WriteLine("User 1, enter a number between 0 and 100:");
         int user1 = Int32.Parse(Console.ReadLine());
         Console.Clear();
        
         Console.WriteLine("User 2, guess the number.");
         int user2 = Int32.Parse(Console.ReadLine());

            while(user1 != user2)
            {
            if(user1 > user2)
                {
                    Console.WriteLine($"{user2} is too low.");
                }
            else if(user1 < user2)
                {
                    Console.WriteLine($"{user2} is too high.");
                }
                Console.Write("What is your next guess? ");
                user2 = Int32.Parse(Console.ReadLine());
            }
            
            Console.WriteLine("You guessed the number!");
        }
    } 
}