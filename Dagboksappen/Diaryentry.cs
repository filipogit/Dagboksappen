using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text.Json;
using Diaryentry;

class Program
{
    static List<DiaryEntry> diaryEntries = new List<DiaryEntry>();
    const string fileName = "diary.json";

    static void Main()
    {
        while (true)
        {
            Console.WriteLine("\n----- DAGBOK -----");
            Console.WriteLine("1. Skriv ny anteckning");
            Console.WriteLine("2. Lista alla anteckningar");
            Console.WriteLine("3. Sök anteckning på datum");
            Console.WriteLine("4. Spara till fil");
            Console.WriteLine("5. Läs från fil");
            Console.WriteLine("6. Avsluta");
            Console.Write("Välj ett alternativ: ");

            string choice = Console.ReadLine();
            switch (choice)
            {
                case "1":
                    SkrivNyAnteckning();
                    break;
                case "2":
                    ListaAllaAnteckningar();
                    break;
                case "3":
                    SökAnteckningPåDatum();
                    break;
                case "4":
                    SparaTillFil();
                    break;
                case "5":
                    LäsFrånFil();
                    break;
                case "6":
                    Console.WriteLine("Avslutar programmet...");
                    return;
                default:
                    Console.WriteLine("Ogiltigt val. Försök igen.");
                    break;
            }
        }
    }

    static void SkrivNyAnteckning()
    {
        Console.Write("Skriv din anteckning: ");
        string text = Console.ReadLine();
        diaryEntries.Add(new DiaryEntry { Date = DateTime.Now, Text = text });
        Console.WriteLine("Anteckning sparad.");
    }

    static void ListaAllaAnteckningar()
    {
        if (diaryEntries.Count == 0)
        {
            Console.WriteLine("Inga anteckningar finns.");
            return;
        }

        foreach (var entry in diaryEntries)
        {
            Console.WriteLine($"\nDatum: {entry.Date}");
            Console.WriteLine($"Text: {entry.Text}");
        }
    }

 