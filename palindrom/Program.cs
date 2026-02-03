using System;

namespace Palindrom1
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputText = "";
            string reverseText = "";
            char[] reverse_array = null;

            Console.WriteLine("Palindróm szókereső.");
            Console.WriteLine();
            Console.WriteLine("Kérek egy szót: ");
            inputText = Console.ReadLine();

            reverse_array = inputText.ToCharArray();
            Array.Reverse(reverse_array);
            reverseText = new string(reverse_array);


            if (inputText.Equals(reverseText))
            {
                Console.WriteLine("A beirt szó palidom szó!");
            }
            else
            {
                Console.WriteLine("A beirt szó nem palindrom szó.");
            }

            Console.WriteLine();
            Console.WriteLine("Enterrel lehet kilépni!");
            Console.WriteLine();

        }

    }
}