using _3.LiskovSubstitution.GoodExample.Abstract;
using _3.LiskovSubstitution.GoodExample.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.LiskovSubstitution.GoodExample.Concrete
{
    public class Ferrari : BaseEntity, IAirCondition
    {
        public override string CarRun()
        {
            return "Car Run!";
        }

        public string OpenAirConditioning()
        {
            return "AirCondition Run!";
        }
    }
}
