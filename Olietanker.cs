using System;
using System.Collections.Generic;
using System.Text;

namespace OpgaveCollections
{
    class Olietanker : Tanker
    {
        public Olietanker(string naam, double tonnage, double breedte, double lengte, string lading, double volume, double cargoWaarde) : base(naam, tonnage, breedte, lengte, lading, volume, cargoWaarde)
        {
            Naam = naam;
            Tonnage = tonnage;
            Breedte = breedte;
            Lengte = lengte;
            Lading = lading;
            Volume = volume;
            CargoWaarde = cargoWaarde;
        }
    }
}
