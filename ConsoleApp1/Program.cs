using System.Collections;
using System.Collections.Generic;

namespace Lista
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> lista = new List<string>();

            // Adding elements to the list
            lista.Add("refrf");
            lista.Add("rerf");
            lista.Add("rtghth");
            lista.Add("kizujthtz");
            lista.Add("gthtzrf");

            lista.Reverse();

            int index = 1;

            // Displaying elements in the list
            Console.WriteLine("Elements in the list: ");
            foreach (string elem in lista)
            {
                Console.WriteLine($"A(z) {index} elem a listában: " + elem); index++;
            }
            Console.WriteLine();
            Console.WriteLine("Elements in the list (with for: ");
            for (int i = 0; i < lista.Count; i++)
            {
                Console.WriteLine($"A(z) {i + 1} elem a listában: " + lista.ElementAt(i));
            }
            Console.Write("Element 2 is present in the list? ") + lista .Contains(2));

            lista.Sort();
            index = 0;
            foreach (int elem in lista)
            {
                Console.WriteLine($"A(z) {index + 1} elem a listában: " + elem); index++;
        }
    }
}
