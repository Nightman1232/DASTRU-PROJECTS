using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stack_and_queue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Stack<string> colors = new Stack<string>();

            ////Push colors
            //colors.Push("Cyan");
            //colors.Push("Blue");
            //colors.Push("Red");

            //Console.WriteLine("Top Color:" + colors.Peek());

            //Console.WriteLine("Pop: " + colors.Pop());

            //Console.WriteLine("Remaining Colors in Stack:");
            //foreach (string color in colors)
            //{
            //    Console.WriteLine(color);
            //}
            //Console.WriteLine("Count: " + colors.Count);

            Queue<int> numbers = new Queue<int>();

            numbers.Enqueue(1);
            numbers.Enqueue(2);
            numbers.Enqueue(3);
            numbers.Enqueue(4);
            numbers.Enqueue(5);

            Console.WriteLine("Front Number" + numbers.Peek());

            Console.WriteLine("Dequeued: " + numbers.Dequeue());

            Console.WriteLine("Remaining Fruit in Quene:");
            foreach (int number in numbers)
            {
                Console.WriteLine(number);
            }
            Console.WriteLine("Count: "+ numbers.Count);
        }
    }
}
