using System;
using System.Collections.Generic;
using System.Text;

namespace RobotsVsDinosaursGame
{

    class Book
    {
        int pageLength;
        string genre;
        bool print;
    
        public Book(int pageLength, string genre, bool print)
        {
            this.pageLength = pageLength;
            this.genre = genre;
            this.print = print;
           
        }
    }

}


