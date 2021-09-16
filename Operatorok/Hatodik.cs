using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operatorok
{
  partial class Program
  {
    static public void HatodikFeladat()
    {
      string[] tomb = new string[] 
      { "mod", "/", "div", "-", "*", "+" };
      foreach (var sz in szamolasok)
      {
        if (tomb.Contains(sz.Muvelet))
        {
          if (sz.Muvelet == tomb[0])
          {
            try
            {
              int atmeneti = 0;
              atmeneti = sz.Op1 % sz.Op2;
            }
            catch (InvalidOperationException)
            {
              Console.WriteLine("Egyéb hiba!");
              throw;
            }
          }
          if (sz.Muvelet == tomb[1])
          {
            try
            {
              int atmeneti = 0;
              atmeneti = sz.Op1 / sz.Op2;
            }
            catch (InvalidOperationException)
            {
              Console.WriteLine("Egyéb hiba!");
              throw;
            }
          }
          if (sz.Muvelet == tomb[2])
          {
            try
            {
              int atmeneti = 0;
              atmeneti = sz.Op1 / sz.Op2;
            }
            catch (InvalidOperationException)
            {
              Console.WriteLine("Egyéb hiba!");
              throw;
            }
          }
          if (sz.Muvelet == tomb[3])
          {
            try
            {
              int atmeneti = 0;
              atmeneti = sz.Op1 - sz.Op2;
            }
            catch (InvalidOperationException)
            {
              Console.WriteLine("Egyéb hiba!");
              throw;
            }
          }
          if (sz.Muvelet == tomb[4])
          {
            try
            {
              int atmeneti = 0;
              atmeneti = sz.Op1 * sz.Op2;
            }
            catch(InvalidOperationException)
            {
              Console.WriteLine("Egyéb hiba!");
              throw;
            }
          }
          if (sz.Muvelet == tomb[5])
          {
            try
            {
              int atmeneti = 0;
              atmeneti = sz.Op1 + sz.Op2;
            }
            catch (InvalidOperationException)
            {
              Console.WriteLine("Egyéb hiba!");
              throw;
            }
          }
        }
        else
        {
          Console.WriteLine("Hibás operátor!");
          break;
        }
      }
    }
  }
}