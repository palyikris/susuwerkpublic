using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nagybea
{
    public class Bear : Carnivore
    {
        public Bear() { }

        public override int Reproduce(int pop, int round)
        {
            if(round % 8 == 0)
            {
                return pop += pop / 4;
            }
            return pop;
        }

        public override (int, int) Hunt(Colony car, Colony prey)
        {
            Prey prey1 = (Prey)(prey.species);
            return prey1.GetHunted(this, car, prey);
        }

    }
}
