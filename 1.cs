using System;
using System.Linq;

class One
{
    static void Main()
    {
        Random rand = new Random();
        int[] temperatures = Enumerable.Range(1, 30).Select(_ => rand.Next(-10, 35)).ToArray();

        var hotDays = from temp in temperatures
                      where temp > 20
                      select temp;

        double averageTemperature = temperatures.Average();

        Console.WriteLine("Дні з температурою більше 20°C:");
        foreach (var temp in hotDays)
        {
            Console.Write(temp + " ");
        }

        Console.WriteLine($"\nСередня температура за місяць: {averageTemperature:F1}°C");
    }
}
