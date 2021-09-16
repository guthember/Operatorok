using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operatorok
{
  partial class Program
  {
    static List<Szamolas> szamolasok = new List<Szamolas>();
    static void Main(string[] args)
    {
      ElsoFeladat();
      MasodikFeladat();
      HarmadikFeladat();
      NegyedikFeladat();
      OtodikFeladat();
      HatodikFeladat();
      HetedikFeladat();
      NyolcadikFeladat();

      Console.Write("\nProgram vége...");
      Console.ReadKey();
    }
  }
}
