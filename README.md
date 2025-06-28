# Domácí Správce 

Tento projekt je konzolová aplikace v jazyce C#, která slouží ke správě domácích úkolů a činností – například úklid, plánování úkolů, kontrola splnění atd.
 Funkce aplikace

- Přidání nového úkolu (název, popis, termín)
- Výpis všech úkolů seřazených podle termínu
- Vyhledání úkolu podle klíčového slova
- Označení úkolu jako hotového
- Zobrazení statistiky: počet splněných a nesplněných úkolů

 Ošetření vstupů

- Ošetření chybného formátu datumu pomocí `DateTime.TryParse`
- Kontrola, zda nejsou zadané prázdné hodnoty

Použité prvky z kurzu

- Třídy, vlastnosti (`string`, `int`, `DateTime`, `bool`)
- Metody, podmínky (`if`, `switch`, `while`)
- Seznamy (`List<Ukol>`)
- Práce s datem (`DateTime`)
- Práce se stringy (`Contains`)
- LINQ: `Where`, `OrderBy`, `Count`, `FirstOrDefault`

Spuštění

1. Otevřete projekt v prostředí Visual Studio nebo VS Code.
2. Spusťte `Program.cs`.
3. Řiďte se konzolovým menu.

 Struktura souborů

- `Program.cs` – hlavní spuštěcí třída
- `SpravceUkolu.cs` – logika pro správu úkolů
- `Ukol.cs` – definice třídy úkol

---

Projekt vytvořen v rámci závěrečného zadání C# kurzu.
