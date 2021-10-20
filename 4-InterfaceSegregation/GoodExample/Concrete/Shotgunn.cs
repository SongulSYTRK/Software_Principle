using _4_InterfaceSegregation.BadExample.Abstract;
using _4_InterfaceSegregation.GoodExample.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_InterfaceSegregation.BadExample.Concrete
{
    public class Shotgunn : Gunn, IFire , IHit
    {
        public string Fire() => "it can be fire ";
       

        public string Hit()=> "it can be hit more time ";
        
    }
}
