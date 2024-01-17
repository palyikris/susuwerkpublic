using System;
using System.Collections.Generic;
using System.Data.Common;

class Program
{

    #region Adataim
    // név: Pályi Kristóf Ferenc
    // neptun-kód: Q9NL7W
    // email: q9nl7w@inf.elte.hu
    #endregion

    static void Main(string[] args)
    {

        #region Beolvasás
        int[,] adatok = Beolvas();
        int db;
        int[] helysegek;
        #endregion

        #region Feldolgozás
        (db, helysegek) = Kivalogat(adatok);
        #endregion

        #region Kiírás
        Kiir(db, helysegek);
        #endregion
    }
    static int[,] Beolvas()
    {
        if (Console.IsInputRedirected)
        {
            return Beolvas_biro();
        }
        else
        {
            return Beolvas_kezi();
        }
    }
    static int[,] Beolvas_biro()
    {

        string[] elsosor = Console.ReadLine().Split(" ");
        int faluk = int.Parse(elsosor[0]);
        int napok = int.Parse(elsosor[1]);
        int[,] adatok = new int[faluk, napok];
        for (int i = 0; i < faluk; i++)
        {
            string[] sor = Console.ReadLine().Split(" ");

            for (int j = 0; j < napok; j++)
            {
                adatok[i, j] = int.Parse(sor[j]);
            }
        }

        return adatok;
    }
    static int[,] Beolvas_kezi()
    {
        int n, m;
        bool jo;
        do
        {
            Console.ResetColor();
            Console.Write("Helységek száma = ");
            jo = int.TryParse(Console.ReadLine(), out n) && n >= 1 && n <= 1000;
            if (!jo)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Érvényes érték kell!");
            }
        } while (!jo);
        do
        {
            Console.ResetColor();
            Console.Write("Napok száma = ");
            jo = int.TryParse(Console.ReadLine(), out m) && m >= 1 && m <= 1000;
            if (!jo)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Érvényes érték kell!");
            }
        } while (!jo);

        int[,] adatok = new int[n, m];
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < m; j++)
            {
                do
                {
                    Console.ResetColor();
                    Console.Write("{0}. helyseg {1}. nap homerseklete: = ", i + 1, j + 1);
                    jo = int.TryParse(Console.ReadLine(), out adatok[i, j]) && adatok[i, j] >= -50 && adatok[i, j] <= 50;
                    if (!jo)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Érvényes érték kell!");
                    }
                } while (!jo);
            }
        }

        return adatok;
    }

    static (int db, int[] helysegek) Kivalogat(int[,] adatok)
    {
        int db = 0;
        int[] helysegek = new int[adatok.GetLength(0)];
        for (int i = 0; i < adatok.GetLength(0); i++)
        {
            int counter = 0;
            for (int j = 0; j < adatok.GetLength(1); j++)
            {
                if (adatok[i, j] <= 30)
                {
                    counter = 0;
                }
                else
                {
                    counter++;
                }
                if (counter >= 7)
                {
                    j = adatok.GetLength(1);
                }
            }
            if (counter >= 7)
            {
                db++;
                helysegek[i] = i + 1;
            }
        }
        return (db, helysegek);
    }

    static void Kiir(int db, int[] helysegek)
    {
        if (Console.IsInputRedirected)
        {
            Kiir_biro(db, helysegek);
        }
        else
        {
            Kiir_kezi(db, helysegek);
        }
    }

    static void Kiir_biro(int db, int[] helysegek)
    {
        Console.Write(db);
        for (int i = 0; i < helysegek.Length; i++)
        {
            if (helysegek[i] != 0)
            {
                Console.Write(" " + helysegek[i]);
            }
        }
    }

    static void Kiir_kezi(int db, int[] helysegek)
    {
        Console.WriteLine("A kiválogatás eredménye:");
        Console.WriteLine("Helységek száma: {0}", db);
        Console.Write("Helységek: ");
        for (int i = 0; i < helysegek.Length; i++)
        {
            if (helysegek[i] != 0)
            {
                Console.Write("{0} ", helysegek[i]);
            }
        }
    }
}