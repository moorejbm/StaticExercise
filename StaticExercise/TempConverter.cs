using System;
using System.Collections.Generic;
using System.Text;

namespace StaticExercise
{
    public static class TempConverter
    {
        public static double FahrenheitToCelsius(double fahernheit)
        {

            var results =  (fahernheit - 32) / 1.8;

            return results; 
        }

        public static double CelsiusToFahrenheit(double celsius)
        {

            var results = (celsius * 9) / 5 + 32;

            return results;
        }
    }
}
