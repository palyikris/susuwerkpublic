using System;
using System.Collections.Generic;

namespace Beadando_1
{
    class Program
    {
        static void Main(string[] args)
        {

            #region Adataim
            // név: Pályi Kristóf Ferenc
            // neptun-kód: Q9NL7W
            // email: q9nl7w@inf.elte.hu
            #endregion


            #region Deklaráció
            List<List<int>> beMeresek = new(); // prompt: lista amiben a napi meresek lesznek
            int ki = 0; // prompt: a valtozo amiben tarolom a feladat kimenetet
            #endregion


            #region Beolvasás
            string beNapokString = Console.ReadLine() ?? "0";
            // prompt: string-ként beolvasom, hogy hány nap lesz, vagy ha nincs input legyen 0 --> nem fut le
            int beNapok = int.Parse(beNapokString);
            // prompt: int-é alakítom a felhasználótól kapott stringet, hogy lehessen vele dolgozni
            for (int i = 0; i < beNapok; i++)
            {
                string MeresekString = Console.ReadLine() ?? "0 0";
                // prompt: beolvasom a napi reggeli és esti méréseket
                string[] MeresekSplit = MeresekString.Split(' ');
                // prompt: a spacenél szétválasztom a két értéket, hogy tudjak velük dolgozni
                List<int> Meresek = new(); // prompt: ideiglenes lista, amiben lesz a reggeli meg az esti mérés
                for (int j = 0; j < MeresekSplit.Length; j++)
                {
                    // prompt: végigmegyek a méréseken, amik még stringek
                    // prompt: int-é alakítom őket, és berakom a mérések listába
                    Meresek.Add(int.Parse(MeresekSplit[j]));
                }
                // prompt: a mérések listát meg berakom a fő bemeneti listámba, ahol majd feldolgozom őket
                beMeresek.Add(Meresek);
            }
            #endregion


            #region Feldolgozás
            // prompt: végig megyek a beMérések elemein
            for (int k = 1; k < beMeresek.Count; k++)
            {
                // prompt: megnézem, hogy mely napok esetén nagyobb a reggeli és az esti mérés, mint az előtte lévő
                if (beMeresek[k][0] > beMeresek[k - 1][0] && beMeresek[k][1] > beMeresek[k - 1][1])
                {
                    // prompt: ha van ilyen, megnövelem a kimeneti értéket
                    ki++;
                }
            }
            #endregion

            #region Kiírás
            // prompt: kiírom a végeredményt
            Console.WriteLine(ki);
            #endregion
        }
    }
}