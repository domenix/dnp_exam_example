using System;
using TemperatureConverter;

namespace TestTemperatureConverter
{
    class Program
    {

        public static void TestConvert20CtoF() {
            System.Console.WriteLine(TemperatureConverter.Convert.ToFahrenheit(20));
        }

        public static void TestCArrayToF() {
            double[] Temperatures = { 60.0, 68.4, 72.2, 80.1, 20.8, 12.2 };

            foreach(var item in Temperatures) {
                System.Console.WriteLine(TemperatureConverter.Convert.ToFahrenheit(item));
            }
        }

        static void Main(string[] args)
        {
            TestConvert20CtoF();
            TestCArrayToF();
        }
    }
}
