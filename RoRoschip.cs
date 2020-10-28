using System;
using System.Collections.Generic;
using System.Text;

namespace OpgaveCollections
{
    class RoRoschip : VrachtSchip
    {
        public int AantalAutos { get; set; }
        public int AantalTrucks { get; set; }
        public RoRoschip(string naam, double tonnage, double breedte, double lengte, double cargoWaarde, int aantalTrucks, int aantalAutos) : base(naam, tonnage, breedte, lengte, cargoWaarde)
        {
            Naam = naam;
            Tonnage = tonnage;
            Breedte = breedte;
            Lengte = lengte;
            CargoWaarde = cargoWaarde;
            AantalTrucks = aantalTrucks;
            AantalAutos = aantalAutos;
        }
        public override string ToString()
        {
            return $"Naam: {Naam} \n Tonnage: {Tonnage} \n Breedte: {Breedte} \n Lengte: {Lengte} \n Cargo Waarde: {CargoWaarde} \n Aantal Trucks: {AantalTrucks} \n Aantal Autos: {AantalAutos}";
        }
    }
}
