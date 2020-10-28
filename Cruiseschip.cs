using System;
using System.Collections.Generic;
using System.Text;

namespace OpgaveCollections
{
    class Cruiseschip : PassagierSchip
    {
        public Cruiseschip(string naam, double tonnage, double breedte, double lengte, int aantalPassagiers) : base(naam, tonnage, breedte, lengte, aantalPassagiers)
        {
            Naam = naam;
            Tonnage = tonnage;
            Breedte = breedte;
            Lengte = lengte;
            AantalPassagiers = aantalPassagiers;
        }
    }
}
