using System;
using System.Collections.Generic;

class Program
{

    #region Adataim
    // név: Pályi Kristóf Ferenc
    // neptun-kód: Q9NL7W
    // email: q9nl7w@inf.elte.hu
    #endregion

    #region Deklaráció
    static List<List<int>>? Hom;
    static int db;
    static List<int>? sorsz;
    #endregion
    static bool HarmincFolottHetszer(int i)
    {
        int j = 0;
        if (Hom != null && Hom[i] != null && Hom[i].Count >= 6 && Hom[i][j] > 30 && Hom[i][j + 1] > 30 && Hom[i][j + 2] > 30 && Hom[i][j + 3] > 30 && Hom[i][j + 4] > 30 && Hom[i][j + 5] > 30 && Hom[i][j + 6] > 30)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
    static void Main(string[] args)
    {
        Hom = new();
        sorsz = new();

        #region Beolvasás
        string elsosor = Console.ReadLine() ?? "0";
        string[] elsosorLista = elsosor.Split(' ');
        int faluSzam = int.Parse(elsosorLista[0]);
        int napokSzam = int.Parse(elsosorLista[1]);


        for (int i = 0; i < faluSzam; i++)
        {
            string sor = Console.ReadLine() ?? "";
            string[] sorLista = sor.Split(' ');
            List<int> homok = new();
            for (int j = 0; j < sorLista.Length; j++)
            {
                int hom = int.Parse(sorLista[j]);
                homok.Add(hom);
            }
            Hom.Add(homok);
        }
        #endregion

        #region Feldolgozás
        for (int i = 0; i < Hom.Count; i++)
        {
            if (HarmincFolottHetszer(i))
            {
                db++;
                sorsz.Add(i + 1);
            }
        }
        #endregion

        #region Kiírás
        Console.Write(db + " ");
        for (int i = 0; i < sorsz.Count; i++)
        {
            Console.Write(sorsz[i] + " ");
        }
        #endregion
    }
}