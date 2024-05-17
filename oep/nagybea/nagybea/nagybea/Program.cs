using nagybea;
using System;

namespace nagybea
{
    class Program
    {
        static void Main()
        {
            Wildlife wl = new Wildlife();
            wl.colonies.Add(new Colony("lemming1", 86, new Lemming()));
            wl.colonies.Add(new Colony("lemming2", 90, new Lemming()));
            wl.colonies.Add(new Colony("nyul", 26, new Rabbit()));
            wl.colonies.Add(new Colony("roka", 12, new Fox()));
            wl.colonies.Add(new Colony("medve", 12, new Bear()));
            wl.colonies.Add(new Colony("bagoly", 6, new Owl()));

            for (int i = 0; i < 13; i++) 
            {
                Console.WriteLine($"Round: {wl.round + 1}");
                foreach (Colony colony in wl.colonies)
                {
                    Console.WriteLine($"Name: {colony.name}, Population: {colony.population}");
                }
                Console.WriteLine();
                wl.Turn();
            }
        }
    }
}
