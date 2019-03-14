using System;

namespace SOLIDLab.Emailer
{
	// Creating a new WeatherAlert interface that holds the GenerateWeatherAlert method
	// that is common to both the Phone and Email classes
    public interface IWeatherAlert
    {
        String GenerateWeatherAlert(String weatherConditions);
    }
}
