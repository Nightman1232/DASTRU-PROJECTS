using System;
using System.Collections.Generic;


class Program
{
    static void Main(string[] args)
    {
        // Create a linked list to store friends' names
        LinkedList<string> friends = new LinkedList<string>();

        // Variable to store number of friends
        int n = 0;

        // Counter to track how many friends have been added
        int count = 0;

        // Variable to store each friend's name
        string name;

    INPUT_COUNT:
        // Display welcome message 
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("Welcome to Friend counter:\n");
        Console.ResetColor();

        // Ask user for number of friends
        Console.WriteLine("Enter number of friends (5 to 10): ");
        n = int.Parse(Console.ReadLine());
        Console.Clear();

        // Validate input (must be between 5 and 10)
        if (n < 5 || n > 10)
        {
            Console.WriteLine("Invalid input! Please try again.");
            goto INPUT_COUNT; // Go back and ask again
        }

    ADD_NODE:
        // Ask user to enter a friend's name
        Console.Write("Enter first name of friend {0}: ", count + 1);
        name = Console.ReadLine();

        // Add the name to the end of the linked list
        friends.AddLast(name);

        // Increase the counter
        count++;

        // If not all friends are added, repeat input
        if (count < n)
        {
            goto ADD_NODE;
        }

        // Display the list of friends
        Console.WriteLine("\nFriends List:");

        // Start from the first node of the linked list
        LinkedListNode<string> temp = friends.First;

    DISPLAY_LIST:
        // Traverse and print each node in the linked list
        if (temp != null)
        {
            Console.WriteLine(temp.Value); // Print current friend's name
            temp = temp.Next;              // Move to the next node
            goto DISPLAY_LIST;              // Continue traversal
        }
    Console.ReadLine();
    }
}