using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FileMgr;


namespace StockManager{

    class Book : Reading 
    {
        private string fullName;
        public string FullName { get { return fullName; } }
      
        private string bookTitle;
        public string BookTitle { get { return bookTitle; } }

        private string bookPub;
        public string BookPub { get { return bookPub; } }
        

        public Book (string name,string booktitle,string publisher,decimal bookprice)
            : base(bookprice)
        {
            fullName = name;
            bookTitle = booktitle;
            bookPub = publisher; 
        }
         public override void DisplayItemInformation()
        {
            base.DisplayItemInformation();
            Console.WriteLine("Book name : {0}",bookTitle);
           Console.WriteLine("publisher: {0}",bookPub );
           Console.WriteLine("Author Name {0}", fullName);
        }
}
}
