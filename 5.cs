using System;
using System.Linq;

class five
{
    static void Main()
    {
        int[] numbers = { 42, 32, 25, 18, 27, 58, 78 };

        int sum = numbers.Sum();
        int difference = numbers.Aggregate((result, number) => result - number);

        Console.WriteLine($"Сума чисел: {sum}");
        Console.WriteLine($"Різниця чисел: {difference}");
    }
}
