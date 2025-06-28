using System;

namespace DomaciSpravce
{
    class Program
    {
        static void Main(string[] args)
        {
            SpravceUkolu spravce = new SpravceUkolu();
            bool pokracovat = true;

            while (pokracovat)
            {
                Console.WriteLine("\nDomácí správce - nabídka:");
                Console.WriteLine("1 - Přidat úkol");
                Console.WriteLine("2 - Vypsat všechny úkoly");
                Console.WriteLine("3 - Vyhledat úkol");
                Console.WriteLine("4 - Označit úkol jako hotový");
                Console.WriteLine("5 - Zobrazit statistiky");
                Console.WriteLine("0 - Konec");
                Console.Write("Vyberte možnost: ");

                switch (Console.ReadLine())
                {
                    case "1":
                        spravce.PridatUkol();
                        break;
                    case "2":
                        spravce.VypsatUkoly();
                        break;
                    case "3":
                        spravce.VyhledatUkol();
                        break;
                    case "4":
                        spravce.DokoncitUkol();
                        break;
                    case "5":
                        spravce.ZobrazitStatistiky();
                        break;
                    case "0":
                        pokracovat = false;
                        break;
                    default:
                        Console.WriteLine("Neplatná volba.");
                        break;
                }
            }

            Console.WriteLine("Děkujeme za použití aplikace Domácí Správce.");
        }
    }
}
