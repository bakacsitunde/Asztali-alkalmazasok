using System;

namespace AtlagSzamitas
{
    class Program
    {
    static void Main()
        {
            int a, b, c, sum; //valtozok deklaralasa, itt adjuk meg a valtozok tipusat is
            double avg;
            string inputText;
            Console.WriteLine("Adj meg 3 egész számot.");
            Console.WriteLine("Kiszámolom az átlagukat."); 
            Console.Write("Adj meg egy egész szamot: ");
            inputText = Console.ReadLine();
            int.TryParse(inputText, out a);


            Console.Write("Adj meg még egy egész szamot: ");
            inputText = Console.ReadLine();
            b= int.Parse(inputText);

            Console.Write("Adj meg még egy egész szamot: ");
            inputText = Console.ReadLine();
            c = int.Parse(inputText);

            sum = a + b + c;
            avg = sum / 3;

            Console.WriteLine($"A három szám átlaga: {avg}");
            Console.WriteLine();
            Console.WriteLine("Enterrel lehet kilépni!");
            Console.ReadLine();//enter leutesere zarodik csak be az ablak

        }

    }
}