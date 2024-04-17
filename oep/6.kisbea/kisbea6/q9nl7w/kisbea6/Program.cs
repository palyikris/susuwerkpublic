using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;

namespace kisbea6
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Szamla> receipts = new List<Szamla>();
            using (StreamReader sr = new StreamReader(args[0]))
            {
                string? line;
                while ((line = sr.ReadLine()) != null)
                {
                    string[] dataList = line.Split(' ');
                    Szamla receipt = new Szamla(dataList, (dataList.Length - 1) / 2);
                    receipts.Add(receipt);
                }
            }
            int sum = 0;
            foreach (Szamla szamla in receipts)
            {
               sum += szamla.GetOssz();
            }
            Console.WriteLine(sum);
        }
    }
}