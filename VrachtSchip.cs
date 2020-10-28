using System;
using System.Collections.Generic;
using System.Text;

namespace OpgaveCollections
{
    abstract class VrachtSchip : Schip
    {
        public double CargoWaarde { get; set; }
        public VrachtSchip(string naam, double tonnage, double breedte, double lengte, double cargoWaarde) : base(naam, tonnage, breedte, lengte)
        {
            Naam = naam;
            Tonnage = tonnage;
            Breedte = breedte;
            Lengte = lengte;
            CargoWaarde = cargoWaarde;
        }
    }
}
