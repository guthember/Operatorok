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
    {      Dictionary<string, int> dic = new Dictionary<string, int>()
      {
        {"mod", 0 },
        {"/", 0 },
        {"div", 0 },
        {"-", 0 },
        {"*", 0 },
        {"+", 0 }
      };
      foreach (var ss in szamolasok)
      {
        if (dic.ContainsKey(ss.Muvelet))
        {
          //string valami = ss.Muvelet;
          //dic[valami]++;
          dic[ss.Muvelet]++;
        }
      }
      Console.WriteLine("5. feladat: Statisztika");
      foreach (var sz in dic)
      {
        Console.WriteLine($"{sz.Key.PadLeft(10)} -> {sz.Value} db");
      }
    }
   }
 }