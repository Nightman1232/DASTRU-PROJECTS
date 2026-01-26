using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACTIVITY_3_PENTADO
{
    internal class Program
    {
        static void Main(string[] args)
        {   // Initialize a 3x2 two-dimensional array
            string[,] data = new string[3, 2]
            {
            { "Laptop", "     45,000" },
            { "Tablet", "     18,000" },
            { "Phone",  "     32,000" }
            };

            // Column headers
            Console.WriteLine("{0,-10}{1,-20}{2,-40}", "", "Electronic Device", "Price");
            Console.WriteLine(new string('-', 40));

            // Row headers
            for (int i = 0; i < 3; i++)
            {
                Console.Write("{0,-10}", "ITEM " + (i + 1));
                for (int j = 0; j < 2; j++)
                {
                    Console.Write("{0,-15}", data[i, j]);
                }
                Console.WriteLine();

             
            }
            Console.ReadKey();
        }
    }
}
    

