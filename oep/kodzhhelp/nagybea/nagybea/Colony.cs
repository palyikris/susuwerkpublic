using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nagybea
{
    public class Colony
    {
        public string name;
        public int population;
        public Animal species;

        public Colony(string name, int population, Animal species)
        {
            this.name = name;
            this.population = population;
            this.species = species;
        }

        public void Reproduction(int round)
        {
            this.population = species.Reproduce(this.population, round);
        }

        public void Attack(Colony col)
        {
            if(this.species is Carnivore)
            {
                Carnivore car = this.species as Carnivore;
                (int carcol, int preycol) = car.Hunt(this, col);
                this.population = carcol;
                col.population = preycol;
            }
        }
    }
}
