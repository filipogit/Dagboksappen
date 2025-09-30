using Dagboksappen;
using System;
using System.Collections.Generic;

class Program
{
    static List<DiaryEntry> diaryEntries = new List<DiaryEntry>();

    static void Main()
    {
        while (true)
        {
            Console.WriteLine("\n--- DAGBOKSAPP ---");
            Console.WriteLine("1. Skriv ny anteckning");
            Console.WriteLine("2. Lista alla anteckningar");
            Console.WriteLine("3. Sök anteckning på datum");
            Console.WriteLine("4. Spara till fil");
            Console.WriteLine("5. Läs från fil");
            Console.WriteLine("6. Avsluta");
            Console.Write("Välj ett alternativ (1-6): ");

            string val = Console.ReadLine();
            Console.WriteLine();

            switch (val)
            {
                case "1":
                    SkrivAnteckning();
                    break;
                case "2":
                    ListaAnteckningar();
                    break;
                case "3":
                    SokAnteckning();
                    break;
                case "4":
                    SparaTillFil();
                    break;
                case "5":
                    LasFranFil();
                    break;
                case "6":
                    return;
                default:
                    Console.WriteLine("Ogiltigt val. Försök igen.");
                    break;
            }
        }
    }
}