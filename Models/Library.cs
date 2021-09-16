using System;
using System.Collections.Generic;

namespace LendingLibrary.Models
{
    public class Library
    {   
        public List<Novel> Novels {get;set;}
        public List<TextBook> TextBooks {get;set;}
        public List<Album> Albums {get;set;}
        public List<AudioBook> AudioBooks {get;set;}

        public Library()
        {
            var album1 = new Album("Substance",1987,24,"New Order");
            var audioBook1 = new AudioBook("An AudioBook's Title",2021,200,"An Author");
            var novel1 = new Novel("Making Comics",2021,"An Author","A Genre");
            var textBook1 = new TextBook("Making Comics",2006,"Scott McCloud","Art");

            Albums = new List<Album>();
            AudioBooks = new List <AudioBook>();
            Novels = new List<Novel>();
            TextBooks = new List<TextBook>();
            AddAlbum(album1);
            AddAuidioBook(audioBook1);
            AddNovel(novel1);
            AddTextBook(textBook1);

        }

        public void AddAlbum(Album album)
        {
            Albums.Add(album);
        }
        public void AddAuidioBook(AudioBook audioBook)
        {
            AudioBooks.Add(audioBook);
        }
        public void AddNovel(Novel novel)
        {
            Novels.Add(novel);
        }        
        public void AddTextBook(TextBook textBook)
        {
            TextBooks.Add(textBook);
        }
        public void ShowAlbums()
            {
                Console.WriteLine($"List of Albums:");
                foreach (var album in Albums)
                {
                    Console.WriteLine($"{album.Title} is a {album.NumberOfTracks} track album by {album.Artist}, published {album.PublicaitonYear}");
                }
            }
        public void ShowAudioBooks()
            {
                Console.WriteLine($"List of audiobooks:");
                foreach (var audiobook in AudioBooks)
                {
                    Console.WriteLine($"{audiobook.Title} is a {audiobook.NumberOfTracks} track audiobook by {audiobook.Author}, published {audiobook.PublicaitonYear}");
                }
            }
        public void ShowNovels()
            {
                Console.WriteLine($"List of textbooks:");
                foreach (var novel in Novels)
                {
                    Console.WriteLine($"List of novels:");
                    Console.WriteLine($"{novel.Title} is a {novel.Genre} novels by {novel.Author}, published {novel.PublicaitonYear}");
                }
            }
        public void ShowTextBooks()
            {
                Console.WriteLine($"List of textbooks:");
                foreach (var textBook in TextBooks)
                {
                    Console.WriteLine($"{textBook.Title} is a {textBook.Subject} track textBook by {textBook.Author}, published {textBook.PublicaitonYear}");
                }
            }

        public void AddNewAlbum()
            {
            Console.WriteLine("Enter Title");
            var title = Console.ReadLine().ToLower();
            Console.WriteLine("Enter Artist");
            var artist = Console.ReadLine().ToLower();
            Console.WriteLine("Enter NumberOfTracks");
            var numberOfTracks = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter PublicaionYear");
            var publicationYear = int.Parse(Console.ReadLine());
            
            var newAlbum = new Album(title, publicationYear, numberOfTracks, artist);
            Console.WriteLine($"{newAlbum.Title} added to Library");
            //Albums.Add(newAlbum);
            AddAlbum(newAlbum);
        }
    }

}