namespace SOLIDLab.Birds
{
    public class Eagle : Bird
    {
        private string CurrentLocation;
        private int NumberOfFeathers;

        public Eagle(int initialFeatherCount)
        {
            NumberOfFeathers = initialFeatherCount;
        }

        public void fly()
        {
            CurrentLocation = "in the air";
        }

        public void molt()
        {
            NumberOfFeathers -= 1;
        }
    }
}