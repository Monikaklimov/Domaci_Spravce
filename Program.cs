using System;

namespace DomaciSpravce
{
    public class Ukol
    {
        public string Nazev { get; set; }
        public string Popis { get; set; }
        public DateTime Termin { get; set; }
        public bool JeHotovo { get; set; }

        public void VypisUkol()
        {
            Console.WriteLine("---------------");
            Console.WriteLine($"Název: {Nazev}");
            Console.WriteLine($"Popis: {Popis}");
            Console.WriteLine($"Termín: {Termin.ToShortDateString()}");
            Console.WriteLine($"Hotovo: {(JeHotovo ? "Ano" : "Ne")}");
            Console.WriteLine("---------------");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Vítejte v aplikaci Domácí Správce!");

            // Ukázkový úkol
            Ukol ukol1 = new Ukol
            {
                Nazev = "Uklidit pokoj",
                Popis = "Vysát, utřít prach, vytřít podlahu",
                Termin = DateTime.Now.AddDays(2),
                JeHotovo = false
            };

            // Výpis úkolu
            ukol1.VypisUkol();
        }
    }
}
