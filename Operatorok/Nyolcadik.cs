using System;
using System.IO;

namespace Operatorok
{
  partial class Program
  {
    static public void NyolcadikFeladat()
    {
      Console.Write("\n8. feladat: ");

      string muvjelek = "+-*/moddiv";
      string osztas = "/moddiv";

      StreamWriter ki = new StreamWriter("eredmenyek.txt");

      foreach (var sz in szamolasok)
      {
        string kiirni = sz.Kiir();
        if (muvjelek.Contains(sz.Muvelet))
        {
          if (osztas.Contains(sz.Muvelet) && sz.Op2 == 0)
          {
            kiirni += "Egyéb hiba!";
          }
          else
          {
            kiirni += sz.Szamol();
          }
        }
        else
        {
          kiirni += "Hibás operátor!";
        }
        ki.WriteLine(kiirni);
      }

      ki.Close();

      Console.WriteLine("eredmenyek.txt");
    }
  }
}