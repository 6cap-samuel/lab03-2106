using System;

namespace SOLIDLab.Emailer
{
    public class Emailer : IWeatherAlert
    {
        public String GenerateWeatherAlert(String weatherConditions)
        {
            String alert = "It is " + weatherConditions;
            return alert;
        }
    }

}

