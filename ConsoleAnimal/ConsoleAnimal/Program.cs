using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAnimal
{
    class Program
    {
        static void Main(string[] args)
        {
            String[] MyArray;
            MyArray = new string[5] { "Zebra", "Ant", "Owl", "Lion", "Monkey" };

            Console.WriteLine("---For Loop---");

            for (int i = 0; i < 5; i++)
                Console.WriteLine(" " + MyArray[i]);


            Console.WriteLine("-----Foreach Loop-----");

            foreach (string x in MyArray)
            {
                Console.WriteLine(" " + x);
            }


            Console.WriteLine("------Do While Loop----");


            int k = 0;
            do
            {
                Console.WriteLine(" " + MyArray[k]);
                k++;
            } while (k < 5);

            Console.WriteLine("----While Loop----");

            int p = 0;
            while (p < 5)
            {
                Console.WriteLine(" " + MyArray[p]);
                p++;
            }

            String[] animals;
            animals = new string[] { "Zebra", "Kiwi", "Amazona Parrot", "Tiger" };
            foreach (string s in animals)
            {
                Console.WriteLine(" " + s);
            }
            String[] places;
            places = new string[] { "Africa", "New Zealand", "Jamaica", "India" };
            foreach (string q in animals)
            {
                Console.WriteLine(" " + q);
            }
            Console.WriteLine();
            Console.WriteLine("\nAfter Sort:");
            Array.Sort(MyArray);

            foreach (string g in MyArray)
            {
                Console.WriteLine(g);
                // display sorted array 
            }
            Console.WriteLine("\nAfter Sort of animals array:");
            Array.Sort(animals);

            foreach (string g in animals)
            {
                Console.WriteLine(g);
                // display sorted array 
            }
            Console.WriteLine("\nAfter Sort of place array:");
            Array.Sort(places);

            foreach (string g in places)
            {
                Console.WriteLine(g);
                // display sorted array 
            }
            Console.Read();
        }
    }
}