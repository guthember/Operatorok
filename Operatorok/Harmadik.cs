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

      int szamolo = 0;
      string sor;
      var text = "mod";
StreamReader file = new StreamReader("kifejezesek.txt");

      while ((sor = file.ReadLine()) != null)
        {

          if (sor.Contains(text))
          {
          szamolo++;
     //   Console.WriteLine($"{sor}");    // <-- Metódus összeségében 
        }
        
        }

          Console.WriteLine($"3. Feladat: Kifejezések maradékos osztással:   {szamolo}");
      
    }
  }
}