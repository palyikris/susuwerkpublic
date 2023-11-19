using System;
using System.Collections.Generic;

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
        List<int> arak = new(); // prompt: lista amiben a borok arai lesznek
        int ki; // prompt: valtozo amiben tarolom majd a feladat kimenetet
        #endregion



        #region Beolvasás és feldolgozás
        string evek = Console.ReadLine() ?? "0";  // prompt: beolvasom, hogy hány év lesz, vagy ha nincs input legyen 0 --> nem fut le
        int evekSzam = int.Parse(evek);

        for (int i = 0; i < evekSzam; i++)
        {
            string sor = Console.ReadLine() ?? "";
            // prompt: beolvasom a borok adatait
            string[] adatok = sor.Split(' ');
            string ar = adatok[1];
            // prompt: a spacenél szétválasztom a két értéket, hogy tudjak velük dolgozni és kiválasztom az árat
            int arSzam = int.Parse(ar);

            if (arak.Contains(arSzam)) // idea: ha már volt ilyen ár, akkor növelem a kiSegedet
            {
                continue;
            }
            else
            {
                // prompt: ha még nem volt ilyen ár, akkor hozzáadom az árak listájához
                arak.Add(arSzam);
            }

        }

        ki = arak.Count;
        // prompt: a kimenetem hogy hányféle áron árulnak bort
        #endregion

        #region Kiírás
        // prompt: kiíratom a kimenetet
        Console.WriteLine(ki);
        #endregion

    }
}
