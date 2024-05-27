using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nagybea
{
    public class Lemming : Prey
    {
        public Lemming()
        {

        }

        public override int Reproduce(int pop, int round)
        {
            if(pop >= 200)
            {
                return 30;
            }
            else if(round % 2  == 0)
            {
                return pop * 2;
            }
            else
            {
                return pop;
            }
        }

        public override (int, int) GetHunted(Bear _, Colony car, Colony prey)
        {
            int carpop = Math.Min((int)(prey.population * 0.02) / 20, car.population);
            int preypop = (int)(prey.population * 0.98);

            return(carpop, preypop);
        }

        public override (int, int) GetHunted(Fox _, Colony car, Colony prey)
        {
            int carpop = Math.Min((int)(prey.population * 0.05) / 4, car.population);
            int preypop = (int)(prey.population * 0.95);

            return (carpop, preypop);
        }

        public override (int, int) GetHunted(Owl _, Colony car, Colony prey)
        {
            int carpop = Math.Min((int)(prey.population * 0.3) / 2, car.population);
            int preypop = (int)(prey.population * 0.7);

            return (carpop, preypop);
        }
    }
}
