using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PENTADO_ACT5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Song[,] songs = new Song[2, 2];

            for (int row = 0; row < 2; row++)
            {
                for (int col = 0; col < 2; col++)
                {
                    Console.WriteLine($"\nEnter Song [{row},{col}]");
                    songs[row, col] = Song.CreateSongFromUser();
                }
            }

            Console.WriteLine("\n===== SONG LIST (2D ARRAY) =====\n");

            for (int row = 0; row < 2; row++)
            {
                for (int col = 0; col < 2; col++)
                {
                    songs[row, col].Display();
                }
            }

            Console.ReadKey();
        }
    }
}