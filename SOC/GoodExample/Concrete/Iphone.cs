using SOC.GoodExample.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOC.GoodExample.Concrete
{
    public class Iphone : BasePhone
    {
        public override double Price()
        {
            return Amount * Utility.Discount(30);
        }
    }
}
