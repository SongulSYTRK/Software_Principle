using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DRY_Principle.GoodExample
{
   public  class GoodCheckout
    {
        public double GetUserCredit()
        {
            var userCredit = 125;

            
            return Utility.GetUserCredit(userCredit);
        }
    }
}
