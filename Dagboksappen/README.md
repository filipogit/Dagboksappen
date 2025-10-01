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


Exempel p� inmatning I/O
V�lj ett alternativ: 1
Skriv din anteckning: Tr�ffade en gammal v�n idag!
Anteckning sparad.


Exempel p� utmatning I/O
V�lj ett alternativ: 2

Datum: 2025-09-30 14:32
Text: Tr�ffade en gammal v�n idag!


Kort reflektion

Jag valde att anv�nda en List<DiaryEntry> eftersom det �r en enkel och effektiv datastruktur f�r att lagra anteckningar i ordning.
Som I/O-format anv�nde jag JSON, vilket �r b�de l�ttl�st och enkelt att hantera med System.Text.Json.
Det g�r programmet l�tt att ut�ka, till exempel f�r webb- eller mobilappar.

Fel hanteras med try/catch vid filoperationer f�r att f�nga vanliga fel som saknade filer eller felaktigt inneh�ll. 
Datum valideras med DateTime.TryParseExact, och tomma anteckningar till�ts inte.
Syftet har varit att skapa ett stabilt program med tydliga felmeddelanden.


	 Versionshistorik
Version	Datum	�ndringar
1.0	2025-09-30	F�rsta versionen av dagboken med grundl�ggande funktioner
1.1	(kommande)	Planerat st�d f�r redigering och borttagning av anteckningar

