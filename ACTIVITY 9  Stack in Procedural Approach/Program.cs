using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ACTIVITY_9__Stack_in_Procedural_Approach
{

    class Program
    {
        // Initialize empty stack for songs
        static Stack<string> songStack = new Stack<string>();

        static void AddSong()
        {
            try
            {
                Console.Write("Enter song name to add: ");
                string song = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(song))
                    throw new Exception("Song name cannot be empty.");

                songStack.Push(song);
                Console.WriteLine($"\"{song}\" added to playlist.");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
        }

        static void PlaySong()
        {
            try
            {
                if (songStack.Count == 0)
                    throw new InvalidOperationException("Playlist is empty. No song to play.");

                string currentSong = songStack.Pop();
                Console.WriteLine($"Now Playing: {currentSong}");
            }
            catch (InvalidOperationException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        static void ViewCurrentSong()
        {
            try
            {
                if (songStack.Count == 0)
                    throw new InvalidOperationException("Playlist is empty.");

                Console.WriteLine("Next song to play: " + songStack.Peek());
            }
            catch (InvalidOperationException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        static void DisplayPlaylist()
        {
            if (songStack.Count == 0)
            {
                Console.WriteLine("Playlist is empty.");
            }
            else
            {
                Console.WriteLine("\nSongs in Playlist:");
                foreach (var song in songStack)
                {
                    Console.WriteLine(song);
                }
            }
        }

        static void Main(string[] args)
        {
            while (true)
            {
                try
                {
                    Console.WriteLine("\nMUSIC PLAYLIST ");
                    Console.WriteLine("1. Add Song");
                    Console.WriteLine("2. Play Song");
                    Console.WriteLine("3. View Next Song");
                    Console.WriteLine("4. Display Playlist");
                    Console.WriteLine("5. Exit");

                    Console.Write("\nEnter your choice: ");
                    int choice = Convert.ToInt32(Console.ReadLine());

                    switch (choice)
                    {
                        case 1:
                            AddSong();
                            break;
                        case 2:
                            PlaySong();
                            break;
                        case 3:
                            ViewCurrentSong();
                            break;
                        case 4:
                            DisplayPlaylist();
                            break;
                        case 5:
                            Console.WriteLine("Exiting Music Player...");
                            return;
                        default:
                            Console.WriteLine("Invalid choice! Please select 1-5.");
                            break;
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("Invalid input! Please enter a number.");
                }
            }
        }
    }
}