using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace OpgaveCollections
{
    class TonnageComparer : IComparer<double>
    {
        public int Compare(double x, double y)
        {
            if (ReferenceEquals(x, null) && ReferenceEquals(y, null)) return 0;
            if (ReferenceEquals(x, null)) return 1;
            if (ReferenceEquals(y, null)) return -1;
            if (x.CompareTo(y) == 0) return 0;
            if (x.CompareTo(y) >= 1) return -1;
            if (x.CompareTo(y) <= -1) return 1;
            return 1;
        }
    }
}
