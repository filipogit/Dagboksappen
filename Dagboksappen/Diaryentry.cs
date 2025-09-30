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

    static void SökAnteckningPåDatum()
    {
        Console.Write("Ange datum att söka (yyyy-MM-dd): ");
        string input = Console.ReadLine();

        if (DateTime.TryParseExact(input, "yyyy-MM-dd", CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime date))
        {
            var foundEntries = diaryEntries.FindAll(e => e.Date.Date == date.Date);
            if (foundEntries.Count == 0)
            {
                Console.WriteLine("Ingen anteckning hittades för detta datum.");
            }
            else
            {
                foreach (var entry in foundEntries)
                {
                    Console.WriteLine($"\nDatum: {entry.Date}");
                    Console.WriteLine($"Text: {entry.Text}");
                }
            }
        }
        else
        {
            Console.WriteLine("Felaktigt datumformat.");
        }
    }

    static void SparaTillFil()
    {
        try
        {
            string json = JsonSerializer.Serialize(diaryEntries, new JsonSerializerOptions { WriteIndented = true });
            File.WriteAllText(fileName, json);
            Console.WriteLine("Anteckningar sparade till fil.");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Fel vid sparande: {ex.Message}");
        }
    }

    static void LäsFrånFil()
    {
        try
        {
            if (!File.Exists(fileName))
            {
                Console.WriteLine("Filen finns inte.");
                return;
            }

            string json = File.ReadAllText(fileName);
            diaryEntries = JsonSerializer.Deserialize<List<DiaryEntry>>(json);

            if (diaryEntries == null)
            {
                diaryEntries = new List<DiaryEntry>();
                Console.WriteLine("Ingen giltig data i filen.");
            }
            else
            {
                Console.WriteLine("Anteckningar laddade från fil.");
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Fel vid läsning: {ex.Message}");
        }
    }
}