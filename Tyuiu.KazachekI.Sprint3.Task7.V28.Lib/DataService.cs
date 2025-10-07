using System;
using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.KazachekI.Sprint3.Task7.V28.Lib
{
    public class DataService : ISprint3Task7V28
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            int length = stopValue - startValue + 1;
            double[] resultArray = new double[length];

            int count = 0;
            for (int x = startValue; x <= stopValue; x++)
            {
                // Проверка деления на ноль: x + 2.5 = 0
                if (Math.Abs(x + 2.5) < 0.0001) // x = -2.5
                {
                    resultArray[count] = 0;
                }
                else
                {
                    // Вычисление функции: f(x) = cos(2x) + sin(x)/(x+2.5) + 2x
                    double cos2x = Math.Cos(2 * x);
                    double sinX = Math.Sin(x);
                    double denominator = x + 2.5;
                    double fraction = sinX / denominator;
                    double functionValue = cos2x + fraction + 2 * x;

                    resultArray[count] = Math.Round(functionValue, 2);
                }

                count++;
            }

            return resultArray;
        }
    }
}