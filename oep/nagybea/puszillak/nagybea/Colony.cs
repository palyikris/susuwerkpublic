using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nagybea
{
    public class Colony
    {
        private string name;
        public int population;
        public Animal species;

        public Colony(string name, int population, Animal species)
        {
            this.name = name;
            this.population = population;
            this.species = species;
        }

        public void Reproduction()
        {
            this.population = species.Reproduce(this.population);
        }

        public void Attack(Colony col)
        {
            (int carcol, int preycol) = species.Attack(this.population, col);
            this.population = carcol;
            col.population = preycol;
        }
    }
}
