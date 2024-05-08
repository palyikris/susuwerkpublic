using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nagybea
{
    public class Fox : Carnivore
    {
        public Fox() { }

        public override int Reproduce(int pop)
        {
            return pop += pop / 4 * 3;
        }

        public override (int, int) Attack(int carpop, Colony preycol)
        {
            switch (preycol.species)
            {
                case Lemming:
                    double huntedDoubleLem = preycol.population * 0.05;
                    int huntedLem = (int)huntedDoubleLem;
                    if (carpop <= huntedLem * 4)
                    {
                        return (carpop, preycol.population - huntedLem);
                    }
                    else
                    {
                        return (huntedLem / 4, preycol.population - huntedLem);
                    }

                case Rabbit:
                    double huntedDoubleRab = preycol.population * 0.35;
                    int huntedRab = (int)huntedDoubleRab;
                    if (carpop <= huntedRab * 2)
                    {
                        return (carpop, preycol.population - huntedRab);
                    }
                    else
                    {
                        return (huntedRab / 2, preycol.population - huntedRab);
                    }

                case Moose:
                    throw new ArgumentException("Moose is too big for Owl!");

                default:
                    throw new ArgumentException("Only preys are allowed!");

            }
        }
    }
}
