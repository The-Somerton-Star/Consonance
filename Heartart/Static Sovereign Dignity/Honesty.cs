using System;
using System.Collections.Generic;
using System.Text;

namespace Heartart.Static_Sovereign_Dignity
{
    public class Honesty
    {
        public Honesty(Attityd truth)
        {
            Truth = new Truth(truth);
        }

        public Truth Truth { get; }
    }
}
