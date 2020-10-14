using System;
using System.Collections.Generic;
using System.Text;

namespace OpgaveCollections
{
    class Veerboot : Schip
    {
        public int AantalPassagiers { get; set; }
        LinkedList<Haven> traject = new LinkedList<Haven>();
    }
}
