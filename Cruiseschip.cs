using System;
using System.Collections.Generic;
using System.Text;

namespace OpgaveCollections
{
    class Cruiseschip : Schip
    {
        public int AantalPassagiers { get; set; }
        LinkedList<Haven> traject = new LinkedList<Haven>();
    }
}
