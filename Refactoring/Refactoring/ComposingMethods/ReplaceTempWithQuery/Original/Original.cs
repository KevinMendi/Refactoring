using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Refactoring.ComposingMethods.ReplaceTempWithQuery.original
{
    public class Original
    {
        public const int Quantity = 5;
        public const int ItemPrice = 300;


        public double GetAdjustedPrice()
        {
            var basePrice = Quantity * ItemPrice;
            var discountFactor = 0.0;
            if(basePrice > 1000)
            {
                discountFactor = 0.95;
            }
            else
            {
                discountFactor = 0.98;
            }

            return basePrice * discountFactor;
        }
    }
}
