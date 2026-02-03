namespace Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1. Add \n2. Substract\n3. Multiply\n4. Division");

            float choice = float.Parse(Console.ReadLine());
            int a = 10 ; int b = 5;
            switch (choice)
            {
                case 1:
                    Console.WriteLine("Sum: " + (a + b));
                    break;

                case 2:
                    Console.WriteLine("Difference: " (a - b));
                    break;

                case 3:
                    Console.WriteLine("Product: "(a*b));
                    break;
            }
        }
    }
}
