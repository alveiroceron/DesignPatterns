namespace Adapter.RealWorld
{
    /// <summary>
    /// The 'Adaptee' class
    /// </summary>
    public class ChemicalDatabank
    {
        // The databank 'legacy API'
        public float GetCriticalPoint(Chemical compound, State point)
        {
            // Melting Point
            if (point == State.Melting)
            {
                return compound switch
                {
                    Chemical.Water => 0.0f,
                    Chemical.Benzene => 5.5f,
                    Chemical.Ethanol => -114.1f,
                    _ => 0f,
                };
            }
            // Boiling Point
            else
            {
                return compound switch
                {
                    Chemical.Water => 100.0f,
                    Chemical.Benzene => 80.1f,
                    Chemical.Ethanol => 78.3f,
                    _ => 0f,
                };
            }
        }
        public string GetMolecularStructure(Chemical compound)
        {
            return compound switch
            {
                Chemical.Water => "H20",
                Chemical.Benzene => "C6H6",
                Chemical.Ethanol => "C2H5OH",
                _ => "",
            };
        }
        public double GetMolecularWeight(Chemical compound)
        {
            return compound switch
            {
                Chemical.Water => 18.015d,
                Chemical.Benzene => 78.1134d,
                Chemical.Ethanol => 46.0688d,
                _ => 0d
            };
        }
    }
}
