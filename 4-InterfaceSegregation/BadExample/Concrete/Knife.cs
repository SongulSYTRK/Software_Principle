using _4_InterfaceSegregation.BadExample.Abstract;
using _4_InterfaceSegregation.BadExample.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_InterfaceSegregation.BadExample.Concrete
{
    public class Knife : Gun, IWounding_Killing
    {
        public string CutOff()
        {
            return "he\she cut off  ";

        }

        public string Fire()
        {
            throw new NotImplementedException();
            // knife dont have fire
        }

        public string Hit()
        {
            return "He\she hit times  ";
        }
    }
}
