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

        public override int Reproduce(int pop)
        {
            if (pop >= 200)
            {
                return 40;
            }
            double newpop = pop * 1.2;
            return (int)newpop;
        }
    }
}
