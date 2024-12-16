using System;
using System.Collections.Generic;
using System.Linq;

class four
{
    static void Main()
    {
        List<string> domains = new List<string>
        {
            "ukr.net", "ukr.com", "google.net", "ukrainsky.net", "ukr-news.net",
            "meta.ua", "yahoo.com", "ukr-music.net", "ukrtech.net", "test.com"
        };

        var selectedDomains = from domain in domains
                              where domain.StartsWith("ukr") && domain.EndsWith(".net")
                              select domain;

        Console.WriteLine("Відібрані домени:");
        foreach (var domain in selectedDomains)
        {
            Console.WriteLine(domain);
        }
    }
}
