using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HF9
{
    public class Planet
    {
        public string name;
        private List<Starship> ships;

        public Planet(string name)
        {
            this.name = name;
            this.ships = new List<Starship>();
        }

        public void Defends(Starship s)
        {
            if(ships.Contains(s))
            {
                throw new Exception("Error!");
            }
            ships.Add(s);
        }

        public void Leaves(Starship s)
        {
            if (!ships.Contains(s))
            {
                throw new Exception("Error!");
            }
            ships.Remove(s);
        }

        public int ShipCount() => ships.Count;

        public int ShieldSum()
        {
            int sum = 0;
            for(int i = 0; i < ships.Count; i++)
            {
                sum += ships[i].GetShield();
            }

            return sum;
        }

        public (bool, float, Starship) MaxFireP()
        {
            Starship starship = new Starship("hajo", 0, 0 ,0);
            if (ships.Count == 0)
            {
                return (false, 0, starship);
            }
            float fp = 0;
            foreach(Starship s in ships)
            {
                if(s.FireP() > fp)
                {
                    fp = s.FireP();
                    starship = s;
                }
            }

            return(true, starship.FireP(), starship);
        }

    }
}
