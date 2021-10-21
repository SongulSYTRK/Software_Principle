using _5_DependencyInversion.GoodExample.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_DependencyInversion.GoodExample.Concrete
{
    public class Tea : IDrinkMenu
    {
        public string GetTypeOfDrink() => "you choose tea";
       
    }
}
