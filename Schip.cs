using System;
using System.Collections.Generic;
using System.Text;

namespace OpgaveCollections
{
    abstract class Schip : IComparable, IComparable<Schip>
    {
        public double Lengte { get; set; }
        public double Breedte { get; set; }
        public double Tonnage { get; set; }
        public string Naam { get; set; }
        public Vloot Vloot { get; set; }

        public Schip(string naam, double tonnage, double breedte, double lengte)
        {
            Naam = naam;
            Tonnage = tonnage;
            Breedte = breedte;
            Lengte = lengte;
        }
        public override string ToString()
        {
            return $"Naam: {Naam} \n Tonnage: {Tonnage} \n Breedte: {Breedte} \n Lengte: {Lengte}";
        }
        public override bool Equals(object obj)
        {
            if (obj is Schip)
                return (this.Naam == ((Schip)obj).Naam && this.Tonnage == ((Schip)obj).Tonnage &&
                        this.Breedte == ((Schip)obj).Breedte && this.Lengte == ((Schip)obj).Lengte);
            else return false;
        }
        public override int GetHashCode()
        {
            return Naam.GetHashCode() ^ Tonnage.GetHashCode() ^ Breedte.GetHashCode() ^ Lengte.GetHashCode();
        }
        public int CompareTo(object ander)
        {
            if (!ReferenceEquals(ander, null))
            {
                if (ander is Schip)
                {
                    Schip ditSchip = this;
                    Schip anderSchip = ander as Schip;
                    int compareteTo = ditSchip.Naam.CompareTo(anderSchip.Naam);
                    if (compareteTo == 0) compareteTo = ditSchip.Tonnage.CompareTo(anderSchip.Tonnage);
                    if (compareteTo == 0) compareteTo = ditSchip.Breedte.CompareTo(anderSchip.Breedte);
                    if (compareteTo == 0) compareteTo = ditSchip.Lengte.CompareTo(anderSchip.Lengte);
                    return compareteTo;
                }
                else throw new ArgumentException($"Object must be of type {nameof(Schip)}");
            }
            else return +1;
        }
        public int CompareTo(Schip schip)
        {
            if (!ReferenceEquals(schip, null))
            {
                  int compareteTo = Naam.CompareTo(schip.Naam);
                  if (compareteTo == 0) compareteTo = Tonnage.CompareTo(schip.Tonnage);
                  if (compareteTo == 0) compareteTo = Breedte.CompareTo(schip.Breedte);
                  if (compareteTo == 0) compareteTo = Lengte.CompareTo(schip.Lengte);
                  return compareteTo;
            }
            else return +1;
        }
    }
}
