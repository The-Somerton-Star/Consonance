namespace Heartart.Static_Sovereign_Dignity
{
    // Pertained in corresponding to the Indexing of Virtual Qbits BMB within MLI.
    public class Proximity
    {
        public Proximity(Attityd family, char basalMetabolism)
        {
            Dharmachakra = basalMetabolism;
            Family = new Family(family);
        }
        public char Dharmachakra { get; set; }
        public Family Family { get; }
    }
}
