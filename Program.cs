using System;
using LendingLibrary.Models;

namespace LendingLibrary
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Library mainLibrary = new Library();    

                Console.WriteLine("\nWelcome to the Lending Library");
                Console.WriteLine($"Please enter 'Albums', 'AudioBooks, 'Novels', 'TextBooks', 'Add Member', 'Add Album', 'Remove Media' or 'X' to quit: ");
                var menuSelection = Console.ReadLine().ToLower();
                if (menuSelection ==  "x") 
                {
                    break;
                }

                switch (menuSelection)
                {
                    case("albums"):
                        mainLibrary.ShowAlbums();
                        break;

                    case("audiobooks"):
                        mainLibrary.ShowAudioBooks();

                        break;

                    case("novels"):
                        mainLibrary.ShowNovels();

                        break;

                    case("textbooks"):
                        mainLibrary.ShowTextBooks();

                        break;

                    case("add member"):

                        break;

                    case("add album"):
                        mainLibrary.AddNewAlbum();
                        break;

                    case("remove media"):
                    
                        break;

                    default:
                        Console.WriteLine("Please enter a valid selection");
                        break;
                }
            }
        }
    }
}
