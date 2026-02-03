namespace AvrageOfArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers;
            int tombHossz;
            string inputText;
            double avg;

            Console.WriteLine("Adjunk be egész számokat");
            Console.WriteLine("Hány számot olvassunk be?");
            inputText = Console.ReadLine();
            //tombHossz = int.Parse(inputText);
            tombHossz = Convert.ToInt32(inputText);

            numbers = new int[tombHossz];

            for (int i = 0; i < tombHossz; i++)
            {
                Console.WriteLine($"Kérjük a {i+1}-edik számot: ");
                inputText = Console.ReadLine();
                numbers[i] = Convert.ToInt32(inputText);
            }

            avg = numbers.Average();
            Console.WriteLine("Avrage: " + avg);


            Console.WriteLine();
            Console.WriteLine("Enterrel lehet kilépni!");
            Console.WriteLine();
        }
    }
}
