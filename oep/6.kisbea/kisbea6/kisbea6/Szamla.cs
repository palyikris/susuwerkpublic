using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kisbea6
{
    public class Szamla
    {
        private string name;
        private string[] data;
        private int[] prices;

        public Szamla(string[] dataList, int ps)
        {
            name = dataList[0];
            data = new string[ps];
            prices = new int[ps];

            for (int i = 0; i < ps; i++)
            {
                prices[i] = Convert.ToInt32(dataList[i * 2 + 2]);
            }
        }

        public int GetOssz()
        {
            return prices.Sum();
        }

    }
}
