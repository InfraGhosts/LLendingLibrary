namespace LendingLibrary.Models
{
    public class TextBook : Book
    { 
        public string Subject { get; set; }
        public TextBook(string title, int publicaitonYear, string author, string subject)
        {
            Title = title;
            PublicaitonYear = publicaitonYear;
            Author = author;
            Subject = subject;
        }
    }

}