using System;
using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.KazachekI.Sprint3.Task2.V8.Lib
{
    public class DataService : ISprint3Task2V8
    {
        public double GetMultiplySeries(int startValue, int stopValue)
        {
            double result = 1.0;

            double cos5 = Math.Cos(5);
            double value = 1.0 / Math.Pow(cos5 + 1, 2);

            for (int k = startValue; k <= stopValue; k++)
            {
                result *= value;
            }

            return Math.Round(result, 3);
        }
    }
}