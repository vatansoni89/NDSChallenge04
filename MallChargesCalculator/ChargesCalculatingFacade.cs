using System;

namespace MallChargesCalculator
{
    public class ChargesCalculatingFacade
    {
        private RentableRepository _rentableRepository = new RentableRepository();

        public void DisplayRentingCharges(int id)
        {
            var rentable = _rentableRepository.GetRentableOrNull(id);
            if (rentable == null)
            {
                Console.WriteLine("The item is not found");
                return;
            }
            Console.WriteLine("The Item is " + rentable.GetType().Name);
            Console.WriteLine("The Id is " + rentable.Id);
            Console.WriteLine("The Renting Charges are " + rentable.Rent);
            Console.WriteLine("The Electricty Charges are " + rentable.ElectricityCharges);
            Console.WriteLine("The Water Charges are " + rentable.WaterCharges);
            Console.WriteLine("The Cleaning Charges are " + rentable.CleaningCharges);
        }

        //private int GetRentingCharges(IRentable rentable)
        //{
        //    if (rentable.GetType().Name == typeof(ShowRoom).Name)
        //    {
        //        return ((ShowRoom)(rentable)).Rent;
        //    }

        //    return 0;
        //}

        //private int GetWaterCharges(IRentable rentable)
        //{
        //    if (rentable.GetType().Name == typeof(ShowRoom).Name)
        //    {
        //        return ((ShowRoom)(rentable)).WaterCharges;
        //    }

        //    return 0;
        //}

        //private int GetElectricityCharges(IRentable rentable)
        //{
        //    return 0;
        //}

        //private int GetCleaningCharges(IRentable rentable)
        //{
        //    return 0;
        //}
    }
}