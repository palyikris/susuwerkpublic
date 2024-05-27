using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nagybea
{
    public abstract class Carnivore : Animal
    {
        public Carnivore() { }

        public new abstract (int, int) Hunt(Colony _, Colony __);
    }
}
