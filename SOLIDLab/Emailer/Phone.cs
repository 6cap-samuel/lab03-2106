using System;

namespace SOLIDLab.Emailer
{
	// Phone class implements the WeatherAlert interface
    public class Phone : IWeatherAlert
    {
        public String GenerateWeatherAlert(String weatherConditions)
        {
            String alert = "It is " + weatherConditions;
            return alert;
        }
    }
}