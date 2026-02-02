using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PENTADO_ACT_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            LinkedList<string> friends = new LinkedList<string>();
            int n = 0;

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Welcome to Friend Counter\n");
            Console.ResetColor();

           
            // INPUT WITH EXCEPTION HANDLING
           
            while (true)
            {
                try
                {
                    Console.Write("Enter number of friends (5 to 10): ");
                    n = int.Parse(Console.ReadLine());

                    if (n < 5 || n > 10)
                    {
                        Console.WriteLine("Number must be between 5 and 10.\n");
                        continue;
                    }
                    break; // valid input
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Invalid input! Please enter a number.\n");
                }
            }

            Console.Clear();

            
            // ADD NAMES TO LINKED LIST
            
            for (int i = 0; i < n; i++)
            {
                Console.Write($"Enter first name of friend {i + 1}: ");
                string name = Console.ReadLine();
                friends.AddLast(name);
            }

           
            // DISPLAY ORIGINAL LINKED LIST
         
            Console.WriteLine("\nOriginal Friends List:");
            foreach (string friend in friends)
            {
                Console.WriteLine(friend);
            }

            
            // SORT VIA ARRAY
            
            string[] arr = new string[friends.Count];
            friends.CopyTo(arr, 0);
            Array.Sort(arr);

            // Clear and repopulate linked list
            friends.Clear();
            foreach (string name in arr)
            {
                friends.AddLast(name);
            }

           
            // DISPLAY SORTED LINKED LIST
            
            Console.WriteLine("\nSorted Friends List:");
            foreach (string friend in friends)
            {
                Console.WriteLine(friend);
            }

            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}
