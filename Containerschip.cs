﻿using System;
using System.Collections.Generic;
using System.Text;

namespace OpgaveCollections
{
    class Containerschip : Schip
    {
        public int AantalContainers { get; set; }
        public double CargoWaarde { get; set; }
        public Containerschip(string naam, double tonnage, double breedte, double lengte, double cargoWaarde, int aantalContainers) : base(naam, tonnage, breedte, lengte)
        {
            Naam = naam;
            Tonnage = tonnage;
            Breedte = breedte;
            Lengte = lengte;
            CargoWaarde = cargoWaarde;
            AantalContainers = aantalContainers;
        }
        public override string ToString()
        {
            return $"Naam: {Naam} \n Tonnage: {Tonnage} \n Breedte: {Breedte} \n Lengte: {Lengte} \n Cargo Waarde: {CargoWaarde} \n Aantal Containers: {AantalContainers}";
        }
    }
}
