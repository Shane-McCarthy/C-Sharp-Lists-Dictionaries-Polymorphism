using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StockManager{

    class Magazine : Reading 

    { 
        private string magTitle;
        public string MagTitle { get { return magTitle; } }
      
        private string magMonth;
        public string MagMonth { get { return magMonth; } }

        private string magDate;
        public string MagDate { get { return magDate; } }
        
        

        public Magazine (string title,string month,string date,decimal magprice)
            : base(magprice)
        {
            magTitle = title;
            magMonth = month;
            magDate = date; 
        }
         public override void DisplayItemInformation()
        {
            base.DisplayItemInformation();
            Console.WriteLine("Magazine name : {0}",magTitle);
           Console.Write("Issue Month: {0}",magMonth );
           Console.WriteLine(" Issue Year {0}", magDate);
        }
    }
}
