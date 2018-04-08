namespace FactoryMethodExample
{
    public class Seat
    {
        public bool IsComfortable { get; }

        public Seat(bool isComfortable)
        {
            IsComfortable = isComfortable;
        }
    }
}