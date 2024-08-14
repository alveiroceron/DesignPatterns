namespace Adapter.RealWorld
{
    /// <summary>
    /// Chemical enumeration
    /// </summary>
    public enum Chemical
    {
        Water,
        Benzene,
        Ethanol
    }

    /// <summary>
    /// State enumeration
    /// </summary>
    public enum State
    {
        Boiling,
        Melting
    }

    /// <summary>
    /// The 'Target' class
    /// </summary>
    public class Compound
    {
        public Chemical Chemical { get; protected set; }
        public float BoilingPoint { get; protected set; }
        public float MeltingPoint { get; protected set; }
        public double MolecularWeight { get; protected set; }
        public string? MolecularFormula { get; protected set; }

        public virtual void Display()
        {
            Console.WriteLine("\nCompound: Unknown ------ ");
        }

    }
}
