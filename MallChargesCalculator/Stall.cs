namespace MallChargesCalculator
{
    public class Stall : IRentable
    {
        public int AreaInSquareFeet { get; set; }
        public int Id { get; set; }

        public int Rent
        {
            get { return AreaInSquareFeet * 200; }
        }

        public int WaterCharges
        {
            get { return AreaInSquareFeet * 6; }
        }

        public int ElectricityCharges
        {
            get { return AreaInSquareFeet * 5; }
        }

        public int CleaningCharges
        {
            get { return AreaInSquareFeet * 1; }
        }
    }
}