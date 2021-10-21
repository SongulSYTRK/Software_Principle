using _5_DependencyInversion.GoodExample.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_DependencyInversion.GoodExample.Concrete
{
   public  class CoffeMenu
    {
        private IDrinkMenu _Idrinkmenu;
        public CoffeMenu(IDrinkMenu Idrinkmenu)
        {
            this._Idrinkmenu = Idrinkmenu;
        }
        public string GetCafeMenu() => $"{_Idrinkmenu.GetTypeOfDrink()}";

    }
}
