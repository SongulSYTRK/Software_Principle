using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOC.GoodExample.Abstract
{
    public abstract class BasePhone
    {
        public int Id { get; set; }
        public string  model { get; set; }
        public double Amount  { get; set; }
        public abstract double Price();
       

    }
}
