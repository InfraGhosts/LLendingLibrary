namespace LendingLibrary.Models
{
    public class Album : CD
    { 
        public string Artist { get; set; }
        public Album(string title, int publicaitonYear, int numberOfTracks, string artist)
        {
            Title = title;
            PublicaitonYear = publicaitonYear;
            NumberOfTracks = numberOfTracks;
            Artist = artist;
        }
        
    }
}