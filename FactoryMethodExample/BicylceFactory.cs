namespace FactoryMethodExample
{
    public class BicylceFactory
    {
        public Wheel CreateWheel(int diameter)
        {
            return new Wheel(diameter);
        }

        public Frame CreateFrame(string material, int weight)
        {
            return new Frame(material, weight);
        }

        public Gear CreateGear(int gearPinNumbers)
        {
            return new Gear(gearPinNumbers);
        }

        public Seat CreateSeat(bool isComfortable)
        {
            return new Seat(isComfortable);
        }
    }
}