using System;

namespace SOLIDLab.Emailer
{
    public interface IWeatherAlert
    {
        String GenerateWeatherAlert(String weatherConditions);
    }
}
