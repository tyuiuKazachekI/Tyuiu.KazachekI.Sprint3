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

            // Используем цикл do...while для вычисления произведения ряда
            do
            {
                // Вычисляем cos(k)
                double cosK = Math.Cos(k);

                // Вычисляем (cos(k) + 1)²
                double denominatorSquared = Math.Pow(cosK + 1, 2);

                // Вычисляем 1/(cos(k) + 1)²
                double term = 1.0 / denominatorSquared;

                // Умножаем на текущее произведение
                product *= term;

                k++;
            }
            while (k <= stopValue);

            return Math.Round(product, 3); // Округляем до 3 знаков как в ожидаемом результате 0.001
        }
    }
}