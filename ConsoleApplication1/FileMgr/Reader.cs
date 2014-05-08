using System;
using System.IO;

namespace FileMgr
{
    static public class Reader
    {
        public enum eClothing { name = 0, brand, price }
        public enum eAuthors { authorId, lname, fname }
        public enum eBooks { title, publisher, authorId, price }
        public enum eMagazine { title, month, date, price }

        private static int GetLineCount(string fileLocation)
        {
            StreamReader sr = new StreamReader(fileLocation);
            int counter = 0;

            while (!sr.EndOfStream)
            {
                counter++;
                sr.ReadLine();
            }
            sr.Close();
            return counter;
        }

        public static string[] ReadLines(string fileLocation)
        {
            int totalItems = GetLineCount(fileLocation);
            string[] itemDetails = new string[totalItems];
            StreamReader sr = new StreamReader(fileLocation);

            string itemDetail;
            int counter = 0;

            while (!sr.EndOfStream)
            {
                itemDetail = sr.ReadLine();
                if (itemDetail.Trim() != "")
                    itemDetails[counter++] = itemDetail;
            }
            sr.Close();
            return itemDetails;
        }
    }
}
