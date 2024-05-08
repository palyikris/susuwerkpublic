using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nagybea
{
    public class Wildlife
    {
        private List<Colony> colonies;
        private int round;

        public Wildlife(List<Colony> colonies) {
            
            this.colonies = new List<Colony>();
            foreach (Colony col in colonies)
            {
                this.colonies.Add(col);
                this.round = 1;
            }
        }

        public void Turn() 
        {
            Simulate();
            this.round++;
        }

        private void Simulate()
        {
            foreach(Colony colony in colonies)
            {
                switch (colony.species)
                {
                    case Lemming:
                        if(round % 2 == 0)
                        {
                            colony.Reproduction();
                        }
                        break;
                    case Rabbit:
                        if (round % 2 == 0)
                        {
                            colony.Reproduction();
                        }
                        break;
                    case Moose:
                        if (round % 4 == 0)
                        {
                            colony.Reproduction();
                        }
                        break;
                    case Owl:
                        if (round % 3 == 0)
                        {
                            colony.Reproduction();
                        }
                        List<Colony> preys = colonies.Where(col => col.species is Lemming or Rabbit).ToList();
                        Random random = new Random();
                        int randomIndex = random.Next(0, preys.Count());
                        (int carpop, int preypop) = colony.species.Attack(colony.population, preys[randomIndex]);
                        colony.population = carpop;
                        preys[randomIndex].population = preypop;
                        break;
                    case Fox:
                        if (round % 3 == 0)
                        {
                            colony.Reproduction();
                        }
                        List<Colony> preys1 = colonies.Where(col => col.species is Lemming or Rabbit).ToList();
                        Random random1 = new Random();
                        int randomIndex1 = random1.Next(0, preys1.Count());
                        (int carpop1, int preypop1) = colony.species.Attack(colony.population, preys1[randomIndex1]);
                        colony.population = carpop1;
                        preys1[randomIndex1].population = preypop1;
                        break;

                    case Bear:
                        if (round % 8 == 0)
                        {
                            colony.Reproduction();
                        }
                        List<Colony> preys2 = colonies.Where(col => col.species is Lemming or Rabbit or Moose).ToList();
                        Random random2 = new Random();
                        int randomIndex2 = random2.Next(0, preys2.Count());
                        (int carpop2, int preypop2) = colony.species.Attack(colony.population, preys2[randomIndex2]);
                        colony.population = carpop2;
                        preys2[randomIndex2].population = preypop2;
                        break;

                    default:
                        throw new ArgumentException("Illegal Colony!");


                }
                
            }
        }
    }
}
