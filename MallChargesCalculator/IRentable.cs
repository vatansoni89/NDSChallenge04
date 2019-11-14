namespace MallChargesCalculator
{
    public interface IRentable
    {
        int Id { get; set; }
        int Rent { get; }
        int WaterCharges { get; }
        int ElectricityCharges { get; }
        int CleaningCharges { get; }
    }
}