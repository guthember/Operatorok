using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Operatorok
{
  partial class Program
  {
    static public void OtodikFeladat()
    {
      Dictionary<string, int> szamolas = new Dictionary<string, int>()
      {
        {"mod", 349 },
        {"/", 336 },
        {"div", 340 },
        {"-", 318 },
        {"*", 297 },
        {"+", 320 }
      };
      Console.WriteLine("5. feladat: Statisztika");
      foreach (var sz in szamolas)
      {
        Console.WriteLine($"{sz.Key.PadLeft(10)} -> {sz.Value} db");
      }
      Console.ReadLine();
    }
   }
 }