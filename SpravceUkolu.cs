using System;
using System.Collections.Generic;
using System.IO;

namespace DomaciSpravce
{
    public class SpravceUkolu
    {
        private List<Ukol> ukoly = new List<Ukol>();
        private string soubor = "ukoly.txt";

        public void PridatUkol(Ukol novyUkol)
        {
            ukoly.Add(novyUkol);
        }

        public void VypisVsechnyUkoly()
        {
            Console.WriteLine("\n📋 Všechny úkoly:");
            foreach (var ukol in ukoly)
            {
                ukol.VypisUkol();
            }
        }

        public void UlozUkoly()
        {
            File.WriteAllLines(soubor, ukoly.ConvertAll(u => u.NaRadek()));
        }

        public void NactiUkoly()
        {
            if (File.Exists(soubor))
            {
                var radky = File.ReadAllLines(soubor);
                foreach (var r in radky)
                {
                    ukoly.Add(Ukol.ZeSouboru(r));
                }
            }
        }
    }
}
