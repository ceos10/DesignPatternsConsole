namespace DesignPatternsConsole.Models.Adapter
{
    public class ChemicalDatabank
    {
        public float GetCriticalPoint(string compound, string point)
        {
            if (point == "M") // Melting Point
            {
                return (compound.ToLower()) switch
                {
                    "water" => 0.0f,
                    "benzene" => 5.5f,
                    "ethanol" => -114.1f,
                    _ => 0f,
                };
            }
            else // Boiling Point
            {
                return (compound.ToLower()) switch
                {
                    "water" => 100.0f,
                    "benzene" => 80.1f,
                    "ethanol" => 78.3f,
                    _ => 0f,
                };
            }
        }

        public string GetMolecularStructure(string compound)
        {
            return (compound.ToLower()) switch
            {
                "water" => "H20",
                "benzene" => "C6H6",
                "ethanol" => "C2H5OH",
                _ => "",
            };
        }

        public double GetMolecularWeight(string compound)
        {
            return (compound.ToLower()) switch
            {
                "water" => 18.015,
                "benzene" => 78.1134,
                "ethanol" => 46.0688,
                _ => 0d,
            };
        }
    }



}
