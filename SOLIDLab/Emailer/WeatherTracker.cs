using System;

namespace SOLIDLab.Emailer
{
    public class WeatherTracker
    {
    	// Separated the Phone and Email objects within the class inorder to 
    	// reduce the amount of dependencies needed by the WeatherTracker class
    	// replacing it with an Interface, IWeatherAlert
        String CurrentConditions;
        IWeatherAlert weatherAlert;

        public WeatherTracker()
        {
        }

        public void SetCurrentConditions(String weatherDescription)
        {
            this.CurrentConditions = weatherDescription;
            // Depending on the original use case of validating rainy or sunny days,
            // Instantiate the weatherAlert interface with the appropriate class
            if (weatherDescription == "rainy")
            {
                weatherAlert = new Phone();
                String alert = weatherAlert.GenerateWeatherAlert(weatherDescription);
                Console.WriteLine(alert);
            }

            if (weatherDescription == "sunny")
            {
                weatherAlert = new Emailer();
                String alert = weatherAlert.GenerateWeatherAlert(weatherDescription);
                Console.WriteLine(alert);
            }
        }
    }
}
