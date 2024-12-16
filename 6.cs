using System;
using System.Linq;

class six
{
    static void Main()
    {
        int[] numbers = { 42, 32, 25, 18, 27, 58, 78 };

        var selectedNumbers = numbers.Skip(2).Take(3);

        Console.WriteLine("Три числа, починаючи з третього:");
        foreach (var num in selectedNumbers)
        {
            Console.WriteLine(num);
        }
    }
}
