namespace Operatorok
{
  partial class Program
  {
    static public void NegyedikFeladat()
    {
      System.Console.Write("4.feladat: ");
      bool vane = false;
      foreach (var sz in szamolasok)
      {
        if (sz.Op1 % 10 == 0 && sz.Op2 % 10 == 0)
        {
          vane = true;
          
        }
        if (vane)
        {
          break;
        }
      }
      if (vane)
      {
        System.Console.WriteLine("Van olyan kifejezés!");
      }
      else
      {
        System.Console.WriteLine("Nincs olyan kifejezés!");
      }
    }
  }
}