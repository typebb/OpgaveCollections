using System;
using System.Collections.Generic;
using System.Text;

namespace OpgaveCollections
{
    class Traject
    {
        private LinkedList<Haven> traject = new LinkedList<Haven>();
        public void AddTrajectList(List<Haven> havenTraject)
        {
            for (int i = 0; i < havenTraject.Count; i++)
            {
                if (i == 0) traject.AddFirst(havenTraject[i]);
                traject.AddLast(havenTraject[i]);
            }
        }
        public void AddHavenToTraject(Haven haven)
        {
           if (traject.Count == 0) traject.AddFirst(haven);
           traject.AddLast(haven);
        }
        public List<Haven> GetTrajectLijst()
        {
            List<Haven> havenLijst = new List<Haven>();
            if (traject.Count != 0)
            {
                foreach (Haven h in traject)
                    havenLijst.Add(h);
                return havenLijst;
            }
            return null;
        }
    }
}
