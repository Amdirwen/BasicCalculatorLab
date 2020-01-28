using System;

namespace BasicCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*** BASIC DEW POINT CALCULATOR ***");

            Console.WriteLine("Enter the air temperature (in degrees farenheit)");

            // int.Parse will take a string data type and convert it to an int data type
            int temperature = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the relative humidity");
            int relativeHumidity = int.Parse(Console.ReadLine());

            int dewPoint = temperature - 9*(100-relativeHumidity)/25;

            Console.WriteLine("The dew point is " + dewPoint);

            Console.WriteLine("Enter the wind speed in mph");
            int windSpeed = int.Parse(Console.ReadLine());


            double windChill = 35.75 + 0.6215*temperature - 35.75*Math.Pow(windSpeed, 0.16) + 0.4275*temperature*Math.Pow(windSpeed, 0.16);

            Console.WriteLine("The wind chill is " + windChill);
        }
    }
}
