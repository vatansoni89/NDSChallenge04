namespace MallChargesCalculator
{
    public class Parking : IRentable
    {
        public int Id { get; set; }
        public int CarCapacity { get; set; }
        public int MotorBikeCapacity { get; set; }

        public int Rent
        {
            get { return CarCapacity * 300 + MotorBikeCapacity * 50; }
        }

        public int WaterCharges
        {
            get { return CarCapacity * 1 + MotorBikeCapacity * 5; }
        }

        public int ElectricityCharges
        {
            get { return 1000; }
        }

        public int CleaningCharges
        {
            get { return 2000; }
        }
    }
}