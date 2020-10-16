﻿using System;
using System.Collections.Generic;
using System.Text;

namespace OpgaveCollections
{
    class Veerboot : Schip
    {
        public int AantalPassagiers { get; set; }
        LinkedList<Haven> traject = new LinkedList<Haven>();
        public Veerboot(string naam, double tonnage, double breedte, double lengte, int aantalPassagiers) : base(naam, tonnage, breedte, lengte)
        {
            Naam = naam;
            Tonnage = tonnage;
            Breedte = breedte;
            Lengte = lengte;
            AantalPassagiers = aantalPassagiers;
        }
        public override string ToString()
        {
            return $"Naam: {Naam} \n Tonnage: {Tonnage} \n Breedte: {Breedte} \n Lengte: {Lengte} \n Aantal Passagiers: {AantalPassagiers}";
        }
    }
}
