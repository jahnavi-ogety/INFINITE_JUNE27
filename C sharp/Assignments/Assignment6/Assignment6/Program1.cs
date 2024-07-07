using System;
using System.Collections.Generic;
using System.Linq;

class Program1

{
    static void Main()
    {
        List<int> numbers = new List<int> { 7, 3, 30, 8, 9, 10 };

        var result = numbers
            .Select(n => new { Number = n, Square = n * n })
            .Where(p => p.Square > 20)
            .ToList();

        Console.WriteLine("Numbers and their squares greater than 20:");
        foreach (var p in result)
        {
            Console.WriteLine($"{p.Number}: {p.Square}");
            Console.ReadLine();
        }
    }
}

