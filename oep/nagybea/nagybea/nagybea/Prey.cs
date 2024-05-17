using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nagybea
{
    public abstract class Prey : Animal
    {
        public Prey() { }

        public abstract (int, int) GetHunted(Owl _, Colony car, Colony prey);

        public abstract (int, int) GetHunted(Fox _, Colony car, Colony prey);

        public abstract (int, int) GetHunted(Bear _, Colony car, Colony prey);
    }
}
