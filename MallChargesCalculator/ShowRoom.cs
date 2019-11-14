namespace MallChargesCalculator
{
    public class ShowRoom : IRentable
    {
        public int Id { get; set; }

        public int AreaInSquareFeet { get; set; }

        public int Rent
        {
            get { return AreaInSquareFeet * 80; }
        }

        public int WaterCharges
        {
            get { return AreaInSquareFeet * 4; }
        }

        public int ElectricityCharges
        {
            get { return AreaInSquareFeet * 3; }
        }

        public int CleaningCharges
        {
            get { return AreaInSquareFeet * 1; }
        }
    }
}