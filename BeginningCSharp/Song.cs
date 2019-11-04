using System;
namespace BeginningCSharp
{
    class Song
    {
        //Class attributes
        public string title;
        public string artist;
        public int duration;
        public static int songCount = 0; //how many song objects have been created.  This attribute is linked directly to the Song class, not the objects within.

        //Any time a song gets created, this is called
        public Song(string aTitle, string aArtist, int aDuration)
        {
            title = aTitle;
            artist = aArtist;
            duration = aDuration;
            songCount++;
        }

        public int getSongCount()
        {
            return songCount;
        }
    }
}
