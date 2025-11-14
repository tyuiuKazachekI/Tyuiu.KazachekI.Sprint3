using System;
using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.KazachekI.Sprint3.Task1.V27.Lib
{
    public class DataService : ISprint3Task1V27
    {
        public double GetMultiplySeries(double value, int startValue, int stopValue)
        {
            double result = 1.0;

            for (int k = startValue; k <= stopValue; k++)
            {
                double power = Math.Pow(value, k);
                double fraction = 1.0 / power;
                double cube = Math.Pow(fraction, 3);
                result *= cube;
            }

            return Math.Round(result, 1);
        }
    }
}