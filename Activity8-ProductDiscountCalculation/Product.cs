using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Activity8_ProductDiscountCalculation
{
    internal class Product
    {
        private decimal Price { get; set; }
        private decimal Discount { get; set; }

        public Product(decimal price, decimal discount)
        {
            Price = price;
            Discount = discount;
        }

        public decimal CalculateDiscountedPrice()
        {
            if (Discount < 0 || Discount > 100)
            {
                throw new ArgumentOutOfRangeException(nameof(Discount), "Discount must be between 0 and 100.");
            }
            decimal discountAmount = (Price * Discount) / 100;
            return Price - discountAmount;
        }        
    }
}
