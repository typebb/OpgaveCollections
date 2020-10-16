using System;
using System.Collections.Generic;
using System.Text;

namespace OpgaveCollections
{
    class Haven
    {
        public string HavenNaam { get; set; }
        public Haven(string havenNaam)
        {
            HavenNaam = havenNaam;
        }
        public override string ToString()
        {
            return $"Haven Naam: {HavenNaam}";
        }
        public override bool Equals(object obj)
        {
            if (obj is Haven)
                return (this.HavenNaam == ((Haven)obj).HavenNaam);
            else return false;
        }
        public override int GetHashCode()
        {
            return HavenNaam.GetHashCode();
        }
        public int CompareTo(object ander)
        {
            if (!ReferenceEquals(ander, null))
            {
                if (ander is Haven)
                {
                    Haven ditHaven = this;
                    Haven anderHaven = ander as Haven;
                    int compareteTo = ditHaven.HavenNaam.CompareTo(anderHaven.HavenNaam);
                    return compareteTo;
                }
                else throw new ArgumentException($"Object must be of type {nameof(Haven)}");
            }
            else return +1;
        }
        public int CompareTo(Haven haven)
        {
            if (!ReferenceEquals(haven, null))
            {
                int compareteTo = HavenNaam.CompareTo(haven.HavenNaam);
                return compareteTo;
            }
            else return +1;
        }
    }
}
