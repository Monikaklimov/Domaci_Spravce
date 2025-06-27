using System;
using System.Collections.Generic;

namespace DomaciSpravce
{
    public class SpravceUkolu
    {
        private List<Ukol> ukoly = new List<Ukol>();

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
    }
}
