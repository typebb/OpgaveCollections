using System;
using System.Collections.Generic;
using System.Text;

namespace OpgaveCollections
{
    abstract class Tanker : VrachtSchip
    {
        public double Volume { get; set; }
        public string Lading { get; set; }
        public Tanker (string naam, double tonnage, double breedte, double lengte, string lading, double volume, double cargoWaarde) : base(naam, tonnage, breedte, lengte, cargoWaarde)
        {
            Naam = naam;
            Tonnage = tonnage;
            Breedte = breedte;
            Lengte = lengte;
            Lading = lading;
            Volume = volume;
            CargoWaarde = cargoWaarde;
        }
        public override string ToString()
        {
            return $"Naam: {Naam} \n Tonnage: {Tonnage} \n Breedte: {Breedte} \n Lengte: {Lengte} \n Lading: {Lading}, \n Volume: {Volume}, \n Cargo Waarde: {CargoWaarde}";
        }
    }
}
