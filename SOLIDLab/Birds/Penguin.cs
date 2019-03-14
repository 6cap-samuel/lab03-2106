using System;

namespace SOLIDLab.Birds
{
    public class Penguin : Bird, IPenguin {

        String CurrentLocation;
        int NumberOfFeathers;

    public Penguin(int initialFeatherCount)
    {
        this.NumberOfFeathers = initialFeatherCount;
    }

    public void molt()
    {
        this.NumberOfFeathers -= 1;
    }

    public void Swim()
    {
        this.CurrentLocation = "in the water";
    }
    }
}