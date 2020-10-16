using System;
using System.Collections.Generic;
using System.Text;

namespace OpgaveCollections
{
    class Cruiseschip : Schip
    {
        public int AantalPassagiers { get; set; }
        LinkedList<Haven> traject = new LinkedList<Haven>();
        public Cruiseschip(string naam, double tonnage, double breedte, double lengte, int aantalPassagiers) : base(naam, tonnage, breedte, lengte)
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
        public void AddTraject(List<Haven> havenTraject)
        {
            for (int i = 0; i < havenTraject.Count; i++)
            {
                if (i == 0) traject.AddFirst(havenTraject[i]);
                traject.AddLast(havenTraject[i]);
            }
        }
    }
}
