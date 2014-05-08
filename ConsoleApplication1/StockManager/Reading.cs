using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StockManager
{
    public class Reading : StoreItem 
    {
        const decimal TAX_RATE = 1.07m;
        public override decimal TaxRate { get { return TAX_RATE; } }
       
        private decimal litPrice;
        public decimal LitPrice { get { return litPrice; } }

        const string DEPARTMENT_NAME = "Reading";
        const int    FLOOR_NUMBER =1;
     
        
        public Reading(decimal price) 
           : base(DEPARTMENT_NAME, FLOOR_NUMBER,price)
        {
            litPrice = price;
        }
        public override decimal GetPriceAfterTax()
        {
            return TAX_RATE * litPrice;
        }
        public override void DisplayItemInformation()
        {
            base.DisplayItemInformation();
            Console.WriteLine("Price with taxes: {0}",
                    GetPriceAfterTax().ToString("N2"));
         
        }
    }
}
