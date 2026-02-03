using System;

namespace TeruletKerulet
{
    class Program
    {
        static void Main(string[] args)
        {
            double a=0, b=0, c=0, K, T, S=0;
            string inputText="";
            Console.WriteLine("Háromszög Kerület/Terület számítás.");
            Console.Write("Adja meg a háromszög első oldalhosszát: ");
            inputText = Console.ReadLine();
            //a = double.Parse(inputText);
            double.TryParse(inputText, out a);

            Console.Write("Adja meg a háromszög második oldalhosszát: ");
            inputText = Console.ReadLine();
            //a = double.Parse(inputText);
            double.TryParse(inputText, out b);

            Console.Write("Adja meg a háromszög harmadik oldalhosszát: ");
            inputText = Console.ReadLine();
            //a = double.Parse(inputText);
            double.TryParse(inputText, out c);

            K = a + b + c;
            S = K / 2;
            T = Math.Sqrt(S * (S - a) * (S - b) * (S - c));

            Console.WriteLine($"A háromszög kerülete: {K}");
            Console.WriteLine($"A háromszög területe: {T}");
            Console.WriteLine();
            Console.WriteLine("Enterrel lehet kilépni!");
            Console.ReadLine();//enter leutesere zarodik csak be az ablak


        }

    }
}