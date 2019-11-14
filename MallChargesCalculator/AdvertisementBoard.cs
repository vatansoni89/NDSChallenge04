namespace MallChargesCalculator
{
    public class AdvertisementBoard : IRentable
    {
        public int Id { get; set; }
        public int AreaInSquareFeet { get; set; }

        public int Rent
        {
            get { return AreaInSquareFeet * 3; }
        }

        public int WaterCharges
        {
            get { return 0; }
        }

        public int ElectricityCharges
        {
            get { return AreaInSquareFeet * 10; }
        }

        public int CleaningCharges
        {
            get { return 50; }
        }
    }
}