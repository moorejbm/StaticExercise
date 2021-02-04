using System;

namespace StaticExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            var celius = TempConverter.FahrenheitToCelsius(161.6);
            var fahenheit = TempConverter.CelsiusToFahrenheit(72);

            Console.WriteLine($"celcius {celius}");
            Console.WriteLine($"Fahrenheit {fahenheit}");


        }
    }
}
 