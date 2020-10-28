using System;
using System.Collections.Generic;
using System.Text;

namespace OpgaveCollections
{
    class Rederij
    {
        public string RederijNaam { get; set; }
        private Dictionary<string, Vloot> vlotenLijst = new Dictionary<string, Vloot>();
        SortedSet<Haven> havenLijst = new SortedSet<Haven>();
        public Rederij(string rederijNaam)
        {
            RederijNaam = rederijNaam;
        }
        public void VoegVlootToe(Vloot vloot)
        {
            if (!vlotenLijst.ContainsKey(vloot.VlootNaam))
                vlotenLijst.Add(vloot.VlootNaam, vloot);
        }
        public void VerwijderVloot(Vloot vloot)
        {
            if (vlotenLijst.ContainsKey(vloot.VlootNaam))
                vlotenLijst.Remove(vloot.VlootNaam);
        }
        public Vloot ZoekVlootOp(Vloot vloot)
        {
            if (vlotenLijst.ContainsKey(vloot.VlootNaam))
                return vlotenLijst[vloot.VlootNaam];
            return null;
        }
        public void VoegHavenToe(Haven haven)
        {
            if (!havenLijst.Contains(haven))
                havenLijst.Add(haven);
        }
        public void VerwijderHaven(Haven haven)
        {
            if (havenLijst.Contains(haven))
                havenLijst.Remove(haven);
        }
        public string OverzichtHavensInRederij()
        {
            if (havenLijst.Count == 0) return null;
            return string.Join(", \n", havenLijst);
        }
        public void WijzigSchipVanVloot(string schipnaam, string vlootNaam)
        {
            Schip schip = ZoekSchip(schipnaam);
            if (schip != null)
            {
                vlotenLijst[schip.Vloot.VlootNaam].VerwijderSchip(schip);
                vlotenLijst[vlootNaam].VoegSchipToe(schip);
            }
        }
        public double TotaleCargoWaarde()
        {
            double cargoWaarde = 0;
            foreach (Vloot v in vlotenLijst.Values)
            {
                foreach (Schip s in v.GetSchepenLijst())
                {
                    if (s is VrachtSchip) cargoWaarde += ((VrachtSchip)s).CargoWaarde;
                }
            }
            return cargoWaarde;
        }
        public int TotaalAantalPassagiers()
        {
            int aantalPassagiers = 0;
            foreach (Vloot v in vlotenLijst.Values)
            {
                aantalPassagiers += v.Passagiers();
            }
            return aantalPassagiers;
        }
        public SortedDictionary<double, List<Vloot>> TonnagePerVloot()
        {
            TonnageComparer tonnageComparer = new TonnageComparer();
            SortedDictionary<double, List<Vloot>> tonnagePerVloot = new SortedDictionary<double, List<Vloot>>(tonnageComparer);
            foreach (Vloot v in vlotenLijst.Values)
            {
                double tonnage = v.Tonnage();
                if (tonnagePerVloot.ContainsKey(tonnage)) tonnagePerVloot[tonnage].Add(v);
                else tonnagePerVloot.Add(tonnage, new List<Vloot> { v });
            }
            return tonnagePerVloot;
        }
        public double TotaalVolumeVanTankers()
        {
            double totaalVolume = 0;
            foreach (Vloot v in vlotenLijst.Values)
            {
                totaalVolume += v.VolumeVanTankers();
            }
            return totaalVolume;
        }
        public int BeschikbareSleepboten()
        {
            int beschikbareSleepboten = 0;
            foreach (Vloot v in vlotenLijst.Values)
            {
                beschikbareSleepboten += v.AantalSleepboten();
            }
            return beschikbareSleepboten;
        }
        public string InfoOverSchip(string naam)
        {
            Schip s;
            if ((s = ZoekSchip(naam)) != null)
                return s.ToString();
            return null;
        }
        public Schip ZoekSchip(string schipNaam)
        {
            foreach (Vloot v in vlotenLijst.Values)
            {
                Schip s;
                if ((s = v.ZoekSchipOp(schipNaam)) != null)
                    return s;
            }
            return null;
        }
    }
}
