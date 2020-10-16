using System;
using System.Collections.Generic;
using System.Text;

namespace OpgaveCollections
{
    class Sleepboot : Schip
    {
        public Sleepboot(string naam, double tonnage, double breedte, double lengte) : base(naam, tonnage, breedte, lengte)
        {
            Naam = naam;
            Tonnage = tonnage;
            Breedte = breedte;
            Lengte = lengte;
        }
    }
}
