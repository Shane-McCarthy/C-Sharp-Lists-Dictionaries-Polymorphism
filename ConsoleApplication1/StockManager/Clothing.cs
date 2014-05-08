using System;

namespace StockManager
{
    sealed public class Clothing: StoreItem
    {
        const  decimal          TAX_RATE = 1.14m;
        public override decimal TaxRate { get { return TAX_RATE; } }

        private string itemName;
        public  string ItemName { get { return itemName;  } }

        private string brand;
        public string Brand { get { return brand; } }

        const string DEPARTMENT_NAME = "Clothing";
        const int    FLOOR_NUMBER = 2;

        public Clothing(string name, string brandName, decimal clothingPrice) 
            : base(DEPARTMENT_NAME, FLOOR_NUMBER, clothingPrice)
        {
            itemName = name;
            brand    = brandName;
        }

        public override decimal GetPriceAfterTax()
        {
            return TAX_RATE * Price;
        }

        public override void DisplayItemInformation()
        {
            base.DisplayItemInformation();
            Console.WriteLine("Price with taxes: {0}", 
                    GetPriceAfterTax().ToString("N2"));
            Console.Write("Product: {0}", itemName);
            Console.WriteLine(" by {0}", brand);
        }
    }
}
