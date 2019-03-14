using System;

namespace SOLIDLab.Emailer
{
	// Emailer class implements the WeatherAlert interface
    public class Emailer : IWeatherAlert
    {
        public String GenerateWeatherAlert(String weatherConditions)
        {
            String alert = "It is " + weatherConditions;
            return alert;
        }
    }

}

