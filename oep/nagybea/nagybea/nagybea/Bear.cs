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

        public override int Reproduce(int pop)
        {
            return pop += pop / 4;
        }

        public override (int, int) Hunt(Colony car, Colony prey)
        {
            Prey prey1 = (Prey)(prey.species);
            return prey1.GetHunted(this, car, prey);
        }

    }
}
