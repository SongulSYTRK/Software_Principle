using _4_InterfaceSegregation.BadExample.Abstract;
using _4_InterfaceSegregation.GoodExample.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_InterfaceSegregation.BadExample.Concrete
{
    public class Knifee : Gunn, ICutOff , IHit
    {
        public string CutOff()
        {
            return "it can be cutOff";
        }

        public string Hit()
        {
            return "it can be hit more time ";
        }
    }
}
