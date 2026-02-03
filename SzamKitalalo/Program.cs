using System;

namespace SzamKitalalo
{
    class Program
    {
        static void Main(string[] args)
        {
            // Véletlen szám generálás
            Random rnd = new Random();
            int veletlenSzam = rnd.Next(1, 101);
            int tipp = 0;
            bool eltalalt = false;
            string inputText = "";

            Console.WriteLine("Számkitaláló játék.");
            Console.WriteLine("Gondoltam egy számra 1 és 100 között. Mi az?");

            do
            {
                Console.Write("Kérek egy tippet: ");
                inputText = Console.ReadLine();
                tipp = int.Parse(inputText);
                if(tipp < veletlenSzam)
                {
                    Console.Write("A szám nagyobb, mint a tipp volt!");
                }
                else
                {
                    if (tipp > veletlenSzam)
                    {
                        Console.Write("A szám kisebb, mint a tipp volt!");
                    }
                    else
                    {
                        eltalalt = true;
                        Console.WriteLine("Gratulálok, eltaláltad a számot!");
                    }
                    {
                        Console.Write("A szám kisebb, mint a tipp volt!");
                    }
                }
            }
            while (!eltalalt);

            Console.WriteLine();
            Console.WriteLine("Enterrel lehet kilépni!");
            Console.WriteLine();
        }

    }
}