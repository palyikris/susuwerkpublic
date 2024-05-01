using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HF9
{
    public class Landingship : Starship
    {
        private string name;

        public Landingship(string name, int shield, int armor, int guardian) : base(name, shield, armor, guardian)
        {
            this.name = name;
        }

        public override float FireP()
        {
            return guardian;
        }
    }
}
