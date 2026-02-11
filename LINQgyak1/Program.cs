using System;
using System.Collections.Generic;
using System.Linq;

List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

//var evenNumbers = from num in numbers
//                  where num % 2 == 0
//                  select num;



List<int> resultNumbers = new List<int>();
foreach (int num in numbers) //from num in numbers
{
    if (num % 2 == 0)// where helyett
    {
        resultNumbers.Add(num); //select  num helyett
    }
}

    foreach (var num in resultNumbers)
    {
        Console.WriteLine(num);
    }



