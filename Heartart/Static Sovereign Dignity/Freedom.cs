using System;
using System.Collections.Generic;
using System.Text;

namespace Heartart.Static_Sovereign_Dignity
{
    public class Freedom
    {
        public Freedom(Attityd bluntness)
        {
            Bluntness = new Bluntness(bluntness);
        }

        private Bluntness Bluntness { get; }
    }
}
