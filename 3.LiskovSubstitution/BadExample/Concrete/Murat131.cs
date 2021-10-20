using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.LiskovSubstitution.BadExample.Concrete
{
    public class Murat131 : BaseCar
    {
        public override string CarRun()
        {
            return "Car Run ";
        }

        public override string OpenAirConditioning()
        {
            return null;
        }
    }
}
