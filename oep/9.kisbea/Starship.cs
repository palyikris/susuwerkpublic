using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HF9
{
    public class Starship
    {
        private string name;
        protected int shield;
        protected int armor;
        protected int guardian;
        private Planet planet;

        public Starship(string name, int shield, int armor, int guardian) {
            this.name = name;
            this.shield = shield;
            this.armor = armor;
            this.guardian = guardian;
        }

        public int GetShield()
        {
            return shield;
        }

        public void StaysAtPlanet(Planet p)
        {
            if(p != null)
            {
                planet.Leaves(this);
            }
            planet = p;
            planet.Defends(this);
        }

        public void LeavesPlanet()
        {
            if (planet == null)
            {
                throw new Exception("Error!");
            }
            planet.Leaves(this);
            planet = null;
        }

        public virtual float FireP()
        {
            return 0;
        }
    }
}
