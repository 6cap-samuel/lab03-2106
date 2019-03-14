
namespace SOLIDLab.Units
{
    public class UnitUpgrader
    {

        public void UpgradeRooms(Apartment apartment)
        {
            apartment.squareFootage += 40;

            if (apartment.GetType()!=typeof(Studio))
                apartment.numberOfBedrooms += 1;
        }
    }

}