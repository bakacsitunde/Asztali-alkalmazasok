namespace metodus_2
{
    internal class Program
    {
        static void Rendeles(string termeknev, int mennyiseg = 1, decimal kedvezmeny = 0)
        {
            decimal osszeg = mennyiseg * 1000m * (1 - kedvezmeny);
            Console.WriteLine($"{mennyiseg} db {termeknev}: {osszeg:F0} Ft");
        }
        static void Main()
        {
            Console.WriteLine("=== Optional arguments ===");
            Rendeles("Egér");
            Rendeles("Billentyűzet", 2);
            Rendeles(termeknev: "Monitor", kedvezmeny: 0.1m);

            Console.WriteLine("\n=== Named arguments ===");
            Rendeles(kedvezmeny: 0.2m, termeknev: "Laptop", mennyiseg: 3);
        }
    }
}
