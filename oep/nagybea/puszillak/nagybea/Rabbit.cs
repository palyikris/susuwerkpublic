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
    }
}
