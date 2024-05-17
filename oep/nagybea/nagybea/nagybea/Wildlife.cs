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
            
            if(this.round % 2 == 0)
            {
                foreach(Colony colony in this.colonies)
                {
                    if(colony.species is Lemming)
                    {
                        colony.Reproduction();
                    }
                    if(colony.species is Rabbit)
                    {
                        colony.Reproduction();
                    }
                }
            }

            if (this.round % 3 == 0)
            {
                foreach (Colony colony in this.colonies)
                {
                    if (colony.species is Owl)
                    {
                        colony.Reproduction();
                    }
                    if (colony.species is Fox)
                    {
                        colony.Reproduction();
                    }
                }
            }


            if (this.round % 4 == 0)
            {
                foreach (Colony colony in this.colonies)
                {
                    if (colony.species is Moose)
                    {
                        colony.Reproduction();
                    }
                }
            }

            if (this.round % 8 == 0)
            {
                foreach (Colony colony in this.colonies)
                {
                    if (colony.species is Bear)
                    {
                        colony.Reproduction();
                    }
                }
            }
            foreach(Colony colony in this.colonies)
            {
                if(colony.species is Carnivore)
                {
                    Random random = new Random();
                    List<Colony> preys = colonies.FindAll(colony => colony.species is Prey);
                    int randomIndex = random.Next(0, preys.Count);
                    colony.Attack(preys[randomIndex]);
                }
            }
        }
    }
}
