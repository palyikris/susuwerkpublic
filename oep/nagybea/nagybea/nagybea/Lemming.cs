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

        public override int Reproduce(int pop)
        {
            if(pop >= 200)
            {
                return 30;
            }
            return pop * 2;
        }
    }
}
