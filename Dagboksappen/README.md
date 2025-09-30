# Dagboksapp i C#

## Vad �r detta?

Detta �r en enkel dagboksapplikation skriven i C# som k�rs i terminalen. Med appen kan du:

- Skriva nya dagboksanteckningar
- Lista alla sparade anteckningar
- S�ka anteckningar efter datum
- Spara anteckningar till en fil (`diary.json`)
- L�sa in anteckningar fr�n en fil

Syftet med projektet �r att l�ra sig grunderna i C#, inklusive:
- Listor
- Filhantering
- JSON-serialisering
- Datumhantering
- Anv�ndarinteraktion via konsolen

---

##  Hur man k�r det

1. **Krav:**
   - .NET SDK (t.ex. .NET 6 eller senare)
   - Windows, macOS eller Linux med terminal/konsolf�nster

2. **S� h�r k�r du programmet:**

```bash
# Klona eller ladda ner projektet
cd din-mapp

# Kompilera programmet
dotnet build

# K�r programmet
dotnet run
	 Struktur och uppbyggnad
Projektet best�r av f�ljande delar:

Program.cs � Huvudprogrammet. Hanterar menyer, anv�ndarinmatning och logik.

DiaryEntry.cs � En enkel klass som representerar en dagboksanteckning med datum och text.

diary.json � Fil d�r anteckningar sparas i JSON-format (skapas automatiskt).

Funktioner i menyn:
Val	Funktion
1	Skapa ny anteckning
2	Lista alla anteckningar
3	S�k anteckning p� specifikt datum
4	Spara alla anteckningar till fil
5	L�s in anteckningar fr�n fil
6	Avsluta programmet

	 Hur man installerar
Installera .NET SDK om du inte redan har det.

Ladda ner projektfilerna eller klona repot.

Navigera till projektmappen i terminalen.

K�r med dotnet run.

	 Versionshistorik
Version	Datum	�ndringar
1.0	2025-09-30	F�rsta versionen av dagboken med grundl�ggande funktioner
1.1	(kommande)	Planerat st�d f�r redigering och borttagning av anteckningar

