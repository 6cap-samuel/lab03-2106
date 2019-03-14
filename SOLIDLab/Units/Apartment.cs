/**
 * Created by mrk on 4/8/14.
 */

namespace SOLIDLab.Units
{
    public abstract class Apartment
    {
        public int squareFootage;
        public int numberOfBedrooms;

        /**
         * Apartment does not need to know about IApartmentFactory
         * Another entity will inject it
         */
        IApartmentFactory factory;
        public Apartment(IApartmentFactory mFactory) {
            factory = mFactory;
        }

        public void SetSquareFootage(int sqft)
        {
            this.squareFootage = sqft;
        }
    }

}

