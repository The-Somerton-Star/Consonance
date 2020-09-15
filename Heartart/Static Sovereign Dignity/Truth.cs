using System;
using System.Collections.Generic;
using System.Text;

namespace Heartart.Static_Sovereign_Dignity
{
    public class Truth
    {
        public Truth(Attityd wisdom)
        {
            Wisdom = new Wisdom(wisdom);
        }
        public Wisdom Wisdom { get; }
    }
}
