using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_DependencyInversion.BadExample
{
   public  class CafeMenu
    {
        TypeOfCoffe typeOfCoffe = new TypeOfCoffe();
        TypeOfTea typeOfTea = new TypeOfTea();

        public string GetCafeMenu() => $"{typeOfCoffe} || {typeOfTea}";
    }
}
