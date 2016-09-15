using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Temperature
{
    enum Unit
    {
        Celcius,
        Fahrenheit
    }

    class Temperature
    {
        public double Fahrenheit { get; set; }
        public double Celcius { get; set; }
        public Temperature()
        {
            
        }
        public Temperature(Unit unit, double input)
        {
            switch (unit)
            {
                case Unit.Celcius:
                    Celcius = input;
                    break;
                case Unit.Fahrenheit:
                    Fahrenheit = input;
                    break;
            }
        }
        

        internal static double FahrenheitToCelcius(double input)
        {
            return (input - 32)*(5.0 / 9.0);
            //return (input - 32)*(5/9);
        }

        internal static double CelciusToFahrenheit(double input)
        {
            //Round(input * (9.0/5.0) + 32)
            return Math.Round(input * (9.0 / 5.0) + 32, 1);
        }

        
    }
}
