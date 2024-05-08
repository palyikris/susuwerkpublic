using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nagybea
{
    public class Owl : Carnivore
    {
        public Owl() { }

        public override int Reproduce(int pop)
        {
            return pop += pop / 4 * 2;
        }

        public override (int, int) Attack(int carpop, Colony preycol)
        {
            switch (preycol.species)
            {
                case Lemming:
                    double huntedDoubleLem = preycol.population * 0.3;
                    int huntedLem = (int)huntedDoubleLem;
                    if(carpop <= huntedLem * 2)
                    {
                        return (carpop, preycol.population - huntedLem);
                    }
                    else
                    {
                        return(huntedLem / 2, preycol.population - huntedLem);
                    }

                case Rabbit:
                    double huntedDoubleRab = preycol.population * 0.2;
                    int huntedRab = (int)huntedDoubleRab;
                    if (carpop <= huntedRab)
                    {
                        return (carpop, preycol.population - huntedRab);
                    }
                    else
                    {
                        return (huntedRab, preycol.population - huntedRab);
                    }

                case Moose:
                    throw new ArgumentException("Moose is too big for Owl!");

                default:
                    throw new ArgumentException("Only preys are allowed!");

            }
        }
    }
}
