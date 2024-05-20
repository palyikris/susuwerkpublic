using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nagybea
{
    public class Moose : Prey
    {
        public Moose() { }

        public override int Reproduce(int pop, int round)
        {
            if (pop >= 200)
            {
                return 40;
            }
            else if(round % 4 == 0)
            {
                double newpop = pop * 1.2;
                return (int)newpop;
            }
            else
            {
                return pop;
            }
            
        }

        public override (int, int) GetHunted(Bear _, Colony car, Colony prey)
        {
            int carpop = Math.Min((int)(prey.population * 0.25) * 2, car.population);
            int preypop = (int)(prey.population * 0.75);

            return (carpop, preypop);
        }

        public override (int, int) GetHunted(Fox _, Colony car, Colony prey) => (0, prey.population);


        public override (int, int) GetHunted(Owl _, Colony car, Colony prey) => (0, prey.population);
    }
}
