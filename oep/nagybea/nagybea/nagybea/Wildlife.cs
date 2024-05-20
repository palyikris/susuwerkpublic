using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nagybea
{
    public class Wildlife
    {
        public List<Colony> colonies;
        public int round;

        public Wildlife() {
            
            this.colonies = new List<Colony>();
            this.round = 0;
        }

        public void Turn() 
        {
            Simulate();
            this.round++;
        }

        private void Simulate()
        {
            foreach(Colony colony in this.colonies)
            {
                colony.Reproduction(round);
                if(colony.species is Carnivore)
                {
                    Random random = new Random();
                    List<Colony> preys = colonies.FindAll(colony => colony.species is Prey);
                    int randomIndex = random.Next(0, preys.Count);
                    colony.Attack(preys[randomIndex]);
                }
            }
        }

        public int GetNumberOfCarnivores()
        {
            List<Colony> cars = this.colonies.FindAll(col => col.species is Carnivore);
            int count = 0;
            foreach(Colony colony in cars)
            {
                count += colony.population;
            }
            return count;
        }

        public bool AreAllCarnivoresUnderFour()
        {
            List<Colony> cars = this.colonies.FindAll(col => col.species is Carnivore);
            foreach (Colony colony in cars)
            {
                if(colony.population >= 4)
                {
                    return false;
                }
            }

            return true;
        }

        public List<Animal> GetExtinctAnimals()
        {
            List<Animal> result = new List<Animal> ();
            HashSet<Animal> species = new HashSet<Animal>(this.colonies.Select(col => col.species).ToList());   
            foreach(Animal animal in species)
            {
                bool isAnimalExtinct = IsAnimalExtinct(animal);
                if (isAnimalExtinct)
                {
                    result.Add(animal);
                }
            }

            return result;
        }

        private bool IsAnimalExtinct(Animal animal)
        {
            List<Colony> speciesColonies = new();
            switch (animal)
            {
                case Lemming:
                    speciesColonies = this.colonies.FindAll(col => col.species is Lemming);
                    break;
                case Rabbit:
                    speciesColonies = this.colonies.FindAll(col => col.species is Rabbit);
                    break;
                case Moose:
                    speciesColonies = this.colonies.FindAll(col => col.species is Moose);
                    break;
                case Owl:
                    speciesColonies = this.colonies.FindAll(col => col.species is Owl);
                    break;
                case Fox:
                    speciesColonies = this.colonies.FindAll(col => col.species is Fox);
                    break;
                case Bear:
                    speciesColonies = this.colonies.FindAll(col => col.species is Bear);
                    break;

            }
            foreach (Colony colony in speciesColonies)
            {
                if (colony.population > 0)
                {
                    return false;
                }
            }

            return true;
        }
    }
}
