using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace Operatorok
{
  partial class Program
  {
    static public void HarmadikFeladat()
    {
      int szamlalo = 0;
 
      foreach (var l in szamolasok)
      {
        if (l.Muvelet.Contains("mod"))
        {
          szamlalo++;
        }
      }
      Console.WriteLine($"3. Feladat: Kifejezések maradékos osztással:   {szamlalo}");







      //  ez ratyi 
      //     |
      //     V

      /*
      int szamolo = 0;
      string sor;
      var text = "mod";
      //StreamReader file = new StreamReader("kifejezesek.txt");




      int i = 0;

      while ((sor = szamolasok.()) != null)
        {

          if (sor.Contains(text))
          {
          szamolo++;
     //   Console.WriteLine($"{sor}");    // <-- Metódus összeségében 
        }
        
        }

          Console.WriteLine($"3. Feladat: Kifejezések maradékos osztással:   {szamolo}");
     */
    }
  }
}