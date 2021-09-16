using System.IO;

namespace Operatorok
{
  partial class Program
  {
    static public void ElsoFeladat()
    {
      System.Console.WriteLine("1. feladat: adatok beolvasása");

      StreamReader be = new StreamReader("kifejezesek.txt");

      while (!be.EndOfStream)
      {
        string[] a = be.ReadLine().Split();

        szamolasok.Add(new Szamolas(
              int.Parse(a[0]), int.Parse(a[2]), a[1]
            )
          );
      }


      be.Close();
    }
  }
}