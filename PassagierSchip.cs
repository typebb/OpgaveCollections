using System;
using System.Collections.Generic;
using System.Text;

namespace OpgaveCollections
{
    abstract class PassagierSchip : Schip
    {
        public Traject Traject { get; set; }
        public int AantalPassagiers { get; set; }
        public PassagierSchip (string naam, double tonnage, double breedte, double lengte, int aantalPassagiers) : base (naam, tonnage, breedte, lengte)
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
