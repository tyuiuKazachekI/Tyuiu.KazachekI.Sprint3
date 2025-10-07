using System;
using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.KazachekI.Sprint3.Task2.V8.Lib
{
    public class DataService : ISprint3Task2V8
    {
        public double GetMultiplySeries(int startValue, int stopValue)
        {
            double product = 1.0;
            int k = startValue;

            // Вычисляем константу один раз перед циклом
            double cos5 = Math.Cos(5);
            double denominator = cos5 + 1;
            double term = 1.0 / Math.Pow(denominator, 2); // [1/(cos(5) + 1)]²

            // Используем цикл do...while для вычисления произведения ряда
            do
            {
                // Умножаем на текущее произведение (одна и та же константа 15 раз)
                product *= term;

                k++;
            }
            while (k <= stopValue);

            return Math.Round(product, 3);
        }
    }
}