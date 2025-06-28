using System;

namespace DomaciSpravce
{
    class Program
    {
        static void Main(string[] args)
        {
            SpravceUkolu spravce = new SpravceUkolu();
            spravce.NactiUkoly();

            bool pokracovat = true;
            while (pokracovat)
            {
                Console.WriteLine("\n📌 MENU:");
                Console.WriteLine("1 - Přidat úkol");
                Console.WriteLine("2 - Vypsat všechny úkoly");
                Console.WriteLine("3 - Uložit úkoly");
                Console.WriteLine("4 - Konec");

                Console.Write("Zadej volbu: ");
                string volba = Console.ReadLine();

                switch (volba)
                {
                    case "1":
                        Ukol novy = new Ukol();

                        Console.Write("Zadej název: ");
                        novy.Nazev = Console.ReadLine();

                        Console.Write("Zadej popis: ");
                        novy.Popis = Console.ReadLine();

                        Console.Write("Zadej termín (RRRR-MM-DD): ");
                        novy.Termin = DateTime.Parse(Console.ReadLine());

                        Console.Write("Je hotovo? (ano/ne): ");
                        novy.JeHotovo = Console.ReadLine().ToLower() == "ano";

                        spravce.PridatUkol(novy);
                        break;

                    case "2":
                        spravce.VypisVsechnyUkoly();
                        break;

                    case "3":
                        spravce.UlozUkoly();
                        Console.WriteLine("✅ Úkoly byly uloženy.");
                        break;

                    case "4":
                        pokracovat = false;
                        spravce.UlozUkoly();
                        Console.WriteLine("👋 Konec programu.");
                        break;

                    default:
                        Console.WriteLine("Neplatná volba.");
                        break;
                }
            }
        }
    }
}
