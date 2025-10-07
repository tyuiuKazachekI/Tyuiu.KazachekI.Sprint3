using System;
using tyuiu.cources.programming.interfaces.Sprint3;
using Tyuiu.Cources.Programming.Interfaces.Sprint3;

namespace Tyuiu.KazachekI.Sprint3.Task2.V8.Lib
{
    public class DataService : ISprint3Task2V8
    {
        public double GetMultiplySeries(int startValue, int stopValue)
        {
            double product = 1.0;
            int k = startValue;

            do
            {
                // Вычисляем 1/(cos(k) + 1)
                double fraction = 1.0 / (Math.Cos(k) + 1);

                // Возводим в степень k: [1/(cos(k) + 1)]^k
                double term = Math.Pow(fraction, k);

                // Умножаем на текущее произведение
                product *= term;

                k++;
            }
            while (k <= stopValue);

            return Math.Round(product, 3);
        }
    }
}