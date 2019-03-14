using System;

namespace SOLIDLab.Birds
{
    //Penguin will implement both IPenguin and Bird
    //IPenguin has functions that only Penguin class
    //can use to implement
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

    //this function can be found in IPenguin
    //because only penguins can swim
    public void Swim()
    {
        this.CurrentLocation = "in the water";
    }
    }
}