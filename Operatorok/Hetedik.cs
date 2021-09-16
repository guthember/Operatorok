using System;
using System.Collections.Generic;

namespace Operatorok
{
  partial class Program
    {
        static public void HetedikFeladat()
    {
            bool ujra = true;
            do
            {
                Console.Write("7. feladat: Kérek egy kifejezést (pl.: 1 + 1): ");
                string egesz = Console.ReadLine();
                string[] darabol = egesz.Split();
                string elso = darabol[0];
                string muveletek = "";
                try
                {
                    muveletek = darabol[1];
                }
                catch (Exception)
                {
                    break;
                }
                string masodik = darabol[2];
                double eredmeny = 0;
                int stringSzam = 0;
                stringSzam = muveletek.Length;
                if (muveletek == "+")
                {
                    eredmeny = double.Parse(elso) + double.Parse(masodik);
                    Console.WriteLine($"\t{elso} {muveletek} {masodik} = {eredmeny}");
                    ujra = true;
                }
                else if (muveletek == "-")
                {
                    eredmeny = double.Parse(elso) - double.Parse(masodik);
                    Console.WriteLine($"\t{elso} {muveletek} {masodik} = {eredmeny}");
                    ujra = true;
                }
                else if (muveletek == "/")
                {
                    eredmeny = double.Parse(elso) / double.Parse(masodik);
                    Console.WriteLine($"\t{elso} {muveletek} {masodik} = {eredmeny}");
                    ujra = true;
                }
                else if (muveletek == "*")
                {
                    eredmeny = double.Parse(elso) * double.Parse(masodik);
                    Console.WriteLine($"\t{elso} {muveletek} {masodik} = {eredmeny}");
                    ujra = true;
                }
                else if (stringSzam > 1)
                {
                    Console.WriteLine($"\t{elso} {muveletek} {masodik} = Egyéb hiba!");
                    ujra = true;
                }
                else
                {
                    Console.WriteLine($"\t{elso} {muveletek} {masodik} = Hibás operátor!");
                    ujra = true;
                }
                if (elso == "vége")
                {
                    ujra = false;
                }
            } while (ujra);
            }
        }
  }
