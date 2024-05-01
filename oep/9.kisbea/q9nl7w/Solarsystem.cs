using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HF9
{
    public class Solarsystem
    {
        public List<Planet> planets;

        public Solarsystem()
        {
            this.planets = new List<Planet>();
        }

        public (bool, Starship) MaxFireP()
        {
            Starship starship = new Starship("hajo", 0, 0, 0);
            if (planets.Count == 0)
            {
                return (false, starship);
            }
            float maxfp = 0;
            foreach (Planet p in planets)
            {
                (bool found, float fp, Starship s) = p.MaxFireP();
                if (found)
                {
                    if (fp > maxfp)
                    {
                        maxfp = fp;
                        starship = s;
                    }
                }
                
            }

            return (true, starship);
        }

        public List<Planet> Defenseless()
        {
            List <Planet> defenseless = new List<Planet>();
            foreach (Planet p in planets)
            {
                if(p.ShipCount() == 0)
                {
                    defenseless.Add(p);
                }
            }

            return defenseless;
        }
    }
}
