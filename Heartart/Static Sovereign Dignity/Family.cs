namespace Heartart.Static_Sovereign_Dignity
{
    public class Family
    {
        public Family(Attityd benevolence)
        {
            Benevolence = new Benevolence(benevolence);
        }

        public Benevolence Benevolence { get; }
    }
}
