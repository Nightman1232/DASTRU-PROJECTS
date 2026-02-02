using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PENTADO_ACT5
{
    class InternationalSong : Song
    {
        public string Country { get; set; }

        private InternationalSong(string title, string artist, string country)
            : base(title, artist)
        {
            Country = country;
        }

        public static InternationalSong Create(string title, string artist)
        {
            Console.Write("Country: ");
            string country = Console.ReadLine();
            return new InternationalSong(title, artist, country);
        }

        public override void Display()
        {
            Console.WriteLine("--- INTERNATIONAL SONG ---");
            Console.WriteLine("Title: " + Title);
            Console.WriteLine("Artist: " + Artist);
            Console.WriteLine("Country: " + Country);
            Console.WriteLine();
        }
    }
}