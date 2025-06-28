using System;

namespace DomaciSpravce
{
    public class Ukol : Zaznam, IUkoloveOperace
    {
        public string Popis { get; set; }
        public DateTime Termin { get; set; }
        public bool JeHotovo { get; set; }

        public override void VypisUkol()
        {
            Console.WriteLine("---------------");
            Console.WriteLine($"Název: {Nazev}");
            Console.WriteLine($"Popis: {Popis}");
            Console.WriteLine($"Termín: {Termin.ToShortDateString()}");
            Console.WriteLine($"Hotovo: {(JeHotovo ? "Ano" : "Ne")}");
            Console.WriteLine("---------------");
        }

        public string NaRadek()
        {
            return $"{Nazev}|{Popis}|{Termin}|{JeHotovo}";
        }

        public static Ukol ZeSouboru(string radek)
        {
            var casti = radek.Split('|');
            return new Ukol
            {
                Nazev = casti[0],
                Popis = casti[1],
                Termin = DateTime.Parse(casti[2]),
                JeHotovo = bool.Parse(casti[3])
            };
        }
    }
}
