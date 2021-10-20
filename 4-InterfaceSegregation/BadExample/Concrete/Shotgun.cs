using _4_InterfaceSegregation.BadExample.Abstract;
using _4_InterfaceSegregation.BadExample.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_InterfaceSegregation.BadExample.Concrete
{
    public class Shotgun : Gun, IWounding_Killing
    {
        public string CutOff()
        {
            throw new NotImplementedException();
            //dont have this method 
        }

        public string Fire()
        {
            return "it hasfire ";
        }

        public string Hit()
        {
            return "it can be hit more time ";
        }
    }
}
