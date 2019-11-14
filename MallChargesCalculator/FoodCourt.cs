namespace MallChargesCalculator
{
    public class FoodCourt : IRentable
    {
        public int NumberOfCounters { get; set; }
        public int Id { get; set; }
        public int SeatingCapacity { get; set; }

        public int Rent
        {
            get { return NumberOfCounters * 10000 + SeatingCapacity * 300; }
        }

        public int WaterCharges
        {
            get { return NumberOfCounters * 100 + SeatingCapacity * 10; }
        }

        public int ElectricityCharges
        {
            get { return NumberOfCounters * 100 + SeatingCapacity * 6; }
        }

        public int CleaningCharges
        {
            get { return SeatingCapacity * 25; }
        }
    }
}