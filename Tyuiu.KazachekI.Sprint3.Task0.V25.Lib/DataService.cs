using System;
using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.KazachekI.Sprint3.Task0.V25.Lib
{
    public class DataService : ISprint3Task0V25
    {
        public double GetSumSeries(int value, int startValue, int stopValue)
        {
            double sum = 0;

            double constant = 4.0 / (1 + Math.Pow(value, 2));

            for (int i = startValue; i <= stopValue; i++)
            {
                double term = Math.Pow(constant, i);
                sum += term;
            }

            return sum;
        }
    }
}