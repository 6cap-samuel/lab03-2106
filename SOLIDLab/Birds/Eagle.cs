namespace SOLIDLab.Birds
{
    //Eagle will implement both IEagle and Bird
    //IEagle has functions that only Eagle class
    //can use to implement
    public class Eagle : Bird, IEagle
    {
        private string CurrentLocation;
        private int NumberOfFeathers;

        public Eagle(int initialFeatherCount)
        {
            NumberOfFeathers = initialFeatherCount;
        }

        //this function can be found in IEagle
        //because only eagles can fly
        public void fly()
        {
            CurrentLocation = "in the air";
        }

        //this function is found in Bird
        public void molt()
        {
            NumberOfFeathers -= 1;
        }
    }
}