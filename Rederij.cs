using System;
using System.Collections.Generic;
using System.Text;

namespace OpgaveCollections
{
    class Rederij
    {
        public string RederijNaam { get; set; }
        List<Vloot> vlotenLijst = new List<Vloot>();
        List<Haven> havenLijst = new List<Haven>();
        public Rederij(string rederijNaam)
        {
            RederijNaam = rederijNaam;
        }
        public void VoegVlootToe(Vloot vloot)
        {
            Vloot gevondenVloot = vlotenLijst.Find(v => v == vloot);
            if (gevondenVloot == null) vlotenLijst.Add(vloot);
            else throw new ArgumentException("Vloot zit al in de Rederij.");
        }
        public void VerwijderVloot(Vloot vloot)
        {
            Vloot gevondenVloot = vlotenLijst.Find(v => v == vloot);
            if (gevondenVloot != null) vlotenLijst.Remove(gevondenVloot);
            else throw new ArgumentException("Vloot zit niet in de Rederij.");
        }
        public Vloot ZoekVlootOp(Vloot vloot)
        {
            Vloot gevondenVloot = vlotenLijst.Find(v => v.VlootNaam == vloot.VlootNaam);
            if (gevondenVloot != null) return gevondenVloot;
            else throw new ArgumentException("Vloot niet gevonden in de Rederij.");
        }
        public void VoegHavenToe(Haven haven)
        {
            Haven gevondenHaven = havenLijst.Find(h => h == haven);
            if (gevondenHaven == null) havenLijst.Add(haven);
            else throw new ArgumentException("Haven zit al in de Rederij.");
        }
        public void VerwijderHaven(Haven haven)
        {
            Haven gevondenHaven = havenLijst.Find(h => h == haven);
            if (gevondenHaven != null) havenLijst.Remove(gevondenHaven);
            else throw new ArgumentException("Haven zit niet in de Rederij.");
        }
        public string OverzichtHavensInRederij()
        {
            if (havenLijst.Count == 0) throw new ArgumentException("Geen Havens in de Rederij.");
            havenLijst.Sort();
            StringBuilder overzicht = new StringBuilder();
            foreach (Haven h in havenLijst) overzicht.Append(h.ToString());
            string overzichtHavens = overzicht.ToString();
            return overzichtHavens;
        }
        public void WijzigSchipVanVloot(string schipnaam, string vlootNaam)
        {
            Schip schip = null;
            for (int i = 0; i < vlotenLijst.Count; i++)
            {
                Schip gevondenSchip = vlotenLijst[i].schepenLijst.Find(s => s.Naam == schipnaam);
                if (gevondenSchip != null)
                {
                    Vloot gevondenVloot = vlotenLijst.Find(v => v.VlootNaam == vlootNaam);
                    if (gevondenVloot == null) throw new ArgumentException("Vloot met deze naam bestaat niet.");
                    gevondenVloot.schepenLijst.Add(gevondenSchip);
                    schip = gevondenSchip;
                    vlotenLijst[i].schepenLijst.Remove(gevondenSchip);
                    i = vlotenLijst.Count;
                }
            }
            if (schip == null) throw new ArgumentException("Schip niet gevonden in de Rederij");
        }
        public double TotaleCargoWaarde()
        {
            double cargoWaarde = 0;
            foreach (Vloot v in vlotenLijst)
            {
                foreach (Schip s in v.schepenLijst)
                {
                    if (s is Containerschip) cargoWaarde += ((Containerschip)s).CargoWaarde;
                    if (s is Gastanker) cargoWaarde += ((Gastanker)s).CargoWaarde;
                    if (s is Olietanker) cargoWaarde += ((Olietanker)s).CargoWaarde;
                    if (s is RoRoschip) cargoWaarde += ((RoRoschip)s).CargoWaarde;
                }
            }
            return cargoWaarde;
        }
        public int TotaalAantalPassagiers()
        {
            int aantalPassagiers = 0;
            foreach (Vloot v in vlotenLijst)
            {
                foreach (Schip s in v.schepenLijst)
                {
                    if (s is Cruiseschip) aantalPassagiers += ((Cruiseschip)s).AantalPassagiers;
                    if (s is Veerboot) aantalPassagiers += ((Veerboot)s).AantalPassagiers;
                }
            }
            return aantalPassagiers;
        }
        public Vloot[] TonnagePerVloot()
        {
            TonnageComparer tonnageComparer = new TonnageComparer();
            Vloot[] tonnagePerVloot = new Vloot[vlotenLijst.Count];
            for (int i = 0; i < vlotenLijst.Count; i++)
            {
                double tonnage = 0;
                foreach (Schip s in vlotenLijst[i].schepenLijst)
                {
                    tonnage += s.Tonnage;
                }
                Vloot vloot = new Vloot(vlotenLijst[i].VlootNaam) { TotaalTonnage = tonnage };
                tonnagePerVloot[i] = vloot;
            }
            Array.Sort(tonnagePerVloot, tonnageComparer);
            return tonnagePerVloot;
        }
        public double TotaalVolumeVanTankers()
        {
            double volume = 0;
            foreach (Vloot v in vlotenLijst)
            {
                foreach (Schip s in v.schepenLijst)
                {
                    if (s is Gastanker) volume += ((Gastanker)s).Volume;
                    if (s is Olietanker) volume += ((Olietanker)s).Volume;
                }
            }
            return volume;
        }
        public int BeschikbareSleepboten()
        {
            int beschikbareSleepboten = 0;
            foreach (Vloot v in vlotenLijst)
            {
                foreach (Schip s in v.schepenLijst)
                {
                    if (s is Sleepboot) beschikbareSleepboten++;
                }
            }
            return beschikbareSleepboten;
        }
        public string InfoOverSchip(string naam)
        {
            Schip schip = null;
            foreach (Vloot v in vlotenLijst)
            {
                schip = v.schepenLijst.Find(s => s.Naam == naam);
                if (schip != null) return schip.ToString();
            }
            throw new ArgumentException("Schip niet gevonden in de Rederij");
        }
    }
}
