using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOC.BadExample
{
   public  class Phone
    {
        public int Id { get; set; }
       
        public string SamsungModel { get; set; }
        public double amount { get; set; }
        public static double Discount(double discount)
        {
            return discount;
        }
        public  double  Price()
        {
            double result =amount * Phone.Discount(20);
            return result;
        }
      

    }
}
