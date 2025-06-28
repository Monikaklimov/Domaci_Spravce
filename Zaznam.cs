using System;

namespace DomaciSpravce
{
    public abstract class Zaznam
    {
        public string Nazev { get; set; }
        public abstract void VypisUkol();
    }
}
