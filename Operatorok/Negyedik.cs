using System;

namespace Operatorok
{
  partial class Program
  {
    static public void NegyedikFeladat()
    {
      System.Console.Write("4.feladat: ");
      #region Jozsi megoldása
      //bool vane = false;
      //foreach (var sz in szamolasok)
      //{
      //  if (sz.Op1 % 10 == 0 && sz.Op2 % 10 == 0)
      //  {
      //    vane = true;

      //  }
      //  if (vane)
      //  {
      //    break;
      //  }
      //}
      //if (vane)
      //{
      //  System.Console.WriteLine("Van olyan kifejezés!");
      //}
      //else
      //{
      //  System.Console.WriteLine("Nincs olyan kifejezés!");
      //} 
      #endregion

      int i = 0;

      while (i < szamolasok.Count && !(szamolasok[i].Op1 % 10 == 0 && szamolasok[i].Op2 % 10 ==0))
      {
        i++;
      }

      if (i < szamolasok.Count)
      {
        Console.WriteLine("Van ilyen kifejezés!");
      }
      else
      {
        Console.WriteLine("Nincs ilyen kifejezés!");
      }
    }
  }
}