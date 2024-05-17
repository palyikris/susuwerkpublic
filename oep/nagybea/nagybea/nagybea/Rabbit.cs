using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nagybea
{
    public class Rabbit : Prey
    {

        public Rabbit() { }
        public override int Reproduce(int pop)
        {
            if (pop >= 100)
            {
                return 20;
            }
            double newpop = pop * 1.5;
            return (int)newpop;
        }

        public override (int, int) GetHunted(Bear _, Colony car, Colony prey)
        {
            int carpop = Math.Min((int)(prey.population * 0.01) / 10, car.population);
            int preypop = (int)(prey.population * 0.99);

            return (carpop, preypop);
        }

        public override (int, int) GetHunted(Fox _, Colony car, Colony prey)
        {
            int carpop = Math.Min((int)(prey.population * 0.35) / 2, car.population);
            int preypop = (int)(prey.population * 0.65);

            return (carpop, preypop);
        }

        public override (int, int) GetHunted(Owl _, Colony car, Colony prey)
        {
            int carpop = Math.Min((int)(prey.population * 0.2), car.population);
            int preypop = (int)(prey.population * 0.8);

            return (carpop, preypop);
        }
    }
}
