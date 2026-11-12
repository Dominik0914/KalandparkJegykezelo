using System;
using System.Collections.Generic;
using System.Text;

namespace KalandparkJegykezelo
{
    public class Jegyvasarlas
    {
        public string LatogatoNeve { get; set; }
        public int Felnottjegyek { get; set; }
        public int Gyerekjegyek { get; set; }

        public Jegyvasarlas(string sor)
        {
            string[] var = sor.Split(";");
            LatogatoNeve = var[0];
            Felnottjegyek = int.Parse(var[1]);
            Gyerekjegyek = int.Parse(var[2]);
        }
        public int FizetendoOsszeg()
        {
            return Felnottjegyek * 4000 + Gyerekjegyek * 2500;
        }
        public override string ToString()
        {
            return $"{LatogatoNeve}: {Felnottjegyek} felnőtt, {Gyerekjegyek} gyerek jegy - Fizetendő: {FizetendoOsszeg()} Ft";
        }
    }
}
