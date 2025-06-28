using System;
using System.Collections.Generic;
using System.Linq;

namespace DomaciSpravce
{
    // Spravuje seznam úkolů a operace nad nimi
    public class SpravceUkolu
    {
        private List<Ukol> ukoly = new List<Ukol>();

        public void PridatUkol()
        {
            Console.Write("Zadejte název úkolu: ");
            string nazev = Console.ReadLine();

            Console.Write("Zadejte popis: ");
            string popis = Console.ReadLine();

            Console.Write("Zadejte termín (např. 25.12.2025): ");
            string vstup = Console.ReadLine();
            DateTime termin;
            if (!DateTime.TryParse(vstup, out termin))
            {
                Console.WriteLine("Neplatný formát datumu. Úkol nebude přidán.");
                return;
            }

            ukoly.Add(new Ukol { Nazev = nazev, Popis = popis, Termin = termin, JeHotovo = false });
            Console.WriteLine("Úkol byl přidán.");
        }

        public void VypsatUkoly()
        {
            if (ukoly.Count == 0)
            {
                Console.WriteLine("Zatím žádné úkoly.");
                return;
            }

            foreach (var u in ukoly.OrderBy(u => u.Termin))
            {
                u.VypisUkol();
            }
        }

        public void VyhledatUkol()
        {
            Console.Write("Zadejte klíčové slovo: ");
            string klic = Console.ReadLine();
            var nalezene = ukoly.Where(u => u.Nazev.Contains(klic, StringComparison.OrdinalIgnoreCase)
                                          || u.Popis.Contains(klic, StringComparison.OrdinalIgnoreCase));
            foreach (var u in nalezene)
            {
                u.VypisUkol();
            }
        }

        public void DokoncitUkol()
        {
            Console.Write("Zadejte název úkolu k označení jako hotový: ");
            string jmeno = Console.ReadLine();
            var ukol = ukoly.FirstOrDefault(u => u.Nazev.Equals(jmeno, StringComparison.OrdinalIgnoreCase));

            if (ukol != null)
            {
                ukol.JeHotovo = true;
                Console.WriteLine("Úkol byl označen jako hotový.");
            }
            else
            {
                Console.WriteLine("Úkol nenalezen.");
            }
        }

        public void ZobrazitStatistiky()
        {
            int celkem = ukoly.Count;
            int hotove = ukoly.Count(u => u.JeHotovo);
            int zbyva = celkem - hotove;
            Console.WriteLine($"Celkem úkolů: {celkem}, Hotové: {hotove}, Zbývá: {zbyva}");
        }
    }
}
