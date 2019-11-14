namespace MallChargesCalculator
{
    public class Theater : IRentable
    {
        public int SeatingCapacity { get; set; }
        public int Id { get; set; }

        public int Rent
        {
            get { return SeatingCapacity * 800 + 1000; }
        }

        public int WaterCharges
        {
            get { return SeatingCapacity * 2 + 100; }
        }

        public int ElectricityCharges
        {
            get { return SeatingCapacity * 5 + 5000; }
        }

        public int CleaningCharges
        {
            get { return SeatingCapacity * 10; }
        }
    }
}