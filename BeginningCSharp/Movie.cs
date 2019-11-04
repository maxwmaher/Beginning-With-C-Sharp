using System;
namespace BeginningCSharp
{
    class Movie
    {
        //public means these can be accessed anywhere
        public string title;
        public string director;
        //only code within the Movie class is going to be able to access the rating
        private string rating;

        public Movie(string aTitle, string aDirector, string aRating)
        {
            title = aTitle;
            director = aDirector;
            Rating = aRating; //calls the setter written below when using Rating instead of rating as the key
        }

        public string Rating
        {
            get { return rating; }
            set {
                if (value == "G" || value == "PG" || value == "PG-13" || value == "R" || value == "NR")
                {
                    rating = value;
                }
                else
                {
                    rating = "NR";
                }
            }
        }
    }
}
