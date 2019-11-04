using System;
namespace BeginningCSharp
{
    class Book
    {
        //Class attributes
        public string title;
        public string author;
        public int numberOfPages;


        //When I say public, then name of the class, that means this will be the constructor for this class
        //The lowercase a in the parameters below stands for "argument" for better clarity
        public Book(string aTitle, string aAuthor, int aNumberOfPages)
        {
            title = aTitle;
            author = aAuthor;
            numberOfPages = aNumberOfPages;
        }
    }
}
