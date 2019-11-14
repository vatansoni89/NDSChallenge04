namespace MallChargesCalculator
{
    public class Multiplex : IRentable
    {
        public int TotalSeatingCapacity { get; set; }
        public int Id { get; set; }
        public int NumberOfScreens { get; set; }

        public int Rent
        {
            get { return TotalSeatingCapacity * 700 + NumberOfScreens * 1000; }
        }

        public int WaterCharges
        {
            get { return TotalSeatingCapacity * 2 + NumberOfScreens * 80; }
        }

        public int ElectricityCharges
        {
            get { return TotalSeatingCapacity * 5 + NumberOfScreens * 5000; }
        }

        public int CleaningCharges
        {
            get { return TotalSeatingCapacity * 10; }
        }
    }
}