using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACT_8
{

    
    // ABSTRACT BASE CLASS: Song
    
    internal abstract class Song
    {
        // Common properties for all songs
        public string Title { get; set; }
        public string Artist { get; set; }

        // Constructor for initializing title and artist
        protected Song(string title, string artist)
        {
            Title = title;
            Artist = artist;
        }

        // Abstract method to be implemented by derived classes
        public abstract void Display();

        // Factory method that creates a Song object based on user input
        public static Song CreateSongFromUser()
        {
            // Ask user to choose song type
            int choice = InputHelper.GetInt("Type (1 = Local, 2 = International): ");

            // Get common song details
            string title = InputHelper.GetString("Title: ");
            string artist = InputHelper.GetString("Artist: ");

            // Create appropriate song object
            if (choice == 1)
                return LocalSong.Create(title, artist);
            else
                return InternationalSong.Create(title, artist);
        }
    }

   
    // DERIVED CLASS: LocalSong
    
    class LocalSong : Song
    {
        // Additional property specific to local songs
        public string Language { get; set; }

        // Private constructor (forces use of factory method)
        private LocalSong(string title, string artist, string language)
            : base(title, artist)
        {
            Language = language;
        }

        // Factory method for creating LocalSong objects
        public static LocalSong Create(string title, string artist)
        {
            string language = InputHelper.GetString("Language: ");
            return new LocalSong(title, artist, language);
        }

        // Displays local song details
        public override void Display()
        {
            Console.WriteLine("---- LOCAL SONG ----");
            Console.WriteLine($"Title   : {Title}");
            Console.WriteLine($"Artist  : {Artist}");
            Console.WriteLine($"Language: {Language}");
            Console.WriteLine();
        }
    }

   
    // DERIVED CLASS: InternationalSong
    
    class InternationalSong : Song
    {
        // Additional property specific to international songs
        public string Country { get; set; }

        // Private constructor
        private InternationalSong(string title, string artist, string country)
            : base(title, artist)
        {
            Country = country;
        }

        // Factory method for creating InternationalSong objects
        public static InternationalSong Create(string title, string artist)
        {
            string country = InputHelper.GetString("Country: ");
            return new InternationalSong(title, artist, country);
        }

        // Displays international song details
        public override void Display()
        {
            Console.WriteLine("--- INTERNATIONAL SONG ---");
            Console.WriteLine($"Title  : {Title}");
            Console.WriteLine($"Artist : {Artist}");
            Console.WriteLine($"Country: {Country}");
            Console.WriteLine();
        }
    }


    // HELPER CLASS FOR USER INPUT
    
    static class InputHelper
    {
        // Reads and validates integer input
        public static int GetInt(string message)
        {
            int value;
            while (true)
            {
                try
                {
                    Console.Write(message);
                    value = int.Parse(Console.ReadLine());
                    return value;
                }
                catch
                {
                    Console.WriteLine("Invalid input. Please enter a number.");
                }
            }
        }

        // Reads and validates string input
        public static string GetString(string message)
        {
            string input;
            do
            {
                Console.Write(message);
                input = Console.ReadLine();
            } while (string.IsNullOrWhiteSpace(input));

            return input;
        }
    }

   
    // LINKED LIST NODE CLASS
   
    class SongNode
    {
        // Stores song data
        public Song Data;

        // Pointer to next node
        public SongNode Next;

        public SongNode(Song song)
        {
            Data = song;
            Next = null;
        }
    }

   
    // LINKED LIST IMPLEMENTATION
 
    class SongLinkedList
    {
        // Head node of the list
        private SongNode head;

        // Insert a new song at the end of the list
        public void Insert(Song song)
        {
            SongNode newNode = new SongNode(song);

            if (head == null)
            {
                head = newNode;
            }
            else
            {
                SongNode current = head;
                while (current.Next != null)
                    current = current.Next;

                current.Next = newNode;
            }

            Console.WriteLine("Song added successfully!\n");
        }

        // Remove a song by title
        public void Remove(string title)
        {
            if (head == null)
            {
                Console.WriteLine("List is empty.\n");
                return;
            }

            // If the song to remove is at the head
            if (head.Data.Title.Equals(title, StringComparison.OrdinalIgnoreCase))
            {
                head = head.Next;
                Console.WriteLine("Song removed successfully.\n");
                return;
            }

            // Search for the song in the list
            SongNode current = head;
            while (current.Next != null &&
                   !current.Next.Data.Title.Equals(title, StringComparison.OrdinalIgnoreCase))
            {
                current = current.Next;
            }

            if (current.Next == null)
            {
                Console.WriteLine("Song not found.\n");
            }
            else
            {
                current.Next = current.Next.Next;
                Console.WriteLine("Song removed successfully.\n");
            }
        }

        // Display all songs in the list
        public void Display()
        {
            if (head == null)
            {
                Console.WriteLine("No songs in the list.\n");
                return;
            }

            SongNode current = head;
            Console.WriteLine("\n===== SONG LIST =====\n");

            while (current != null)
            {
                current.Data.Display();
                current = current.Next;
            }
        }
    }

    // MAIN PROGRAM
    
    internal class Program
    {
        static void Main(string[] args)
        {
            SongLinkedList songList = new SongLinkedList();
            int choice;

            do
            {
                // Display menu options
                Console.WriteLine("     MENU ");
                Console.WriteLine("1. Add Song");
                Console.WriteLine("2. Remove Song");
                Console.WriteLine("3. Display Songs");
                Console.WriteLine("4. Exit\n");

                // Get user choice
                choice = InputHelper.GetInt("Choose an option: ");
                Console.WriteLine();

                switch (choice)
                {
                    case 1:
                        Song song = Song.CreateSongFromUser();
                        songList.Insert(song);
                        break;

                    case 2:
                        string title = InputHelper.GetString("Enter title to remove: ");
                        songList.Remove(title);
                        break;

                    case 3:
                        songList.Display();
                        break;

                    case 4:
                        Console.WriteLine("Program exited.");
                        break;

                    default:
                        Console.WriteLine("Invalid choice.\n");
                        break;
                }

            } while (choice != 4);

            Console.ReadKey();
        }
    }
}