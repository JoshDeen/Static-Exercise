using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticExercise
{
    static class TempConverter
    {
        public static double FahrenheitToCelsius(double farhenheit) 
        {
            var result = (farhenheit - 32) / 1.8;
            return result;

        }
        public static double CelsiusToFahrenheit(double celsius) 
        {
            return (celsius * 9) / 5 + 32;
        
        }


    }
}
