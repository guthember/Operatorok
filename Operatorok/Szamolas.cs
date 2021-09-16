using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operatorok
{
  class Szamolas
  {
    //-------- ezen ne változtass ettől --------------
    private int op1;

    public int Op1
    {
      get { return op1; }
      set { op1 = value; }
    }

    private int op2;

    public int Op2
    {
      get { return op2; }
      set { op2 = value; }
    }

    private string muvelet;

    public string Muvelet
    {
      get { return muvelet; }
      set { muvelet = value; }
    }

    public Szamolas(int op1, int op2, string muvelet)
    {
      this.op1 = op1;
      this.op2 = op2;
      this.muvelet = muvelet;
    }
    //-------- ezen ne változtass eddig--------------
    
  }
}
