using _3.LiskovSubstitution.GoodExample.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.LiskovSubstitution.GoodExample.Concrete
{
    public class Murat131 : BaseEntity
    {
        public override string CarRun()
        {
            return "CAR RUN! ";
        }
    }
}
