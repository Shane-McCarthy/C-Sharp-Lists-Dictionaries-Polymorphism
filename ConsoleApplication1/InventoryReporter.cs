using System;
using System.Collections.Generic;
using FileMgr;
using StockManager;
using AuthorManager;

namespace InventoryLibrary
{
    class InventoryReporter
    {
        //
        static List<StoreItem> AddClothes(List<StoreItem> storeItems){
            string[] clothes = Reader.ReadLines(PathMgr.CLOTHING_FILE);
            for(int i=0; i<clothes.Length; i++)
            {
                string[] clothingDetail = clothes[i].Split(',');
                decimal clothingPrice =
                    Convert.ToDecimal(clothingDetail[(int)Reader.eClothing.price]);

                storeItems.Add(new Clothing(clothingDetail[(int)Reader.eClothing.name],
                                            clothingDetail[(int)Reader.eClothing.brand],
                                            clothingPrice));
            }
            return storeItems;
        }
       
        static List<StoreItem> AddBooks(List<StoreItem> bookItems)
        {
            string[] books = Reader.ReadLines(PathMgr.BOOK_FILE);
            Dictionary<string, Author> storeAuthors = new Dictionary<string, Author>();
            storeAuthors = AddAuthors(storeAuthors);
            for (int i = 0; i < books.Length; i++)
            {
                string[] bookDetail = books[i].Split(',');
                string authorID = bookDetail[(int)Reader.eBooks.authorId];
                 decimal bookPrice= Convert.ToDecimal(bookDetail[(int)Reader.eBooks.price]);
               
                Author temp = new Author();
                if (storeAuthors.TryGetValue(authorID, out temp)) {
                    string fullname = temp.FirstName + temp.LastName; 
                    Console.WriteLine("temp detail "+ fullname);

                bookItems.Add(new Book(fullname, bookDetail[(int)Reader.eBooks.title],
                                            bookDetail[(int)Reader.eBooks.publisher],bookPrice
                                            ) );
                }
            }
            return bookItems;
        }
        
        static Dictionary<string,Author> AddAuthors(Dictionary <string,Author> dictionaryItems)
        {
            string[] authors = Reader.ReadLines(PathMgr.AUTHOR_FILE);
            for (int i = 0; i < authors.Length; i++)
            {
                string[] authorDetail = authors[i].Split(',');
                //string authorID = authorDetail[(int)Reader.eAuthors.authorId];
                Author author = new Author(authorDetail[0],authorDetail[1],authorDetail[2]);
                //string authorID = authorDetail[0];
                dictionaryItems.Add(authorDetail[0],author);
            }
            return dictionaryItems;
        }

        static List<StoreItem> AddMagazines(List<StoreItem> magazineItems)
        {
            string[] magazines = Reader.ReadLines(PathMgr.MAGAZINE_FILE);
            for (int i = 0; i < magazines.Length; i++)
            {
                string[] magazineDetail = magazines[i].Split(',');
                decimal magazinePrice =
                    Convert.ToDecimal(magazineDetail[(int)Reader.eMagazine.price]);

                magazineItems.Add(new Magazine(magazineDetail[(int)Reader.eMagazine.title],
                                            magazineDetail[(int)Reader.eMagazine.month],
                                            magazineDetail[(int)Reader.eMagazine.date],
                                            magazinePrice));
            }
            return magazineItems;
        }
        static void Main()
        {
            List<StoreItem> storeItems  = new List<StoreItem>();
            storeItems      = AddClothes(storeItems);
            storeItems = AddBooks(storeItems); 
            storeItems = AddMagazines(storeItems); 

           

            // we have the authors dictionary so:
            // read the book info from the book.csv
            // get the authorID from the book.csv data.
            // get the first and last name with the authorID from 'storeAuthors' dictionary obtained just above these comments.
            // create a Book object with (fname,lName, title, publisher info);
           //Book thebook = new Book();

            for (int i = 0; i < storeItems.Count; i++){
                storeItems[i].DisplayItemInformation();
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
