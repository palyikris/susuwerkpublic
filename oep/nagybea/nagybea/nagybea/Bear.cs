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

        public override (int, int) Attack(int carpop, Colony preycol)
        {
            switch (preycol.species)
            {
                case Lemming:
                    double huntedDoubleLem = preycol.population * 0.02;
                    int huntedLem = (int)huntedDoubleLem;
                    if (carpop <= huntedLem * 20)
                    {
                        return (carpop, preycol.population - huntedLem);
                    }
                    else
                    {
                        return (huntedLem / 20, preycol.population - huntedLem);
                    }

                case Rabbit:
                    double huntedDoubleRab = preycol.population * 0.01;
                    int huntedRab = (int)huntedDoubleRab;
                    if (carpop <= huntedRab * 10)
                    {
                        return (carpop, preycol.population - huntedRab);
                    }
                    else
                    {
                        return (huntedRab / 10, preycol.population - huntedRab);
                    }

                case Moose:
                    double huntedDoubleMo = preycol.population * 0.25;
                    int huntedMo = (int)huntedDoubleMo;
                    if (carpop <= huntedMo * 0.5)
                    {
                        return (carpop, preycol.population - huntedMo);
                    }
                    else
                    {
                        return (huntedMo * 2, preycol.population - huntedMo);
                    }

                default:
                    throw new ArgumentException("Only preys are allowed!");

            }
        }
    }
}
