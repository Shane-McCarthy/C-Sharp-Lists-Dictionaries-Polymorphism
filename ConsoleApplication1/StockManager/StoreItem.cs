using System;

namespace StockManager
{
    public abstract class StoreItem
    {
        private string departmentName;
        public  string DepartmentName { get { return departmentName; } }

        public abstract decimal TaxRate { get;  }

        private int floorLocation;
        public int  FloorLocation { get { return floorLocation; } }

        private decimal price;
        public decimal Price { get { return price; } }

        public StoreItem(string deptName, int floorOfBuilding, decimal itemPrice)
        {
            departmentName = deptName;
            floorLocation  = floorOfBuilding;
            price          = itemPrice;
        }

        public virtual void DisplayItemInformation()
        {
            Console.WriteLine("Department Name: {0}", this.DepartmentName);
            Console.WriteLine("Floor: {0}", this.FloorLocation);
            Console.WriteLine("Price: {0}", price);
        }
        public abstract decimal GetPriceAfterTax();
    }
}
