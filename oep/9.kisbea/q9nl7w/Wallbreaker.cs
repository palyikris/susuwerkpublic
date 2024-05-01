using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HF9
{
    public class Wallbreaker : Starship
    {
        private string name;

        public Wallbreaker(string name, int shield, int armor, int guardian) : base(name, shield, armor, guardian)
        {
            this.name = name;
        }

        public override float FireP()
        {
            return armor / 2f;
        }
    }
}
