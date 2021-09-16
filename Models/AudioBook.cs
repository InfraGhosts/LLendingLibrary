namespace LendingLibrary.Models
{
    public class AudioBook : CD
    { 
        public string Author { get; set; }
        public AudioBook(string title, int publicaitonYear, int numberOfTracks, string author)
        {
            Title = title;
            PublicaitonYear = publicaitonYear;
            NumberOfTracks = numberOfTracks;
            Author = author;
        }
    }
}