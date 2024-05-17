using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nagybea
{
    public class Animal
    {
        public Animal() 
        {

        }
        
        public virtual int Reproduce(int pop)
        {
            return 0;
        }

        public (int, int) Hunt(Colony _, Colony __)
        {
            return (0, 0);
        }
    }
}
