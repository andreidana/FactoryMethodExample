namespace FactoryMethodExample
{
    public class Frame
    {
        public string Material { get; }
        public int Weight { get; }

        public Frame(string material, int weight)
        {
            Material = material;
            Weight = weight;
        }
    }
}