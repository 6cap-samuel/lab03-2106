using System;

namespace SOLIDLab.Emailer
{
    public class WeatherTracker
    {
        String CurrentConditions;
        IWeatherAlert weatherAlert;

        public WeatherTracker()
        {
        }

        public void SetCurrentConditions(String weatherDescription)
        {
            this.CurrentConditions = weatherDescription;
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
