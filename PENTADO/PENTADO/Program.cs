using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PENTADO
{
    internal class Program
    {
        // Initialize empty stack for songs
        // Playlist class implementing Queue
        internal class Playlist
        {
            // Initialize empty queue
            private Queue<string> songQueue = new Queue<string>();

            // Add song to queue (Enqueue)
            public void AddSong()
            {
                try
                {
                    Console.Write("Enter song name to add: ");
                    string song = Console.ReadLine();

                    if (string.IsNullOrWhiteSpace(song))
                        throw new Exception("Song name cannot be empty.");

                    songQueue.Enqueue(song);
                    Console.WriteLine($"\"{song}\" added to playlist.");
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error: " + ex.Message);
                }
            }

            // Play song (Dequeue)
            public void PlaySong()
            {
                try
                {
                    if (songQueue.Count == 0)
                        throw new InvalidOperationException("Playlist is empty. No song to play.");

                    string currentSong = songQueue.Dequeue();
                    Console.WriteLine($"Now Playing: {currentSong}");
                }
                catch (InvalidOperationException ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }

            // View next song (Peek)
            public void ViewNextSong()
            {
                try
                {
                    if (songQueue.Count == 0)
                        throw new InvalidOperationException("Playlist is empty.");

                    Console.WriteLine("Next song to play: " + songQueue.Peek());
                }
                catch (InvalidOperationException ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }

            // Display all songs
            public void DisplayPlaylist()
            {
                if (songQueue.Count == 0)
                {
                    Console.WriteLine("Playlist is empty.");
                }
                else
                {
                    Console.WriteLine("\nSongs in Playlist:");
                    foreach (var song in songQueue)
                    {
                        Console.WriteLine(song);
                    }
                }
            }
        }

    
   
        
            static void Main(string[] args)
            {
                Playlist playlist = new Playlist();

                while (true)
                {
                    try
                    {
                        Console.WriteLine("\nMUSIC PLAYLIST (QUEUE - FIFO)");
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
                                playlist.AddSong();
                                break;
                            case 2:
                                playlist.PlaySong();
                                break;
                            case 3:
                                playlist.ViewNextSong();
                                break;
                            case 4:
                                playlist.DisplayPlaylist();
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
                    catch (Exception ex)
                    {
                        Console.WriteLine("Unexpected Error: " + ex.Message);
                    }
                Console.ReadKey();
                }
                
            }
        }
    }