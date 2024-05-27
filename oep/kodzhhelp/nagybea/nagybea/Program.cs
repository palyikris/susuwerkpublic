using nagybea;
using System;

namespace nagybea
{
    class Program
    {
        static void Main()
        {
            Wildlife wl = new Wildlife();
            string nOfCols = Console.ReadLine();
            string[] nOfColsList = nOfCols.Split(" ");
            int nOfPreys = int.Parse(nOfColsList[0]);
            int nOfCars = int.Parse(nOfColsList[1]);
            
        }
    }
}
