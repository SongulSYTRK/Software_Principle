using _2_OperClosed.GoodExample.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_OperClosed.GoodExample.Concrete
{
    public class History_Book : BaseBook
    {
        public override string ChooseGenre() => "you choose History"; 
        
    }
}
