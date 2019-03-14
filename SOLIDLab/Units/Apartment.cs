/**
 * Created by mrk on 4/8/14.
 */

namespace SOLIDLab.Units
{
    public abstract class Apartment
    {
        public int squareFootage;
        public int numberOfBedrooms;

        public void SetSquareFootage(int sqft)
        {
            this.squareFootage = sqft;
        }
    }

}

