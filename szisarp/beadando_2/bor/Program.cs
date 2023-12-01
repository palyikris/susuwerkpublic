using System;
using System.Collections.Generic;

class Program
{


    class Meres // prompt: class a meresek tarolasahoz
    {
        public int Mennyiseg { get; set; }
        public int Ar { get; set; }
    }
    static void Main(string[] args)
    {

        #region Adataim
        // név: Pályi Kristóf Ferenc
        // neptun-kód: Q9NL7W
        // email: q9nl7w@inf.elte.hu
        #endregion



        #region Deklaráció
        List<decimal> arakRec = new(); // prompt: lista amiben a borok arai lesznek reciprokkent
        int ki; // prompt: valtozo amiben tarolom majd a feladat kimenetet
        List<Meres> Meresek = new();
        #endregion


        #region Beolvasás
        string evek = Console.ReadLine() ?? "0";  // prompt: beolvasom, hogy hány év lesz, vagy ha nincs input legyen 0 --> nem fut le
        int evekSzam = int.Parse(evek);

        for (int i = 0; i < evekSzam; i++)
        {
            string sor = Console.ReadLine() ?? "";
            // prompt: beolvasom a borok adatait
            string[] sorLista = sor.Split(' ');
            int Mennyiseg = int.Parse(sorLista[0]);
            int Ar = int.Parse(sorLista[1]);
            // prompt: a spacenél szétválasztom a két értéket, hogy tudjak velük dolgozni
            Meres meres = new()
            {
                Mennyiseg = Mennyiseg,
                Ar = Ar
            };
            Meresek.Add(meres);
            // prompt: a meres classt berakom a meresekbe
        }
        #endregion

        #region Feldolgozás

        for (int i = 0; i < Meresek.Count; i++)
        {
            int hanyszor = Hanyszor(Meresek[i].Ar, Meresek);
            decimal rec = 1m / hanyszor;
            arakRec.Add(rec);
            // idea: bemasolom az arakRec listaba az elemeket 
            // idea: osztva annyival ahanyszor benne vannak a listaban
        }

        decimal ossz = 0m;
        for (int i = 0; i < arakRec.Count; i++)
        {
            ossz += arakRec[i];
        }
        // prompt: osszeadom az arakRec elemeit

        ki = (int)Math.Round(ossz);
        // prompt: kerekitjuk az osszeget es berakjuk a ki-be
        #endregion

        #region Kiírás
        Console.WriteLine(ki);
        #endregion
    }

    static int Hanyszor(int elem, List<Meres> lista)
    {
        int hanyszor = 0;
        for (int i = 0; i < lista.Count; i++)
        {
            if (lista[i].Ar == elem)
            {
                hanyszor++;
            }
        }
        // prompt: megszamolom, hogy hanyszor van benne az adott elem van a listaban
        return hanyszor;
    }
}
