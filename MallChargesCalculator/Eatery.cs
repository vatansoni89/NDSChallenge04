namespace MallChargesCalculator
{
    public class Eatery : IRentable
    {
        public int Id { get; set; }
        public int SeatingCapacity { get; set; }

        public int Rent
        {
            get { return SeatingCapacity * 400 + 10000; }
        }

        public int WaterCharges
        {
            get { return SeatingCapacity * 10; }
        }

        public int ElectricityCharges
        {
            get { return SeatingCapacity * 6; }
        }

        public int CleaningCharges
        {
            get { return SeatingCapacity * 25; }
        }
    }
}