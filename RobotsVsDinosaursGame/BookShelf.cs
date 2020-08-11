using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace RobotsVsDinosaursGame
{
    class BookShelf
    {
        //List<Book> mybooks;
        // BookShelf.mybooks("Bones of Fire");

        string title;
        string dimension;
        string pageLength;
       
        public BookShelf(string title, string dimension, string pageLength)
        {
            this.title = title;
            this.dimension = dimension;
            this.pageLength = pageLength;
        }


        public void AddBook()
        {
            List<string> test = new List<string>();
            test.Add("Bones of Fire");
            test.Add("Trial by Fire");
            test.Add("Saints on Fire");
        }
   


         





    }
}
