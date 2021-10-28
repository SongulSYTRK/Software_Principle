using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DRY_Principle.GoodExample
{
  public   class GoodCart
    {
        public double GetUserCredit()
        {
            var userCredit = 25;

            
            return Utility.GetUserCredit(userCredit);
        }
    }
}
