using System;
using System.Collections.Generic;

class Personal
{
    // Attribut för personal
    public string förnamn { get; set; }
    public string efternamn { get; set; }
    public int lön { get; set; }

    // För att skapa ny anställd
    public Personal(string förnamn, string efternamn, int lön)
    {
        this.förnamn = förnamn;
        this.efternamn = efternamn;
        this.lön = lön;
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Inital personal
        List<Personal> anställda = new List<Personal>
        {
            new Personal("Anna", "Al", 360000),
            new Personal("Bengt", "Behr", 330000),
            new Personal("Chris", "Cohn", 350000)
        };

        // Ny person i listan:
        Console.WriteLine("För-, efternamn och lön för ny person (mellanslag):");
        string input = Console.ReadLine();

        // Splitta insträng vid blankspace
        string[] delar = input.Split(' ');

        // Lägg till ny
        anställda.Add(new Personal(delar[0], delar[1], int.Parse(delar[2])));

        // Tom "mellanrad" i utskrift

        Console.WriteLine(" ");


        // Skriv ut
        foreach (var personal in anställda)
        {
            Console.WriteLine($"{personal.förnamn} {personal.efternamn} {personal.lön}");
        }
    }
}
