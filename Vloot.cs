using System;
using System.Collections.Generic;
using System.Text;

namespace OpgaveCollections
{
    class Vloot
    {
        public string VlootNaam { get; set; }
        public List<Schip> schepenLijst = new List<Schip>();
        public void VoegSchipToe(Schip schip)
        {
            Schip gevondenSchip = schepenLijst.Find(f => f == schip);
            if (gevondenSchip == null) schepenLijst.Add(schip);
            else throw new ArgumentException("Schip zit al in de vloot.");
        }
        public void VerwijderSchip(Schip schip)
        {
            Schip gevondenSchip = schepenLijst.Find(f => f == schip);
            if (gevondenSchip != null) schepenLijst.Remove(schip);
            else throw new ArgumentException("Schip zit niet in de vloot.");
        }
        public Schip ZoekSchipOp(Schip schip)
        {
            Schip gevondenSchip = schepenLijst.Find(f => f.Naam == schip.Naam);
            if (gevondenSchip != null) return gevondenSchip;
            else throw new ArgumentException("Schip niet gevonden in de vloot.");
        }
        public string OverzichtSchepenInVloot(Schip schip)
        {
            if (schepenLijst.Count == 0) throw new ArgumentException("Geen schepen in de vloot.");
            StringBuilder overzicht = new StringBuilder();
            foreach (Schip s in schepenLijst) overzicht.Append(s.ToString());
            string overzichtSchepen = overzicht.ToString();
            return overzichtSchepen;
        }
    }
}
