using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LV5
{
    class ShippingServise 
    {
        private double unitPrice;

        public ShippingServise(double unitPrice)
        {
            this.unitPrice = unitPrice;
        }

        public double UnitPrice { get { return this.unitPrice; } }

        public double DeliveryPrice(double weight, double unitPrice)
        {
            return weight * unitPrice;             
        }
    }
}
