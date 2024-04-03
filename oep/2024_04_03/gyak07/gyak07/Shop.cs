using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gyak07
{
    public class Shop
    {
        public Department food;
        public Department electronics;

        public Shop()
        {
            food = new Department();
            electronics = new Department();
        }
    }
}
