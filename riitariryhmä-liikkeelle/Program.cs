namespace haaste3
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Program
    {
        public static void Main(string[] args)
        {
            List<Ritari> ritarit = new List<Ritari>();

            Console.WriteLine("Kohde rivi?");
            int rivi = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Kohde sarake?");
            int sarake = Int32.Parse(Console.ReadLine());

           Ritari firstRitari = new Ritari("Ritari yksi", rivi, sarake -1);
           Ritari secondRitari = new Ritari("Ritari kaksi", rivi - 1, sarake);
           Ritari thirdRitari = new Ritari("Ritari kolme", rivi, sarake + 1);
           Ritari fourthRitari = new Ritari("Ritari neljä", rivi + 1, sarake);

           ritarit.Add(firstRitari);
           ritarit.Add(secondRitari);
           ritarit.Add(thirdRitari);
           ritarit.Add(fourthRitari);

           foreach(Ritari ritari in ritarit())
                {
                    ritari.Coordinates();
                }

        }
    } 
}