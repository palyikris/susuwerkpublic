using nagybea;
using System;

namespace Nagybea
{
    class Program
    {
        static void Main()
        {
            List<Colony> list = new List<Colony>();
            list.Add(new Colony("kicsik", 86, new Lemming()));
            list.Add(new Colony("picik", 90, new Lemming()));
            list.Add(new Colony("szaporak", 26, new Rabbit()));
            list.Add(new Colony("szorgosak", 12, new Fox()));
            list.Add(new Colony("ehesek", 12, new Bear()));
            list.Add(new Colony("tollasak", 6, new Owl()));
            Wildlife wl = new Wildlife(list);
            for (int i = 0; i < 13; i++) 
            {
                Console.WriteLine($"Round: {wl.round}");
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
