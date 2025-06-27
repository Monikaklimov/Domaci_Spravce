using System;

namespace DomaciSpravce
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Vítejte v aplikaci Domácí Správce!");

            Ukol ukol1 = new Ukol
            {
                Nazev = "Uklidit pokoj",
                Popis = "Vysát, utřít prach, vytřít podlahu",
                Termin = DateTime.Now.AddDays(2),
                JeHotovo = false
            };

            ukol1.VypisUkol();
        }
    }
}
