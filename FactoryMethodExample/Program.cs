using System;

namespace FactoryMethodExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var factory = new BicylceFactory();

            var wheel = factory.CreateWheel(25);
            var frame = factory.CreateFrame("Carbon", 6);
            var gear = factory.CreateGear(53);
            var seat = factory.CreateSeat(true);

            PrintBicycleProperties(wheel, frame, gear, seat);
        }

        private static void PrintBicycleProperties(Wheel wheel, Frame frame, Gear gear, Seat seat)
        {
            var seatComfortableString = seat.IsComfortable ? "comfortable" : "not comfortable";

            Console.WriteLine($"Bycicle has wheels of diameter {wheel.Diameter}");
            Console.WriteLine($"Bycicle has frame made of {frame.Material} and it weighs {frame.Weight}kg");
            Console.WriteLine($"Bicycle has gear with {gear.GearPinNumbers} pins");
            Console.WriteLine($"Bicycle seat is {seatComfortableString}");
        }
    }
}
