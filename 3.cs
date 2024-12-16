using System;
using System.Collections.Generic;
using System.Linq;

class Auto
{
    public string Model { get; set; }
    public int Price { get; set; }
    public int Year { get; set; }
    public string MadeIn { get; set; }
}

class three
{
    static void Main()
    {
        List<Auto> cars = new List<Auto>
        {
            new Auto { Model = "CarA", Price = 15000, Year = 1995, MadeIn = "Корея" },
            new Auto { Model = "CarB", Price = 25000, Year = 2010, MadeIn = "Німеччина" },
            new Auto { Model = "CarC", Price = 18000, Year = 1998, MadeIn = "Корея" },
            new Auto { Model = "CarD", Price = 20000, Year = 1999, MadeIn = "Корея" },
            new Auto { Model = "CarE", Price = 22000, Year = 2001, MadeIn = "Японія" },
            new Auto { Model = "CarF", Price = 10000, Year = 1993, MadeIn = "Корея" },
            new Auto { Model = "CarG", Price = 19000, Year = 1997, MadeIn = "Корея" },
            new Auto { Model = "CarH", Price = 30000, Year = 2020, MadeIn = "США" },
            new Auto { Model = "CarI", Price = 17000, Year = 1996, MadeIn = "Корея" },
            new Auto { Model = "CarJ", Price = 20000, Year = 1995, MadeIn = "Корея" }
        };

        var selectedCars = from car in cars
                           where car.Price <= 20000 && car.Year < 2000 && car.MadeIn == "Корея"
                           orderby car.Model
                           select car;

        var cheapestCar = selectedCars.OrderBy(car => car.Price).FirstOrDefault();

        Console.WriteLine("Відібрані автомобілі:");
        foreach (var car in selectedCars)
        {
            Console.WriteLine($"{car.Model}: Ціна - {car.Price}, Рік - {car.Year}, Країна виробництва - {car.MadeIn}");
        }

        if (cheapestCar != null)
        {
            Console.WriteLine($"\nНайдешевший автомобіль: {cheapestCar.Model} за {cheapestCar.Price}.");
        }
    }
}
