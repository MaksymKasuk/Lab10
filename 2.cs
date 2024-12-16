using System;
using System.Linq;

class two
{
    static void Main()
    {
        Console.WriteLine("Введіть текст:");
        string text = Console.ReadLine();

        Console.WriteLine("Введіть слово для пошуку:");
        string searchWord = Console.ReadLine();

        string[] words = text.Split(new[] { ' ', '.', ',', ';', ':', '?', '!' }, StringSplitOptions.RemoveEmptyEntries);

        var foundWords = from word in words
                         where word.Equals(searchWord, StringComparison.OrdinalIgnoreCase)
                         select word;

        Console.WriteLine($"Слово '{searchWord}' знайдено {foundWords.Count()} разів.");
    }
}
