using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PENTADO_ACT5
{
    class LocalSong : Song
    {
        public string Language { get; set; }

        private LocalSong(string title, string artist, string language)
            : base(title, artist)
        {
            Language = language;
        }

        public static LocalSong Create(string title, string artist)
        {
            Console.Write("Language: ");
            string language = Console.ReadLine();
            return new LocalSong(title, artist, language);
        }

        public override void Display()
        {
            Console.WriteLine("---- LOCAL SONG ----");
            Console.WriteLine("Title: " + Title);
            Console.WriteLine("Artist: " + Artist);
            Console.WriteLine("Language: " + Language);
            Console.WriteLine();
        }
    }
}