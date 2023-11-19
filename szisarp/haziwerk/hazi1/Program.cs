using System;

namespace Hazi1
{
    class hazi1
    {
        public static void Main(string[] args)
        {
            // !---------------------------------------------------------------------
            // todo: Poker Task 3

            //todo: Spec:
            /*
            
                Be: x eleme Z+, lista eleme Z+(1..x)
                Ki: y eleme Z+
                Ef: -
                Uf: y = MIN(i = 1..x, lista[i])

            */
            int[] players = new int[5];

            for (int i = 0; i < players.Length; i++)
            {
                int.TryParse(Console.ReadLine(), out players[i]);
            }

            int playerNum = 0;

            for (int i = 0; i < players.Length; i++)
            {
                if (players[i] == 1)
                {
                    playerNum = i + 1;
                }
            }

            Console.WriteLine($"A változó száma: {playerNum}");

            // ! ---------------------------------------------------------------------
            // todo: Traffic Task 7

            // todo: Spec
            /*
            
                Be: x eleme Z+, lista eleme Z+(1..x)
                Ki: y eleme R+
                Ef: -
                Uf: y = SZUM(i = 1..n, lista[i], lista[i]>0) / HOSSZ(i = 1..n, lista[i], lista[i]>0)
                            
            */

            int[] costumers = { 5, 8, 12, 14, 6, 0, 0, 9, 10 };

            int days = 0;
            int daysNum = 0;

            for (int i = 0; i < costumers.Length; i++)
            {
                if (costumers[i] == 0)
                {
                    continue;
                }
                else
                {
                    days += costumers[i];
                    daysNum++;
                }
            }

            int avg = days / daysNum;

            Console.WriteLine($"A napi átlag vásárlók száma: {avg}");


            // ! ---------------------------------------------------------------------
            // todo: Casino Task 8

            // todo: Spec
            /*
            
                Be: x eleme N, lista eleme N(1..x)
                Ki: y eleme N
                Ef: -
                Uf: y = MIN(i = 1..n, lista[i])
                            
            */

            int[] wins = { 500, -200, 600, 0, 1000 };

            int low = wins[0];
            int lowest = wins[0];

            for (int i = 0; i < wins.Length; i++)
            {
                if (low > wins[i])
                {
                    low = wins[i];
                }
                if (low < lowest)
                {
                    lowest = low;
                }
            }

            Console.WriteLine($"A legkisebb nyeremény mértéke: {lowest}");
        }
    }
}