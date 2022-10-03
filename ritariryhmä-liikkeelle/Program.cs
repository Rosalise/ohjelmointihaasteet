namespace haaste3
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Program
    {
        public static void Main(string[] args)
       {
            List<Ritari>ritarit = new List<Ritari>();

            Console.Write("Kohde rivi?");
            int rivi = Int32.Parse(Console.ReadLine());

            Console.Write("Kohde sarake?");
            int sarake = Int32.Parse(Console.ReadLine());

            Ritari firstritari = new Ritari("Ritari yksi", rivi, sarake - 1);
            Ritari secondritari = new Ritari("Ritari kaksi", rivi - 1, sarake);
            Ritari thirdritari = new Ritari("Ritari kolme", rivi, sarake + 1);
            Ritari fourthritari = new Ritari("Ritari neljä", rivi + 1, sarake);

            ritarit.Add(firstritari);
            ritarit.Add(secondritari);
            ritarit.Add(thirdritari);
            ritarit.Add(fourthritari);

            foreach(Ritari ritari in ritarit)
            {
                ritari.Coordinates();
            }

        }
    } 
}