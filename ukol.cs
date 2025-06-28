using System;

namespace DomaciSpravce
{
    // Ukol implementuje interface IVypisovatelny
    public class Ukol : IVypisovatelny
    {
        public string Nazev { get; set; }
        public string Popis { get; set; }
        public DateTime Termin { get; set; }
        public bool JeHotovo { get; set; }

        // Povinná metoda z interface IVypisovatelny
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
}
