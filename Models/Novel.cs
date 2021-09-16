namespace LendingLibrary.Models
{
    public class Novel : Book
    { 
        public string Genre { get; set; }
        public Novel(string title, int publicaitonYear, string author, string genre)
        {
            Title = title;
            PublicaitonYear = publicaitonYear;
            Author = author;
            Genre = Genre;
        }
    }

}