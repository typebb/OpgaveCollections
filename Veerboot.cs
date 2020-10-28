using System;
using System.Collections.Generic;
using System.Text;

namespace OpgaveCollections
{
    class Veerboot : PassagierSchip
    {
        public Veerboot(string naam, double tonnage, double breedte, double lengte, int aantalPassagiers) : base(naam, tonnage, breedte, lengte, aantalPassagiers)
        {
            Naam = naam;
            Tonnage = tonnage;
            Breedte = breedte;
            Lengte = lengte;
            AantalPassagiers = aantalPassagiers;
        }
    }
}
