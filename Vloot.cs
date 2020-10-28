using System;
using System.Collections.Generic;
using System.Text;

namespace OpgaveCollections
{
    class Vloot : IComparable, IComparable<Vloot>
    {
        public string VlootNaam { get; set; }
        private Dictionary<string, Schip> schepenLijst = new Dictionary<string, Schip>();
        public Vloot(string vlootNaam)
        {
            VlootNaam = vlootNaam;
        }
        public override int GetHashCode()
        {
            return VlootNaam.GetHashCode();
        }
        public override bool Equals(object obj)
        {
            if (obj is Vloot)
                return (this.VlootNaam == ((Vloot)obj).VlootNaam);
            else return false;
        }
        public int CompareTo(object ander)
        {
            if (!ReferenceEquals(ander, null))
            {
                if (ander is Vloot)
                {
                    Vloot ditVloot = this;
                    Vloot anderVloot = ander as Vloot;
                    int compareteTo = ditVloot.VlootNaam.CompareTo(anderVloot.VlootNaam);
                    return compareteTo;
                }
                else throw new ArgumentException($"Object must be of type {nameof(Vloot)}");
            }
            else return +1;
        }
        public int CompareTo(Vloot vloot)
        {
            if (!ReferenceEquals(vloot, null))
            {
                int compareteTo = VlootNaam.CompareTo(vloot.VlootNaam);
                return compareteTo;
            }
            else return +1;
        }
        public void VoegSchipToe(Schip schip)
        {
            if (!schepenLijst.ContainsKey(schip.Naam))
            {
                schepenLijst.Add(schip.Naam, schip);
                schip.Vloot = this;
            }
        }
        public void VerwijderSchip(Schip schip)
        {
            if (schepenLijst.ContainsKey(schip.Naam))
            {
                schepenLijst.Remove(schip.Naam);
                schip.Vloot = null;
            }
        }
        public Schip ZoekSchipOp(string schipNaam)
        {
            if (schepenLijst.ContainsKey(schipNaam))
            return schepenLijst[schipNaam];
            return null;
        }
        public string OverzichtSchepenInVloot()
        {
            if (schepenLijst.Count == 0) return null;
            return string.Join(", \n", schepenLijst);
        }
        public List<Schip> GetSchepenLijst()
        {
            List<Schip> schepen = new List<Schip>();
            foreach (KeyValuePair<string, Schip> s in schepenLijst)
                schepen.Add(s.Value);
            return schepen;
        }
        public int Passagiers()
        {
            int passagiers = 0;
            foreach (Schip s in schepenLijst.Values)
                if (s is PassagierSchip) passagiers += ((PassagierSchip)s).AantalPassagiers;
            return passagiers;
        }
        public double Tonnage()
        {
            double tonnage = 0;
            foreach (Schip s in schepenLijst.Values)
                tonnage += s.Tonnage;
            return tonnage;
        }
        public double VolumeVanTankers()
        {
            double volume = 0;
            foreach (Schip s in schepenLijst.Values)
                if (s is Tanker) volume += ((Tanker)s).Volume;
            return volume;
        }
        public int AantalSleepboten()
        {
            int sleepboten = 0;
            foreach (Schip s in schepenLijst.Values)
                if (s is Sleepboot) sleepboten++;
            return sleepboten;
        }
    }
}
