using System;
using System.Collections.Generic;

class Program
{
    // prompt: letrehozok egy Book nevo class-t
    class Book
    {
        public string Szerzo { get; set; }
        public string Cim { get; set; }
        public int Konyvtarban { get; set; }
        public int Kolcsonozve { get; set; }
        // prompt: a feladat szerint meghatarozom, hogy milyen elemei legyenek  
    }
    static void Main(string[] args)
    {
        #region Deklarálás
        string konyvSzam = Console.ReadLine() ?? "0";
        int konyvSzamInt = int.Parse(konyvSzam);
        // prompt: beolvasom, hogy hany konyv lesz, majd intet csinalok belole

        while (konyvSzamInt < 1 || konyvSzamInt > 100)
        {
            // prompt: ellenorzom az elofeltetelt 
            // prompt: es ujra bekerem ha nem teljesiti a felteteleket
            Console.WriteLine("Hibas bemenet!");
            konyvSzam = Console.ReadLine() ?? "0";
            konyvSzamInt = int.Parse(konyvSzam);
        }
        int ki = 0;
        // prompt: kell egy valtozo a valid konyvek szamanak
        List<int> kiLista = new();
        // prompt: kell egy lista a valid konyvek indexenek
        List<Book> konyvek = new();
        // prompt: kell egy lista, amiben a beolvasott konyvek lesznek
        #endregion

        #region Beolvasás
        for (int i = 0; i < konyvSzamInt; i++)
        {
            string sor = Console.ReadLine() ?? "a,t,0,0";
            string[] adatok = sor.Split(';');
            int konyvtarban = int.Parse(adatok[2]);
            int kikolcsonzott = int.Parse(adatok[3]);
            while (konyvtarban < 0 || kikolcsonzott < 0 || konyvtarban > 100 || kikolcsonzott > 100 || konyvtarban < kikolcsonzott)
            {
                // prompt: ellenorzom az elofeltetelt 
                // prompt: es ujra bekerem ha nem teljesiti a felteteleket
                Console.WriteLine("Hibas bemenet!");
                sor = Console.ReadLine() ?? "a,t,0,0";
                adatok = sor.Split(';');
                konyvtarban = int.Parse(adatok[2]);
                kikolcsonzott = int.Parse(adatok[3]);
            }
            // prompt: beolvasok egy sort es feldarabolom ; menten
            Book konyv = new Book();
            konyv.Szerzo = adatok[0];
            konyv.Cim = adatok[1];
            konyv.Konyvtarban = konyvtarban;
            konyv.Kolcsonozve = kikolcsonzott;
            // prompt: letrehozok egy Book classt es abba belepakolom az adatokat
            konyvek.Add(konyv);
            // prompt: az igy elkeszult konyvet hozzaadom a konyvek listajahoz
        }
        #endregion

        #region Feldolgozás
        for (int i = 0; i < konyvSzamInt; i++)
        {
            // prompt: vegigmegyek a konyvek listajan
            if (konyvek[i].Konyvtarban - konyvek[i].Kolcsonozve <= 2)
            {
                // idea: ha a kikolcsonzott konyvek szama levonva az osszesbol kisebb v egyenlo 2vel
                ki++;
                kiLista.Add(i);
                // prompt: novelem a valtozot ami szamon tartja hany ilyen konyv van
                // prompt: belerakom a konyv sorszamat a listaba, ami szamon tartja az ilyen konyvek sorszamait
            }
        }
        #endregion

        #region Kiírás
        Console.Write(ki);
        // prompt: kiirom hany ilyen konyv volt
        for (int i = 0; i < kiLista.Count; i++)
        {
            int sorszam = kiLista[i] + 1;
            // idea: emberi sorszamma alakitom az eltarolt sorszamot
            Console.Write(" " + sorszam);
            // prompt: space-cel elvalasztva kiirom
        }
        #endregion

    }
}


