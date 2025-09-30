# Dagboksapp i C#

## Vad är detta?

Detta är en enkel dagboksapplikation skriven i C# som körs i terminalen. Med appen kan du:

- Skriva nya dagboksanteckningar
- Lista alla sparade anteckningar
- Söka anteckningar efter datum
- Spara anteckningar till en fil (`diary.json`)
- Läsa in anteckningar från en fil

Syftet med projektet är att lära sig grunderna i C#, inklusive:
- Listor
- Filhantering
- JSON-serialisering
- Datumhantering
- Användarinteraktion via konsolen

---

##  Hur man kör det

1. **Krav:**
   - .NET SDK (t.ex. .NET 6 eller senare)
   - Windows, macOS eller Linux med terminal/konsolfönster

2. **Så här kör du programmet:**

```bash
# Klona eller ladda ner projektet
cd din-mapp

# Kompilera programmet
dotnet build

# Kör programmet
dotnet run
	 Struktur och uppbyggnad
Projektet består av följande delar:

Program.cs – Huvudprogrammet. Hanterar menyer, användarinmatning och logik.

DiaryEntry.cs – En enkel klass som representerar en dagboksanteckning med datum och text.

diary.json – Fil där anteckningar sparas i JSON-format (skapas automatiskt).

Funktioner i menyn:
Val	Funktion
1	Skapa ny anteckning
2	Lista alla anteckningar
3	Sök anteckning på specifikt datum
4	Spara alla anteckningar till fil
5	Läs in anteckningar från fil
6	Avsluta programmet

	 Hur man installerar
Installera .NET SDK om du inte redan har det.

Ladda ner projektfilerna eller klona repot.

Navigera till projektmappen i terminalen.

Kör med dotnet run.

	 Versionshistorik
Version	Datum	Ändringar
1.0	2025-09-30	Första versionen av dagboken med grundläggande funktioner
1.1	(kommande)	Planerat stöd för redigering och borttagning av anteckningar

