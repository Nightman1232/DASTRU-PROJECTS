using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PENTADO_ACT5
{
    internal abstract class Song
    {
        public string Title { get; set; }
        public string Artist { get; set; }

        public Song(string title, string artist)
        {
            Title = title;
            Artist = artist;
        }

        public abstract void Display();

        // USER INPUT FACTORY METHOD
        public static Song CreateSongFromUser()
        {
            Console.Write("Type (1 = Local, 2 = International): ");
            int choice = int.Parse(Console.ReadLine());

            Console.Write("Title: ");
            string title = Console.ReadLine();

            Console.Write("Artist: ");
            string artist = Console.ReadLine();

            if (choice == 1)
                return LocalSong.Create(title, artist);
            else
                return InternationalSong.Create(title, artist);
        }
    }
}
