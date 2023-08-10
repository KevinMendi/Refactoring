using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Refactoring.ComposingMethods.ReplaceTempWithQuery.refactored
{
    public class Refactored
    {
        //Remove Temporary variable

        public const int Quantity = 5;
        public const int ItemPrice = 300;


        public double GetAdjustedPrice()
        {
            return GetBasePrice() * GetDiscountFactor();
        }

        private double GetBasePrice()
        {
            return Quantity * ItemPrice;
        }

        private double GetDiscountFactor()
        {
            if (GetBasePrice() > 1000)
            {
                return 0.95;
            }
            else
            {
                return 0.98;
            }
        }
    }
}
